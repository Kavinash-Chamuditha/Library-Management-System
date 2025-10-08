using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;  
using Microsoft.Data.SqlClient;

namespace Library_Management_System
{
    public partial class IssueBooks : Form
    {
        
        private int count = 0;

        public IssueBooks()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void button3_Click(object sender, EventArgs e) { this.Close(); }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtEnrollment.Text == "")
            {
                txtName.Clear();
                txtDep.Clear();
                txtSem.Clear();
                txtContact.Clear();
                txtEmail.Clear();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtEnrollment.Text != "")
            {
                string enroll = txtEnrollment.Text;
                using (SqlConnection con = new SqlConnection("Data Source=MSI\\SQLEXPRESS; Initial Catalog=Library; Integrated Security=True; TrustServerCertificate=True"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM NewStudent WHERE enroll=@enroll", con);
                    cmd.Parameters.AddWithValue("@enroll", enroll);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    SqlCommand cmd2 = new SqlCommand("SELECT COUNT(enroll) FROM IRBook WHERE enroll=@enroll AND book_returndate IS NULL", con);
                    cmd2.Parameters.AddWithValue("@enroll", enroll);
                    count = Convert.ToInt32(cmd2.ExecuteScalar());
                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                        txtDep.Text = ds.Tables[0].Rows[0][3].ToString();
                        txtSem.Text = ds.Tables[0].Rows[0][4].ToString();
                        txtContact.Text = ds.Tables[0].Rows[0][5].ToString();
                        txtEmail.Text = ds.Tables[0].Rows[0][6].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Enrollment Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtName.Clear();
                        txtDep.Clear();
                        txtSem.Clear();
                        txtContact.Clear();
                        txtEmail.Clear();
                    }
                }
            }
        }

        private void IssueBooks_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=MSI\\SQLEXPRESS; Initial Catalog=Library; Integrated Security=True; TrustServerCertificate=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT bName FROM NewBook", con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    comboBox1.Items.Add(sdr.GetString(0));
                }
                sdr.Close();
            }
        }
        private void UpdateAvailability(string bname)
        {
            using (SqlConnection con = new SqlConnection("Data Source=MSI\\SQLEXPRESS; Initial Catalog=Library; Integrated Security=True; TrustServerCertificate=True"))
            {
                con.Open();

                // Get total quantity from NewBook
                SqlCommand qtyCmd = new SqlCommand("SELECT bQuan FROM NewBook WHERE bName=@bname", con);
                qtyCmd.Parameters.AddWithValue("@bname", bname);
                int totalQty = Convert.ToInt32(qtyCmd.ExecuteScalar());

                // Get issued count (not returned) from IRBook
                SqlCommand issuedCmd = new SqlCommand("SELECT COUNT(*) FROM IRBook WHERE bname=@bname AND book_returndate IS NULL", con);
                issuedCmd.Parameters.AddWithValue("@bname", bname);
                int issuedCount = Convert.ToInt32(issuedCmd.ExecuteScalar());

                // Decide availability
                string available = (totalQty - issuedCount > 0) ? "Yes" : "No";

                // Update availability column
                SqlCommand updateCmd = new SqlCommand("UPDATE NewBook SET Available=@available WHERE bName=@bname", con);
                updateCmd.Parameters.AddWithValue("@available", available);
                updateCmd.Parameters.AddWithValue("@bname", bname);
                updateCmd.ExecuteNonQuery();
            }
        }


        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                if (comboBox1.SelectedIndex != -1)
                {
                    string enroll = txtEnrollment.Text;
                    string sname = txtName.Text;
                    string sdep = txtDep.Text;
                    string sem = txtSem.Text;
                    string contact = txtContact.Text;
                    string email = txtEmail.Text;
                    string bname = comboBox1.Text;
                    string bookIssueDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                    using (SqlConnection con = new SqlConnection("Data Source=MSI\\SQLEXPRESS; Initial Catalog=Library; Integrated Security=True; TrustServerCertificate=True"))
                    {
                        con.Open();

                        // 1. Check if book is available
                        SqlCommand availCmd = new SqlCommand(@"
                    SELECT CASE 
                             WHEN bQuan - ISNULL((SELECT COUNT(*) FROM IRBook WHERE bname = NewBook.bName AND book_returndate IS NULL), 0) > 0
                             THEN 'Yes'
                             ELSE 'No'
                           END AS Availability
                    FROM NewBook
                    WHERE bName = @bname", con);
                        availCmd.Parameters.AddWithValue("@bname", bname);
                        string availability = (string)availCmd.ExecuteScalar();

                        if (availability == "No")
                        {
                            MessageBox.Show("This book is not available right now!", "Not Available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // stop issuing
                        }

                        // 2. Check how many books the student already issued
                        SqlCommand countCmd = new SqlCommand(
                            "SELECT COUNT(*) FROM IRBook WHERE enroll=@enroll AND book_returndate IS NULL", con);
                        countCmd.Parameters.AddWithValue("@enroll", enroll);
                        int issuedCount = Convert.ToInt32(countCmd.ExecuteScalar());

                        if (issuedCount >= 3)
                        {
                            MessageBox.Show("Maximum 3 books can be issued for a student", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // 3. Check if student already issued the same book
                        SqlCommand sameBookCmd = new SqlCommand(
                            "SELECT COUNT(*) FROM IRBook WHERE enroll=@enroll AND bname=@bname AND book_returndate IS NULL", con);
                        sameBookCmd.Parameters.AddWithValue("@enroll", enroll);
                        sameBookCmd.Parameters.AddWithValue("@bname", bname);
                        int sameBookCount = Convert.ToInt32(sameBookCmd.ExecuteScalar());

                        if (sameBookCount > 0)
                        {
                            MessageBox.Show("This student has already issued this book and not returned it!", "Book Already Issued", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // 4. Issue the book
                        SqlCommand cmd = new SqlCommand(
                            "INSERT INTO IRBook(enroll, sname, sdep, sem, contact, email, bname, bookissuedate) " +
                            "VALUES(@enroll, @sname, @sdep, @sem, @contact, @email, @bname, @bookissuedate)", con);

                        cmd.Parameters.AddWithValue("@enroll", enroll);
                        cmd.Parameters.AddWithValue("@sname", sname);
                        cmd.Parameters.AddWithValue("@sdep", sdep);
                        cmd.Parameters.AddWithValue("@sem", sem);
                        cmd.Parameters.AddWithValue("@contact", contact);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@bname", bname);
                        cmd.Parameters.AddWithValue("@bookissuedate", bookIssueDate);

                        cmd.ExecuteNonQuery();
                        UpdateAvailability(bname);

                        MessageBox.Show("Book Issued Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Select a Book", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Enter Valid Enrollment No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            txtEnrollment.Clear();
            txtName.Clear();
            txtDep.Clear();
            txtSem.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            comboBox1.SelectedIndex = -1;  
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}

using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;

namespace Library_Management_System
{
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(
            "Data Source=MSI\\SQLEXPRESS; Initial Catalog=Library; Integrated Security=True; TrustServerCertificate=True");

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(@"
                    SELECT id, enroll, sname, sdep, sem, contact, email, bname, bookissuedate, book_returndate
                    FROM IRBook WHERE enroll = @enroll", con);

                cmd.Parameters.AddWithValue("@enroll", txtEnterEnroll.Text.Trim());

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.Columns["id"].HeaderText = "ID";
                    dataGridView1.Columns["enroll"].HeaderText = "Enrollment No";
                    dataGridView1.Columns["sname"].HeaderText = "Student Name";
                    dataGridView1.Columns["sdep"].HeaderText = "Department";
                    dataGridView1.Columns["sem"].HeaderText = "Semester";
                    dataGridView1.Columns["contact"].HeaderText = "Contact";
                    dataGridView1.Columns["email"].HeaderText = "Email";
                    dataGridView1.Columns["bname"].HeaderText = "Book";
                    dataGridView1.Columns["bookissuedate"].HeaderText = "Issue Date";
                    dataGridView1.Columns["book_returndate"].HeaderText = "Return Date";




                    if (dataGridView1.Columns.Contains("id"))
                        dataGridView1.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    if (dataGridView1.Columns.Contains("enroll"))
                        dataGridView1.Columns["enroll"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    if (dataGridView1.Columns.Contains("sdep"))
                        dataGridView1.Columns["sdep"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    if (dataGridView1.Columns.Contains("bookissuedate"))
                        dataGridView1.Columns["bookissuedate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dataGridView1.Columns["sdep"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    if (dataGridView1.Columns.Contains("book_returndate"))
                        dataGridView1.Columns["book_returndate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    if (dataGridView1.Columns.Contains("contact"))
                        dataGridView1.Columns["contact"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    if (dataGridView1.Columns.Contains("sem"))
                        dataGridView1.Columns["sem"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dataGridView1.Columns["sdep"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    if (dataGridView1.Columns.Contains("bname"))
                        dataGridView1.Columns["bname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 188, 156);
                    dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dataGridView1.EnableHeadersVisualStyles = false;
                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

                }
                else
                {
                    MessageBox.Show("Invalid Enrollment No OR No Book Issued",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message);
            }
        }

        private void LoadLateFees()
        {
            string connectionString = "Data Source=MSI\\SQLEXPRESS; Initial Catalog=Library; Integrated Security=True; TrustServerCertificate=True";

            string query = @"
        INSERT INTO LateFee (StudentName, BookName, IssueDate, ReturnDate, LateDays, LateFee, StudentEnroll)
        SELECT 
            sname AS StudentName,
            bname AS BookName,
            bookissuedate AS IssueDate,
            book_returndate AS ReturnDate,
            CASE 
                WHEN DATEDIFF(DAY, bookissuedate, book_returndate) > 14
                THEN DATEDIFF(DAY, bookissuedate, book_returndate) - 14
                ELSE 0
            END AS LateDays,
            CASE 
                WHEN DATEDIFF(DAY, bookissuedate, book_returndate) > 14
                THEN (DATEDIFF(DAY, bookissuedate, book_returndate) - 14) * 5
                ELSE 0
            END AS LateFee,
            enroll AS StudentEnroll  -- ✅ ADD THIS
        FROM IRBook
        WHERE book_returndate IS NOT NULL
          AND NOT EXISTS (
              SELECT 1 FROM LateFee lf 
              WHERE lf.StudentName = IRBook.sname 
                AND lf.BookName = IRBook.bname 
                AND lf.IssueDate = IRBook.bookissuedate
                AND lf.ReturnDate = IRBook.book_returndate
          );";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading late fees: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateAvailability(string bname)
        {
            using (SqlConnection con = new SqlConnection("Data Source=MSI\\SQLEXPRESS; Initial Catalog=Library; Integrated Security=True; TrustServerCertificate=True"))
            {
                con.Open();


                SqlCommand qtyCmd = new SqlCommand("SELECT bQuan FROM NewBook WHERE bName=@bname", con);
                qtyCmd.Parameters.AddWithValue("@bname", bname);
                int totalQty = Convert.ToInt32(qtyCmd.ExecuteScalar());


                SqlCommand issuedCmd = new SqlCommand("SELECT COUNT(*) FROM IRBook WHERE bname=@bname AND book_returndate IS NULL", con);
                issuedCmd.Parameters.AddWithValue("@bname", bname);
                int issuedCount = Convert.ToInt32(issuedCmd.ExecuteScalar());


                string available = (totalQty - issuedCount > 0) ? "Yes" : "No";


                SqlCommand updateCmd = new SqlCommand("UPDATE NewBook SET Available=@available WHERE bName=@bname", con);
                updateCmd.Parameters.AddWithValue("@available", available);
                updateCmd.Parameters.AddWithValue("@bname", bname);
                updateCmd.ExecuteNonQuery();
            }
        }


        private void ReturnBook_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;


        }

        string bName;
        string bDate;
        long rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                panel2.Visible = true;

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                rowid = Convert.ToInt64(row.Cells["id"].Value);
                bName = row.Cells["bname"].Value.ToString();
                bDate = row.Cells["bookissuedate"].Value.ToString();

                txtBookName.Text = bName;
                txtBookIssueDate.Text = bDate;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

            string updateLateFeeQuery = @"
    UPDATE lf
    SET StudentEnroll = i.enroll
    FROM LateFee lf
    INNER JOIN IRBook i ON lf.StudentName = i.sname 
                         AND lf.IssueDate = i.bookissuedate
    WHERE i.enroll = @enroll 
      AND i.id = @id;";

            using (SqlCommand updateCmd = new SqlCommand(updateLateFeeQuery, con))
            {
                updateCmd.Parameters.AddWithValue("@enroll", txtEnterEnroll.Text.Trim());
                updateCmd.Parameters.AddWithValue("@id", rowid);

                con.Open();
                updateCmd.ExecuteNonQuery();
                con.Close();
            }
            try
            {

                SqlCommand checkCmd = new SqlCommand(@"
            SELECT book_returndate 
            FROM IRBook 
            WHERE enroll = @enroll AND id = @id", con);

                checkCmd.Parameters.AddWithValue("@enroll", txtEnterEnroll.Text.Trim());
                checkCmd.Parameters.AddWithValue("@id", rowid);

                con.Open();
                object result = checkCmd.ExecuteScalar();
                con.Close();

                if (result != DBNull.Value && result != null)
                {

                    MessageBox.Show("This book has already been returned!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                SqlCommand cmd = new SqlCommand(@"
            UPDATE IRBook 
            SET book_returndate = @retDate 
            WHERE enroll = @enroll AND id = @id", con);

                cmd.Parameters.AddWithValue("@retDate", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@enroll", txtEnterEnroll.Text.Trim());
                cmd.Parameters.AddWithValue("@id", rowid);

                con.Open();
                cmd.ExecuteNonQuery();
                UpdateAvailability(bName);

                LoadLateFees();


                con.Close();

                MessageBox.Show("Return Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                ReturnBook_Load(this, null);
            }
            catch (Exception ex)
            {
                if (con.State == System.Data.ConnectionState.Open) con.Close();
                MessageBox.Show("Return error: " + ex.Message);
            }



        }



        private void txtEnterEnroll_TextChanged(object sender, EventArgs e)
        {
            if (txtEnterEnroll.Text != "")
            {
                panel2.Visible = false;
                dataGridView1.DataSource = null;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnterEnroll.Clear();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtBookName.Clear();
            txtBookIssueDate.Clear();
            panel2.Visible = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnSearchStudent.PerformClick();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            btnSearchStudent.PerformClick();
        }
    }
}

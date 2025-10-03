using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Library_Management_System
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEnrollment.Clear();
            txtDepartment.Clear();
            txtSemester.Clear();
            txtEmail.Clear();
            txtContact.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check if all fields are filled
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEnrollment.Text) ||
                string.IsNullOrWhiteSpace(txtDepartment.Text) ||
                string.IsNullOrWhiteSpace(txtSemester.Text) ||
                string.IsNullOrWhiteSpace(txtContact.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please fill all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = txtName.Text;
            string enroll = txtEnrollment.Text;
            string dep = txtDepartment.Text;
            string sem = txtSemester.Text;
            string email = txtEmail.Text;

           
            if (!Int64.TryParse(txtContact.Text, out Int64 mobile) || txtContact.Text.Length != 10)
            {
                MessageBox.Show("Contact number must be exactly 10 digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!email.Contains("@"))
            {
                MessageBox.Show("Email must contain '@' symbol!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=MSI\\SQLEXPRESS; Initial Catalog=Library; Integrated Security=True; TrustServerCertificate=True"))
                {
                    string query = "INSERT INTO NewStudent(sname, enroll, dep, sem, contact, email) " +
                                   "VALUES (@name, @enroll, @dep, @sem, @contact, @email)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@enroll", enroll);
                        cmd.Parameters.AddWithValue("@dep", dep);
                        cmd.Parameters.AddWithValue("@sem", sem);
                        cmd.Parameters.AddWithValue("@contact", mobile);
                        cmd.Parameters.AddWithValue("@email", email);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Data Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnRefresh_Click(sender, e); 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

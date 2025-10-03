using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class ViewStudentInformation : Form
    {
        public ViewStudentInformation()
        {
            InitializeComponent();

            this.dataGridView1.CellClick += new DataGridViewCellEventHandler(this.dataGridView1_CellClick);
        }

        SqlConnection con = new SqlConnection(
            "Data Source=MSI\\SQLEXPRESS; Initial Catalog=Library; Integrated Security=True; TrustServerCertificate=True");

       
        int selectedStudentID = 0;

        private void ViewStudentInformation_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            LoadStudents();
        }


        private void LoadStudents()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM NewStudent", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
              

                if (dataGridView1.Columns.Contains("id"))
                    dataGridView1.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                if (dataGridView1.Columns.Contains("contact"))
                    dataGridView1.Columns["contact"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                if (dataGridView1.Columns.Contains("sem"))
                    dataGridView1.Columns["sem"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 188, 156);
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridView1.EnableHeadersVisualStyles = false;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

               
                if (dataGridView1.Columns["student_id"] != null)
                    dataGridView1.Columns["student_id"].HeaderText = "Student Id";
                if (dataGridView1.Columns["sname"] != null)
                    dataGridView1.Columns["sname"].HeaderText = "Student Name";
                if (dataGridView1.Columns["enroll"] != null)
                    dataGridView1.Columns["enroll"].HeaderText = "Enrollment Number";
                if (dataGridView1.Columns["dep"] != null)
                    dataGridView1.Columns["dep"].HeaderText = "Department";
                if (dataGridView1.Columns["sem"] != null)
                    dataGridView1.Columns["sem"].HeaderText = "Semester";
                if (dataGridView1.Columns["contact"] != null)
                    dataGridView1.Columns["contact"].HeaderText = "Contact";
                if (dataGridView1.Columns["email"] != null)
                    dataGridView1.Columns["email"].HeaderText = "Email";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message);
            }
        }


        // Search students by enrollment or name
        private void txtSearchEnrollment_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearchEnrollment.Text.Trim();
                SqlCommand cmd;

                if (!string.IsNullOrEmpty(searchText))
                {
                    cmd = new SqlCommand(
                        "SELECT * FROM NewStudent WHERE enroll LIKE @search OR sname LIKE @search", con);
                    cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");
                }
                else
                {
                    cmd = new SqlCommand("SELECT * FROM NewStudent", con);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message);
            }
        }

        // Refresh button
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearchEnrollment.Clear();
            ClearPanel();
            LoadStudents();
        }

        // When row clicked → show in panel2
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells["student_id"].Value != null)
            {
                selectedStudentID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["student_id"].Value);

                panel2.Visible = true;
                panel2.BringToFront();

                try
                {
                    SqlCommand cmd = new SqlCommand(
                        "SELECT * FROM NewStudent WHERE student_id=@id", con);
                    cmd.Parameters.AddWithValue("@id", selectedStudentID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow row = ds.Tables[0].Rows[0];
                        txtName.Text = row["sname"].ToString();
                        txtEnrollment.Text = row["enroll"].ToString();
                        txtDepartment.Text = row["dep"].ToString();
                        txtSemester.Text = row["sem"].ToString();
                        txtContact.Text = row["contact"].ToString();
                        txtEmail.Text = row["email"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading student data: " + ex.Message);
                }
            }
        }

        // Update student
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedStudentID == 0) return;

            try
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE NewStudent SET sname=@name, enroll=@enroll, dep=@dep, sem=@sem, contact=@contact, email=@email WHERE student_id=@id", con);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@enroll", txtEnrollment.Text);
                cmd.Parameters.AddWithValue("@dep", txtDepartment.Text);
                cmd.Parameters.AddWithValue("@sem", txtSemester.Text);
                cmd.Parameters.AddWithValue("@contact", txtContact.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@id", selectedStudentID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStudents();
                ClearPanel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
            }
        }

        // Delete student
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedStudentID == 0) return;

            DialogResult dr = MessageBox.Show(
                "Are you sure you want to delete this student?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM NewStudent WHERE student_id=@id", con);
                    cmd.Parameters.AddWithValue("@id", selectedStudentID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Student deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudents();
                    ClearPanel();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete error: " + ex.Message);
                }
            }
        }

       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearPanel();
        }

        
        private void ClearPanel()
        {
            txtName.Clear();
            txtEnrollment.Clear();
            txtDepartment.Clear();
            txtSemester.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            selectedStudentID = 0;
            panel2.Visible = false;
        }
    }
}

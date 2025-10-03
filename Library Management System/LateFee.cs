using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Management_System
{
    public partial class LateFee : Form
    {
        public LateFee()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }



        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI\\SQLEXPRESS; Initial Catalog=Library; Integrated Security=True; TrustServerCertificate=True";


            string query = @"
    SELECT
        LateFeeID AS[Late Fee ID],
        StudentName AS[Student Name],
        BookName AS[Book Name],
        IssueDate AS[Issue Date],
        ReturnDate AS[Return Date],
        LateDays AS[Late Days],
        LateFee AS[Late Fee],
        CASE
            WHEN Paid = 1 THEN 'Paid'
            ELSE 'Not Paid'
        END AS[Payment Status]
    FROM LateFee
    WHERE LateFee > 0
      AND StudentEnroll = @enroll; ";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@enroll", txtEnterEnroll.Text.Trim());
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No students with late fees found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = null;
                        return;
                    }

                    dataGridView1.DataSource = dt;


                    dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                    DataGridViewCellStyle headerStyle = new DataGridViewCellStyle
                    {
                        BackColor = Color.FromArgb(26, 188, 156),
                        ForeColor = Color.White,
                        Font = new Font(dataGridView1.Font, FontStyle.Bold)
                    };
                    dataGridView1.ColumnHeadersDefaultCellStyle = headerStyle;
                    dataGridView1.EnableHeadersVisualStyles = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridView1.DataSource = null;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtStudentName.Text = row.Cells["Student Name"].Value?.ToString() ?? "";
                txtBookName.Text = row.Cells["Book Name"].Value?.ToString() ?? "";


                dateTimePicker1.Value = DateTime.Now;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void btnPay_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("Please click a row to select a student.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dataGridView1.CurrentRow;

            string studentName = row.Cells["Student Name"].Value?.ToString() ?? "";
            string bookName = row.Cells["Book Name"].Value?.ToString() ?? "";

            if (string.IsNullOrWhiteSpace(studentName) || string.IsNullOrWhiteSpace(bookName))
            {
                MessageBox.Show("Student or Book name is missing. Please select a valid row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DateTime.TryParse(row.Cells["Issue Date"].Value?.ToString(), out DateTime issueDate))
            {
                MessageBox.Show("Invalid issue date in the selected record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Data Source=MSI\\SQLEXPRESS; Initial Catalog=Library; Integrated Security=True; TrustServerCertificate=True";
            string query = @"
        UPDATE LateFee 
        SET Paid = 1, PaymentDate = @PaymentDate
        WHERE StudentName = @StudentName 
          AND BookName = @BookName 
          AND LateFeeID =@LateFeeID";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@StudentName", studentName);
                    cmd.Parameters.AddWithValue("@BookName", bookName);
                    cmd.Parameters.AddWithValue("@IssueDate", issueDate);
                    cmd.Parameters.AddWithValue("@PaymentDate", dateTimePicker1.Value);

                    
                    if (!int.TryParse(dataGridView1.CurrentRow.Cells["Late Fee ID"].Value?.ToString(), out int lateFeeID))
                    {
                        MessageBox.Show("Invalid Late Fee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    cmd.Parameters.AddWithValue("@LateFeeID", lateFeeID);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Payment recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnSearchStudent_Click(sender, e); // Refresh
                    }
                    else
                    {
                        MessageBox.Show("No matching record found to update.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            txtStudentName.Clear();
            
            txtBookName.Clear();
            
        }
    }
}

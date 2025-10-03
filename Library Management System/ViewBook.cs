using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
        }

        int bid;
        Int64 rowid;

        private void ViewBook_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            LoadBookData();
        }

        private void LoadBookData(string bookNameFilter = "")
        {
            using (SqlConnection con = new SqlConnection("Data Source=MSI\\SQLEXPRESS; Initial Catalog=Library; Integrated Security=True; TrustServerCertificate=True"))
            {
                string query = @"
                    SELECT 
                        bid AS [Book ID],
                        bName AS [Book Name],
                        bAuthor AS [Author],
                        bPub1 AS [Publication],
                        bPDate AS [Publication Date],
                        bPrice AS [Price],
                        bQuan AS [Quantity],
                        CASE 
                            WHEN bQuan - ISNULL((SELECT COUNT(*) FROM IRBook WHERE bname = NewBook.bName AND book_returndate IS NULL), 0) > 0
                            THEN 'Yes'
                            ELSE 'No'
                        END AS [Availability]
                    FROM NewBook";

                if (!string.IsNullOrEmpty(bookNameFilter))
                {
                    query += " WHERE bName LIKE @bName";
                }

                SqlCommand cmd = new SqlCommand(query, con);
                if (!string.IsNullOrEmpty(bookNameFilter))
                    cmd.Parameters.AddWithValue("@bName", "%" + bookNameFilter.Trim().Replace("'", "''") + "%");

                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);



                    dataGridView1.DataSource = dt;
                    if (dataGridView1.Columns.Contains("Book ID"))
                        dataGridView1.Columns["Book ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                    if (dataGridView1.Columns.Contains("Price"))
                        dataGridView1.Columns["Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                    if (dataGridView1.Columns.Contains("Quantity"))
                        dataGridView1.Columns["Quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                    if (dataGridView1.Columns.Contains("Availability"))
                        dataGridView1.Columns["Availability"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 188, 156);
                    dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dataGridView1.EnableHeadersVisualStyles = false;
                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading books: " + ex.Message);
                }
            }


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                bool unavailable = row.Cells["Availability"].Value?.ToString().Trim() == "No";

                row.DefaultCellStyle.BackColor = unavailable ? Color.FromArgb(231, 76, 60) : Color.White;
                row.DefaultCellStyle.ForeColor = unavailable ? Color.White : Color.Black;
            }


        }

    

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            LoadBookData(txtBookName.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                bid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            }

            panel2.Visible = true;

            using (SqlConnection con = new SqlConnection("Data Source=MSI\\SQLEXPRESS; Initial Catalog=Library; Integrated Security=True; TrustServerCertificate=True"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM NewBook WHERE bid = @bid", con);
                cmd.Parameters.AddWithValue("@bid", bid);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    DataRow row = ds.Tables[0].Rows[0];
                    rowid = row[0] != DBNull.Value ? Convert.ToInt64(row[0]) : 0;

                    txtBName.Text = row[1]?.ToString();
                    txtAuthor.Text = row[2]?.ToString();
                    txtPublication.Text = row[3]?.ToString();
                    txtPDate.Text = row[4]?.ToString();
                    txtPrice.Text = row[5]?.ToString();
                    txtQuantity.Text = row[6]?.ToString();
                }
                else
                {
                    MessageBox.Show("No record found for this book!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    panel2.Visible = false;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBookName.Clear();
            txtAuthor.Clear();
            txtPublication.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtPDate.Clear();

            panel2.Visible = false;
            LoadBookData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Be Updated. Confirm?", "Update Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                using (SqlConnection con = new SqlConnection("Data Source=MSI\\SQLEXPRESS; Initial Catalog=Library; Integrated Security=True; TrustServerCertificate=True"))
                {
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE NewBook SET bName=@bName, bAuthor=@bAuthor, bPub1=@bPub, bPDate=@pDate, bPrice=@price, bQuan=@quan WHERE bid=@bid", con);

                    cmd.Parameters.AddWithValue("@bName", txtBName.Text.Trim());
                    cmd.Parameters.AddWithValue("@bAuthor", txtAuthor.Text.Trim());
                    cmd.Parameters.AddWithValue("@bPub", txtPublication.Text.Trim());
                    cmd.Parameters.AddWithValue("@pDate", txtPDate.Text.Trim());
                    cmd.Parameters.AddWithValue("@price", Int64.Parse(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@quan", Int64.Parse(txtQuantity.Text));
                    cmd.Parameters.AddWithValue("@bid", rowid);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Record Updated Successfully");
                    LoadBookData();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Be Deleted. Confirm?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                using (SqlConnection con = new SqlConnection("Data Source=MSI\\SQLEXPRESS; Initial Catalog=Library; Integrated Security=True; TrustServerCertificate=True"))
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM NewBook WHERE bid=@bid", con);
                    cmd.Parameters.AddWithValue("@bid", rowid);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Record Deleted Successfully");
                    LoadBookData();
                }
            }
        }
    }
}

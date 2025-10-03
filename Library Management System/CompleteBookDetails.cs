using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class CompleteBookDetails : Form
    {
        public CompleteBookDetails()
        {
            InitializeComponent();
        }

        private void CompleteBookDetails_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=MSI\\SQLEXPRESS; Initial Catalog=Library; Integrated Security=True; TrustServerCertificate=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from IRBook where book_returndate is null";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            FormatGrid(dataGridView1);

            cmd.CommandText = "select * from IRBook where book_returndate is not null";
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dataGridView2.DataSource = ds1.Tables[0];
            FormatGrid(dataGridView2);
        }

        private void FormatGrid(DataGridView grid)
        {
           
            if (grid.Columns.Contains("id"))
                grid.Columns["id"].HeaderText = "ID";
            if (grid.Columns.Contains("enroll"))
                grid.Columns["enroll"].HeaderText = "Enrollment No";
            if (grid.Columns.Contains("sname"))
                grid.Columns["sname"].HeaderText = "Student Name";
            if (grid.Columns.Contains("sdep"))
                grid.Columns["sdep"].HeaderText = "Department";
            if (grid.Columns.Contains("sem"))
                grid.Columns["sem"].HeaderText = "Semester";
            if (grid.Columns.Contains("contact"))
                grid.Columns["contact"].HeaderText = "Contact";
            if (grid.Columns.Contains("email"))
                grid.Columns["email"].HeaderText = "Email";
            if (grid.Columns.Contains("bname"))
                grid.Columns["bname"].HeaderText = "Book";
            if (grid.Columns.Contains("bookissuedate"))
                grid.Columns["bookissuedate"].HeaderText = "Issue Date";
            if (grid.Columns.Contains("book_returndate"))
                grid.Columns["book_returndate"].HeaderText = "Return Date";

            if (grid.Columns.Contains("id"))
                grid.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            if (grid.Columns.Contains("enroll"))
                grid.Columns["enroll"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            if (grid.Columns.Contains("sdep"))
                grid.Columns["sdep"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            if (grid.Columns.Contains("bookissuedate"))
                grid.Columns["bookissuedate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            if (grid.Columns.Contains("book_returndate"))
                grid.Columns["book_returndate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            if (grid.Columns.Contains("contact"))
                grid.Columns["contact"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            if (grid.Columns.Contains("sem"))
                grid.Columns["sem"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            if (grid.Columns.Contains("bname"))
                grid.Columns["bname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 188, 156);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font(grid.Font, FontStyle.Bold);
        }
    }
}

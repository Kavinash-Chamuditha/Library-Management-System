using System.Data;

using Microsoft.Data.SqlClient;

namespace Library_Management_System
{
    public partial class Form1 : Form
    {
        private object textBox1_MouseClick;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }




        private void txtUsername_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection();
            con.ConnectionString =
                "Data Source=MSI\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";

        
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM loginTable WHERE username='" + txtUsername.Text + "' AND pass='" + txtPassword.Text + "'";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                Dashboardcs dsa = new Dashboardcs();
                dsa.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username Or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            con.Close();

        }
    }
}

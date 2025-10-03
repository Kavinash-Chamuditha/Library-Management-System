using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Dashboardcs : Form
    {
        public Dashboardcs()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {


                return;
            }
            Application.Exit();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {

            addBook ab = new addBook();
            ab.Show();
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBook vb = new ViewBook();
            vb.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AddStudent asForm = new AddStudent();
            asForm.ShowDialog();
        }

        private void viewStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudentInformation vi = new ViewStudentInformation();
            vi.Show();
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBooks ib = new IssueBooks();
            ib.Show();
        }

        private void Dashboardcs_Load(object sender, EventArgs e)
        {
















































































































        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook rb = new ReturnBook();
            rb.Show();
        }

        private void completeBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompleteBookDetails completeBookDetails = new CompleteBookDetails();
            completeBookDetails.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            LateFee lateFee = new LateFee();
            lateFee.Show();
        }
    }
}

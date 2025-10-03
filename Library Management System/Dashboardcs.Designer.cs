namespace Library_Management_System
{
    partial class Dashboardcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboardcs));
            menuStrip2 = new MenuStrip();
            booksToolStripMenuItem = new ToolStripMenuItem();
            addNewBookToolStripMenuItem = new ToolStripMenuItem();
            viewBooksToolStripMenuItem = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            addStudentToolStripMenuItem = new ToolStripMenuItem();
            viewStudentDetailsToolStripMenuItem = new ToolStripMenuItem();
            issueBooksToolStripMenuItem = new ToolStripMenuItem();
            returnBooksToolStripMenuItem = new ToolStripMenuItem();
            completeBookDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.FromArgb(14, 128, 87);
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { booksToolStripMenuItem, studentToolStripMenuItem, issueBooksToolStripMenuItem, returnBooksToolStripMenuItem, completeBookDetailsToolStripMenuItem, toolStripMenuItem2, exitToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1111, 58);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            menuStrip2.ItemClicked += menuStrip2_ItemClicked;
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewBookToolStripMenuItem, viewBooksToolStripMenuItem });
            booksToolStripMenuItem.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            booksToolStripMenuItem.ForeColor = Color.White;
            booksToolStripMenuItem.Image = (Image)resources.GetObject("booksToolStripMenuItem.Image");
            booksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(126, 54);
            booksToolStripMenuItem.Text = "Books";
            booksToolStripMenuItem.Click += booksToolStripMenuItem_Click;
            // 
            // addNewBookToolStripMenuItem
            // 
            addNewBookToolStripMenuItem.BackColor = Color.FromArgb(14, 128, 87);
            addNewBookToolStripMenuItem.ForeColor = Color.White;
            addNewBookToolStripMenuItem.Image = (Image)resources.GetObject("addNewBookToolStripMenuItem.Image");
            addNewBookToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addNewBookToolStripMenuItem.ImageTransparentColor = Color.FromArgb(26, 188, 156);
            addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            addNewBookToolStripMenuItem.Size = new Size(247, 56);
            addNewBookToolStripMenuItem.Text = "Add New Book";
            addNewBookToolStripMenuItem.Click += addNewBookToolStripMenuItem_Click;
            // 
            // viewBooksToolStripMenuItem
            // 
            viewBooksToolStripMenuItem.BackColor = Color.FromArgb(14, 128, 87);
            viewBooksToolStripMenuItem.ForeColor = Color.White;
            viewBooksToolStripMenuItem.Image = (Image)resources.GetObject("viewBooksToolStripMenuItem.Image");
            viewBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
            viewBooksToolStripMenuItem.Size = new Size(247, 56);
            viewBooksToolStripMenuItem.Text = "View Books";
            viewBooksToolStripMenuItem.Click += viewBooksToolStripMenuItem_Click;
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.BackColor = Color.FromArgb(26, 188, 156);
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addStudentToolStripMenuItem, viewStudentDetailsToolStripMenuItem });
            studentToolStripMenuItem.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentToolStripMenuItem.ForeColor = Color.White;
            studentToolStripMenuItem.Image = (Image)resources.GetObject("studentToolStripMenuItem.Image");
            studentToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(136, 54);
            studentToolStripMenuItem.Text = "Student";
            // 
            // addStudentToolStripMenuItem
            // 
            addStudentToolStripMenuItem.BackColor = Color.FromArgb(14, 128, 87);
            addStudentToolStripMenuItem.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addStudentToolStripMenuItem.ForeColor = Color.White;
            addStudentToolStripMenuItem.Image = (Image)resources.GetObject("addStudentToolStripMenuItem.Image");
            addStudentToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            addStudentToolStripMenuItem.Size = new Size(283, 56);
            addStudentToolStripMenuItem.Text = "Add Student";
            addStudentToolStripMenuItem.Click += addStudentToolStripMenuItem_Click;
            // 
            // viewStudentDetailsToolStripMenuItem
            // 
            viewStudentDetailsToolStripMenuItem.BackColor = Color.FromArgb(14, 128, 87);
            viewStudentDetailsToolStripMenuItem.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewStudentDetailsToolStripMenuItem.ForeColor = Color.White;
            viewStudentDetailsToolStripMenuItem.Image = (Image)resources.GetObject("viewStudentDetailsToolStripMenuItem.Image");
            viewStudentDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            viewStudentDetailsToolStripMenuItem.Name = "viewStudentDetailsToolStripMenuItem";
            viewStudentDetailsToolStripMenuItem.Size = new Size(283, 56);
            viewStudentDetailsToolStripMenuItem.Text = "View Student Details";
            viewStudentDetailsToolStripMenuItem.Click += viewStudentDetailsToolStripMenuItem_Click;
            // 
            // issueBooksToolStripMenuItem
            // 
            issueBooksToolStripMenuItem.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            issueBooksToolStripMenuItem.ForeColor = Color.White;
            issueBooksToolStripMenuItem.Image = (Image)resources.GetObject("issueBooksToolStripMenuItem.Image");
            issueBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            issueBooksToolStripMenuItem.Name = "issueBooksToolStripMenuItem";
            issueBooksToolStripMenuItem.Size = new Size(165, 54);
            issueBooksToolStripMenuItem.Text = "Issue Books";
            issueBooksToolStripMenuItem.Click += issueBooksToolStripMenuItem_Click;
            // 
            // returnBooksToolStripMenuItem
            // 
            returnBooksToolStripMenuItem.BackColor = Color.FromArgb(26, 188, 156);
            returnBooksToolStripMenuItem.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returnBooksToolStripMenuItem.ForeColor = Color.White;
            returnBooksToolStripMenuItem.Image = (Image)resources.GetObject("returnBooksToolStripMenuItem.Image");
            returnBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            returnBooksToolStripMenuItem.Name = "returnBooksToolStripMenuItem";
            returnBooksToolStripMenuItem.Size = new Size(177, 54);
            returnBooksToolStripMenuItem.Text = "Return Books";
            returnBooksToolStripMenuItem.Click += returnBooksToolStripMenuItem_Click;
            // 
            // completeBookDetailsToolStripMenuItem
            // 
            completeBookDetailsToolStripMenuItem.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            completeBookDetailsToolStripMenuItem.ForeColor = Color.White;
            completeBookDetailsToolStripMenuItem.Image = (Image)resources.GetObject("completeBookDetailsToolStripMenuItem.Image");
            completeBookDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            completeBookDetailsToolStripMenuItem.Name = "completeBookDetailsToolStripMenuItem";
            completeBookDetailsToolStripMenuItem.Size = new Size(246, 54);
            completeBookDetailsToolStripMenuItem.Text = "Complete Book Details";
            completeBookDetailsToolStripMenuItem.Click += completeBookDetailsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripMenuItem2.ForeColor = Color.White;
            toolStripMenuItem2.Image = (Image)resources.GetObject("toolStripMenuItem2.Image");
            toolStripMenuItem2.ImageAlign = ContentAlignment.TopCenter;
            toolStripMenuItem2.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(135, 54);
            toolStripMenuItem2.Text = "Late Fee";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = Color.FromArgb(26, 188, 156);
            exitToolStripMenuItem.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitToolStripMenuItem.ForeColor = Color.White;
            exitToolStripMenuItem.Image = (Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(103, 54);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Dashboardcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1111, 521);
            Controls.Add(menuStrip2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Dashboardcs";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += Dashboardcs_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip2;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem addNewBookToolStripMenuItem;
        private ToolStripMenuItem viewBooksToolStripMenuItem;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem addStudentToolStripMenuItem;
        private ToolStripMenuItem viewStudentDetailsToolStripMenuItem;
        private ToolStripMenuItem issueBooksToolStripMenuItem;
        private ToolStripMenuItem returnBooksToolStripMenuItem;
        private ToolStripMenuItem completeBookDetailsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ToolStripMenuItem toolStripMenuItem2;
    }
}
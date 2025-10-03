namespace Library_Management_System
{
    partial class IssueBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBooks));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            btnSearch = new Button();
            txtEnrollment = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            btnIssueBook = new Button();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            txtSem = new TextBox();
            txtDep = new TextBox();
            txtName = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(14, 128, 87);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(942, 125);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(331, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(445, 49);
            label1.Name = "label1";
            label1.Size = new Size(156, 40);
            label1.TabIndex = 3;
            label1.Text = "Issue Books";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.AutoSize = true;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(txtEnrollment);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Font = new Font("Microsoft Sans Serif", 8.25F);
            panel2.Location = new Point(12, 133);
            panel2.Name = "panel2";
            panel2.Size = new Size(259, 626);
            panel2.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(231, 76, 60);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(145, 453);
            button3.Name = "button3";
            button3.Size = new Size(94, 50);
            button3.TabIndex = 2;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(26, 188, 156);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(20, 453);
            button2.Name = "button2";
            button2.Size = new Size(94, 50);
            button2.TabIndex = 2;
            button2.Text = "Refresh";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(52, 152, 219);
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(46, 294);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(160, 68);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search Student";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtEnrollment
            // 
            txtEnrollment.BorderStyle = BorderStyle.FixedSingle;
            txtEnrollment.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEnrollment.Location = new Point(20, 213);
            txtEnrollment.Multiline = true;
            txtEnrollment.Name = "txtEnrollment";
            txtEnrollment.Size = new Size(219, 34);
            txtEnrollment.TabIndex = 2;
            txtEnrollment.TextAlign = HorizontalAlignment.Center;
            txtEnrollment.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 162);
            label2.Name = "label2";
            label2.Size = new Size(230, 36);
            label2.TabIndex = 2;
            label2.Text = "Enter Enrollement No";
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(58, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(148, 126);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnIssueBook);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(txtContact);
            panel3.Controls.Add(txtSem);
            panel3.Controls.Add(txtDep);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Font = new Font("Microsoft Sans Serif", 8.25F);
            panel3.Location = new Point(276, 133);
            panel3.Name = "panel3";
            panel3.Size = new Size(678, 626);
            panel3.TabIndex = 2;
            // 
            // btnIssueBook
            // 
            btnIssueBook.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnIssueBook.BackColor = Color.FromArgb(26, 188, 156);
            btnIssueBook.FlatStyle = FlatStyle.Popup;
            btnIssueBook.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIssueBook.ForeColor = Color.White;
            btnIssueBook.Location = new Point(539, 444);
            btnIssueBook.Name = "btnIssueBook";
            btnIssueBook.Size = new Size(126, 48);
            btnIssueBook.TabIndex = 15;
            btnIssueBook.Text = "Issue Book";
            btnIssueBook.UseVisualStyleBackColor = false;
            btnIssueBook.Click += btnIssueBook_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.Location = new Point(236, 380);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(429, 23);
            dateTimePicker1.TabIndex = 14;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(236, 317);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(429, 25);
            comboBox1.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(236, 261);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(429, 23);
            txtEmail.TabIndex = 12;
            // 
            // txtContact
            // 
            txtContact.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtContact.BorderStyle = BorderStyle.FixedSingle;
            txtContact.Location = new Point(236, 202);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(429, 23);
            txtContact.TabIndex = 11;
            // 
            // txtSem
            // 
            txtSem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSem.BorderStyle = BorderStyle.FixedSingle;
            txtSem.Location = new Point(236, 150);
            txtSem.Name = "txtSem";
            txtSem.Size = new Size(429, 23);
            txtSem.TabIndex = 10;
            // 
            // txtDep
            // 
            txtDep.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDep.BorderStyle = BorderStyle.FixedSingle;
            txtDep.Location = new Point(236, 93);
            txtDep.Name = "txtDep";
            txtDep.Size = new Size(429, 23);
            txtDep.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(236, 42);
            txtName.Name = "txtName";
            txtName.Size = new Size(429, 23);
            txtName.TabIndex = 8;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(289, 505);
            label10.Name = "label10";
            label10.Size = new Size(376, 23);
            label10.TabIndex = 7;
            label10.Text = "Maximum 3 Books Can be ISSUED  to 1 Student";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(25, 380);
            label9.Name = "label9";
            label9.Size = new Size(133, 23);
            label9.TabIndex = 6;
            label9.Text = "Book Issue Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(25, 317);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 5;
            label8.Text = "Book Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(25, 261);
            label7.Name = "label7";
            label7.Size = new Size(116, 23);
            label7.TabIndex = 4;
            label7.Text = "Student Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 202);
            label6.Name = "label6";
            label6.Size = new Size(135, 23);
            label6.TabIndex = 3;
            label6.Text = "Student Contact";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 150);
            label5.Name = "label5";
            label5.Size = new Size(145, 23);
            label5.TabIndex = 2;
            label5.Text = "Student Semester";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 96);
            label4.Name = "label4";
            label4.Size = new Size(102, 23);
            label4.TabIndex = 1;
            label4.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 45);
            label3.Name = "label3";
            label3.Size = new Size(121, 23);
            label3.TabIndex = 0;
            label3.Text = "Student Name";
            label3.Click += label3_Click;
            // 
            // IssueBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 128, 87);
            ClientSize = new Size(964, 771);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "IssueBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IssueBooks";
            Load += IssueBooks_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private TextBox txtEnrollment;
        private Button btnSearch;
        private Button button3;
        private Button button2;
        private Panel panel3;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private TextBox txtEmail;
        private TextBox txtContact;
        private TextBox txtSem;
        private TextBox txtDep;
        private TextBox txtName;
        private Button btnIssueBook;
        private PictureBox pictureBox1;
    }
}
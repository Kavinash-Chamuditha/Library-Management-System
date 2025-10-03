namespace Library_Management_System
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            btnSave = new Button();
            btnExit = new Button();
            btnRefresh = new Button();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            txtSemester = new TextBox();
            txtDepartment = new TextBox();
            txtEnrollment = new TextBox();
            txtName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 128, 87);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 135);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(522, 47);
            label1.Name = "label1";
            label1.Size = new Size(163, 40);
            label1.TabIndex = 1;
            label1.Text = "Add Student";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(382, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-2, 133);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(408, 520);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtContact);
            panel2.Controls.Add(txtSemester);
            panel2.Controls.Add(txtDepartment);
            panel2.Controls.Add(txtEnrollment);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(404, 133);
            panel2.Name = "panel2";
            panel2.Size = new Size(603, 520);
            panel2.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(52, 152, 219);
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(292, 432);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 40);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save Info";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(231, 76, 60);
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(438, 432);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 40);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(26, 188, 156);
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(172, 432);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(99, 40);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(214, 322);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(283, 27);
            txtEmail.TabIndex = 11;
            // 
            // txtContact
            // 
            txtContact.BorderStyle = BorderStyle.FixedSingle;
            txtContact.Location = new Point(214, 273);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(283, 27);
            txtContact.TabIndex = 10;
            // 
            // txtSemester
            // 
            txtSemester.BorderStyle = BorderStyle.FixedSingle;
            txtSemester.Location = new Point(214, 219);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(283, 27);
            txtSemester.TabIndex = 9;
            // 
            // txtDepartment
            // 
            txtDepartment.BorderStyle = BorderStyle.FixedSingle;
            txtDepartment.Location = new Point(214, 162);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(283, 27);
            txtDepartment.TabIndex = 8;
            // 
            // txtEnrollment
            // 
            txtEnrollment.BorderStyle = BorderStyle.FixedSingle;
            txtEnrollment.Location = new Point(214, 103);
            txtEnrollment.Name = "txtEnrollment";
            txtEnrollment.Size = new Size(283, 27);
            txtEnrollment.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(214, 52);
            txtName.Name = "txtName";
            txtName.Size = new Size(283, 27);
            txtName.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(39, 329);
            label8.Name = "label8";
            label8.Size = new Size(116, 23);
            label8.TabIndex = 5;
            label8.Text = "Student Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(38, 280);
            label7.Name = "label7";
            label7.Size = new Size(135, 23);
            label7.TabIndex = 4;
            label7.Text = "Student Contact";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(37, 222);
            label6.Name = "label6";
            label6.Size = new Size(145, 23);
            label6.TabIndex = 3;
            label6.Text = "Student Semester";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(37, 165);
            label5.Name = "label5";
            label5.Size = new Size(102, 23);
            label5.TabIndex = 2;
            label5.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(39, 106);
            label4.Name = "label4";
            label4.Size = new Size(121, 23);
            label4.TabIndex = 1;
            label4.Text = "Enrollment No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 52);
            label3.Name = "label3";
            label3.Size = new Size(121, 23);
            label3.TabIndex = 0;
            label3.Text = "Student Name";
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1007, 648);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Name = "AddStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStudent";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtContact;
        private TextBox txtSemester;
        private TextBox txtDepartment;
        private TextBox txtEnrollment;
        private TextBox txtName;
        private Button btnSave;
        private Button btnExit;
        private Button btnRefresh;
    }
}
namespace Library_Management_System
{
    partial class ViewStudentInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudentInformation));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txtSearchEnrollment = new TextBox();
            btnRefresh = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            button4 = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            txtSemester = new TextBox();
            txtDepartment = new TextBox();
            txtEnrollment = new TextBox();
            txtName = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(14, 128, 87);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(5, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1282, 198);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(729, 86);
            label2.Name = "label2";
            label2.Size = new Size(143, 53);
            label2.TabIndex = 2;
            label2.Text = "Student";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(750, 50);
            label1.Name = "label1";
            label1.Size = new Size(98, 53);
            label1.TabIndex = 1;
            label1.Text = "View";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(505, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 195);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(325, 222);
            label3.Name = "label3";
            label3.Size = new Size(160, 36);
            label3.TabIndex = 1;
            label3.Text = "Enrollment No";
            // 
            // txtSearchEnrollment
            // 
            txtSearchEnrollment.Location = new Point(491, 226);
            txtSearchEnrollment.Name = "txtSearchEnrollment";
            txtSearchEnrollment.Size = new Size(270, 27);
            txtSearchEnrollment.TabIndex = 2;
            txtSearchEnrollment.TextAlign = HorizontalAlignment.Center;
            txtSearchEnrollment.TextChanged += txtSearchEnrollment_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(26, 188, 156);
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(767, 220);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(99, 40);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 269);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1279, 286);
            dataGridView1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtContact);
            panel2.Controls.Add(txtSemester);
            panel2.Controls.Add(txtDepartment);
            panel2.Controls.Add(txtEnrollment);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(5, 561);
            panel2.Name = "panel2";
            panel2.Size = new Size(1279, 297);
            panel2.TabIndex = 5;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(52, 152, 219);
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(1031, 215);
            button4.Name = "button4";
            button4.Size = new Size(99, 47);
            button4.TabIndex = 14;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = false;
            button4.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(916, 215);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 47);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(26, 188, 156);
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(800, 215);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(98, 47);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(878, 144);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(252, 27);
            txtEmail.TabIndex = 11;
            // 
            // txtContact
            // 
            txtContact.BorderStyle = BorderStyle.FixedSingle;
            txtContact.Location = new Point(878, 88);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(252, 27);
            txtContact.TabIndex = 10;
            // 
            // txtSemester
            // 
            txtSemester.BorderStyle = BorderStyle.FixedSingle;
            txtSemester.Location = new Point(878, 34);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(252, 27);
            txtSemester.TabIndex = 9;
            // 
            // txtDepartment
            // 
            txtDepartment.BorderStyle = BorderStyle.FixedSingle;
            txtDepartment.Location = new Point(317, 151);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(252, 27);
            txtDepartment.TabIndex = 8;
            // 
            // txtEnrollment
            // 
            txtEnrollment.BorderStyle = BorderStyle.FixedSingle;
            txtEnrollment.Location = new Point(317, 88);
            txtEnrollment.Name = "txtEnrollment";
            txtEnrollment.Size = new Size(252, 27);
            txtEnrollment.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(317, 31);
            txtName.Name = "txtName";
            txtName.Size = new Size(252, 27);
            txtName.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(691, 151);
            label9.Name = "label9";
            label9.Size = new Size(116, 23);
            label9.TabIndex = 5;
            label9.Text = "Student Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(690, 94);
            label8.Name = "label8";
            label8.Size = new Size(135, 23);
            label8.TabIndex = 4;
            label8.Text = "Student Contact";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(690, 34);
            label7.Name = "label7";
            label7.Size = new Size(145, 23);
            label7.TabIndex = 3;
            label7.Text = "Student Semester";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(146, 158);
            label6.Name = "label6";
            label6.Size = new Size(102, 23);
            label6.TabIndex = 2;
            label6.Text = "Department";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(145, 95);
            label5.Name = "label5";
            label5.Size = new Size(121, 23);
            label5.TabIndex = 1;
            label5.Text = "Enrollment No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(146, 34);
            label4.Name = "label4";
            label4.Size = new Size(121, 23);
            label4.TabIndex = 0;
            label4.Text = "Student Name";
            // 
            // ViewStudentInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(14, 128, 87);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1288, 866);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(btnRefresh);
            Controls.Add(txtSearchEnrollment);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "ViewStudentInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewStudentInformation";
            Load += ViewStudentInformation_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtSearchEnrollment;
        private Button btnRefresh;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtEmail;
        private TextBox txtContact;
        private TextBox txtSemester;
        private TextBox txtDepartment;
        private TextBox txtEnrollment;
        private TextBox txtName;
        private Button button4;
        private Button btnDelete;
        private Button btnUpdate;
    }
}
namespace Library_Management_System
{
    partial class LateFee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LateFee));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            btnRefresh = new Button();
            btnSearchStudent = new Button();
            txtEnterEnroll = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            txtBookName = new TextBox();
            txtStudentName = new TextBox();
            label3 = new Label();
            btnCancel = new Button();
            btnPay = new Button();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(694, 37);
            label1.Name = "label1";
            label1.Size = new Size(137, 50);
            label1.TabIndex = 8;
            label1.Text = "Late Fee";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(284, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1063, 316);
            dataGridView1.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnSearchStudent);
            panel1.Controls.Add(txtEnterEnroll);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(11, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 541);
            panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(78, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(231, 76, 60);
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(140, 423);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(103, 50);
            btnExit.TabIndex = 6;
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
            btnRefresh.Location = new Point(15, 423);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(103, 50);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearchStudent
            // 
            btnSearchStudent.BackColor = Color.FromArgb(52, 152, 219);
            btnSearchStudent.FlatStyle = FlatStyle.Popup;
            btnSearchStudent.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchStudent.ForeColor = Color.White;
            btnSearchStudent.Location = new Point(49, 266);
            btnSearchStudent.Name = "btnSearchStudent";
            btnSearchStudent.Size = new Size(162, 77);
            btnSearchStudent.TabIndex = 4;
            btnSearchStudent.Text = "Search Student";
            btnSearchStudent.UseVisualStyleBackColor = false;
            btnSearchStudent.Click += btnSearchStudent_Click;
            // 
            // txtEnterEnroll
            // 
            txtEnterEnroll.BorderStyle = BorderStyle.FixedSingle;
            txtEnterEnroll.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEnterEnroll.Location = new Point(40, 193);
            txtEnterEnroll.Name = "txtEnterEnroll";
            txtEnterEnroll.Size = new Size(179, 31);
            txtEnterEnroll.TabIndex = 2;
            txtEnterEnroll.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 154);
            label2.Name = "label2";
            label2.Size = new Size(218, 36);
            label2.TabIndex = 1;
            label2.Text = "Enter Enrollment No";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(txtBookName);
            panel3.Controls.Add(txtStudentName);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnCancel);
            panel3.Controls.Add(btnPay);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(284, 445);
            panel3.Name = "panel3";
            panel3.Size = new Size(1063, 219);
            panel3.TabIndex = 11;
            // 
            // txtBookName
            // 
            txtBookName.BorderStyle = BorderStyle.FixedSingle;
            txtBookName.Location = new Point(277, 59);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(248, 27);
            txtBookName.TabIndex = 15;
            // 
            // txtStudentName
            // 
            txtStudentName.BorderStyle = BorderStyle.FixedSingle;
            txtStudentName.Location = new Point(277, 22);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(248, 27);
            txtStudentName.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(84, 59);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 13;
            label3.Text = "Book Name";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(231, 76, 60);
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(839, 74);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 47);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(52, 152, 219);
            btnPay.FlatStyle = FlatStyle.Popup;
            btnPay.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(711, 74);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(94, 47);
            btnPay.TabIndex = 10;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(275, 98);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(84, 98);
            label4.Name = "label4";
            label4.Size = new Size(119, 23);
            label4.TabIndex = 6;
            label4.Text = "Payment Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(84, 17);
            label5.Name = "label5";
            label5.Size = new Size(121, 23);
            label5.TabIndex = 4;
            label5.Text = "Student Name";
            label5.Click += label5_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(602, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(86, 88);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // LateFee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 128, 87);
            ClientSize = new Size(1359, 763);
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "LateFee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LateFee";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnExit;
        private Button btnRefresh;
        private Button btnSearchStudent;
        private TextBox txtEnterEnroll;
        private Label label2;
        private Panel panel3;
        private Button btnCancel;
        private Button btnPay;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label5;
        private Label label3;
        private TextBox txtBookName;
        private TextBox txtStudentName;
        private PictureBox pictureBox2;
    }
}
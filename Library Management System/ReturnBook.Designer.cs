namespace Library_Management_System
{
    partial class ReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            btnRefresh = new Button();
            btnSearchStudent = new Button();
            txtEnterEnroll = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            btnCancel = new Button();
            btnReturn = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtBookIssueDate = new TextBox();
            txtBookName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnSearchStudent);
            panel1.Controls.Add(txtEnterEnroll);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(6, 148);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 541);
            panel1.TabIndex = 0;
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
            txtEnterEnroll.TextChanged += txtEnterEnroll_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 154);
            label1.Name = "label1";
            label1.Size = new Size(218, 36);
            label1.TabIndex = 1;
            label1.Text = "Enter Enrollment No";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(277, 148);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1299, 368);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 255);
            panel2.Location = new Point(277, 386);
            panel2.Name = "panel2";
            panel2.Size = new Size(0, 0);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(btnCancel);
            panel3.Controls.Add(btnReturn);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(txtBookIssueDate);
            panel3.Controls.Add(txtBookName);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(277, 522);
            panel3.Name = "panel3";
            panel3.Size = new Size(1299, 167);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(26, 188, 156);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(727, 74);
            button1.Name = "button1";
            button1.Size = new Size(103, 47);
            button1.TabIndex = 8;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(231, 76, 60);
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(856, 74);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 47);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.FromArgb(52, 152, 219);
            btnReturn.FlatStyle = FlatStyle.Popup;
            btnReturn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.ForeColor = Color.White;
            btnReturn.Location = new Point(602, 74);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(94, 47);
            btnReturn.TabIndex = 10;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(281, 92);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // txtBookIssueDate
            // 
            txtBookIssueDate.BorderStyle = BorderStyle.FixedSingle;
            txtBookIssueDate.Location = new Point(281, 56);
            txtBookIssueDate.Name = "txtBookIssueDate";
            txtBookIssueDate.Size = new Size(250, 27);
            txtBookIssueDate.TabIndex = 8;
            // 
            // txtBookName
            // 
            txtBookName.BorderStyle = BorderStyle.FixedSingle;
            txtBookName.Location = new Point(281, 14);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(250, 27);
            txtBookName.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(84, 98);
            label4.Name = "label4";
            label4.Size = new Size(152, 23);
            label4.TabIndex = 6;
            label4.Text = "Book  Return Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(84, 59);
            label3.Name = "label3";
            label3.Size = new Size(133, 23);
            label3.TabIndex = 5;
            label3.Text = "Book Issue Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(84, 17);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 4;
            label2.Text = "Book Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(712, 64);
            label5.Name = "label5";
            label5.Size = new Size(172, 40);
            label5.TabIndex = 4;
            label5.Text = "Return Books";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(607, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(86, 88);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // ReturnBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.FromArgb(14, 128, 87);
            ClientSize = new Size(1581, 763);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "ReturnBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReturnBook";
            Load += ReturnBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private TextBox txtEnterEnroll;
        private Button btnSearchStudent;
        private Button btnExit;
        private Button btnRefresh;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtBookIssueDate;
        private TextBox txtBookName;
        private DateTimePicker dateTimePicker1;
        private Button btnCancel;
        private Button btnReturn;
        private PictureBox pictureBox1;
        private Label label5;
        private Button button1;
        private PictureBox pictureBox2;
    }
}
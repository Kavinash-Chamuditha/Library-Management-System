namespace Library_Management_System
{
    partial class ViewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBook));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            txtBookName = new TextBox();
            btnRefresh = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnCancel = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtPDate = new TextBox();
            txtPublication = new TextBox();
            txtAuthor = new TextBox();
            txtBName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 128, 87);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1282, 156);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(709, 61);
            label1.Name = "label1";
            label1.Size = new Size(184, 50);
            label1.TabIndex = 1;
            label1.Text = "View Books";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(361, 173);
            label2.Name = "label2";
            label2.Size = new Size(133, 36);
            label2.TabIndex = 1;
            label2.Text = "Book Name";
            // 
            // txtBookName
            // 
            txtBookName.BorderStyle = BorderStyle.FixedSingle;
            txtBookName.Location = new Point(496, 177);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(203, 27);
            txtBookName.TabIndex = 2;
            txtBookName.TextAlign = HorizontalAlignment.Center;
            txtBookName.TextChanged += txtBookName_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(26, 188, 156);
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(730, 166);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 49);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 221);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1282, 282);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(txtQuantity);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(txtPDate);
            panel2.Controls.Add(txtPublication);
            panel2.Controls.Add(txtAuthor);
            panel2.Controls.Add(txtBName);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(1, 524);
            panel2.Name = "panel2";
            panel2.Size = new Size(1282, 315);
            panel2.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(52, 152, 219);
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(1019, 245);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 43);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(897, 245);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 43);
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
            btnUpdate.Location = new Point(771, 245);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(98, 43);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtQuantity.Location = new Point(827, 171);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(277, 27);
            txtQuantity.TabIndex = 11;
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Location = new Point(827, 107);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(277, 27);
            txtPrice.TabIndex = 10;
            // 
            // txtPDate
            // 
            txtPDate.BorderStyle = BorderStyle.FixedSingle;
            txtPDate.Location = new Point(827, 47);
            txtPDate.Name = "txtPDate";
            txtPDate.Size = new Size(277, 27);
            txtPDate.TabIndex = 9;
            // 
            // txtPublication
            // 
            txtPublication.BorderStyle = BorderStyle.FixedSingle;
            txtPublication.Location = new Point(274, 171);
            txtPublication.Name = "txtPublication";
            txtPublication.Size = new Size(261, 27);
            txtPublication.TabIndex = 8;
            // 
            // txtAuthor
            // 
            txtAuthor.BorderStyle = BorderStyle.FixedSingle;
            txtAuthor.Location = new Point(274, 111);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(261, 27);
            txtAuthor.TabIndex = 7;
            // 
            // txtBName
            // 
            txtBName.BorderStyle = BorderStyle.FixedSingle;
            txtBName.Location = new Point(274, 47);
            txtBName.Name = "txtBName";
            txtBName.Size = new Size(261, 27);
            txtBName.TabIndex = 6;
            txtBName.TextChanged += txtBookName_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(592, 171);
            label8.Name = "label8";
            label8.Size = new Size(121, 23);
            label8.TabIndex = 5;
            label8.Text = "Book Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(592, 110);
            label7.Name = "label7";
            label7.Size = new Size(91, 23);
            label7.TabIndex = 4;
            label7.Text = "Book Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(592, 47);
            label6.Name = "label6";
            label6.Size = new Size(164, 23);
            label6.TabIndex = 3;
            label6.Text = "Book Purchase Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(89, 171);
            label5.Name = "label5";
            label5.Size = new Size(139, 23);
            label5.TabIndex = 2;
            label5.Text = "Book Publication";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(89, 110);
            label4.Name = "label4";
            label4.Size = new Size(158, 23);
            label4.TabIndex = 1;
            label4.Text = "Book Author Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(89, 54);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            label3.Text = "Book Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(551, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ViewBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(14, 128, 87);
            ClientSize = new Size(1282, 866);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(btnRefresh);
            Controls.Add(txtBookName);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "ViewBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewBook";
            Load += ViewBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtBookName;
        private Button btnRefresh;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtPDate;
        private TextBox txtPublication;
        private TextBox txtAuthor;
        private TextBox txtBName;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnUpdate;
        private PictureBox pictureBox1;
    }
}
namespace Library_Management_System
{
    partial class addBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addBook));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtBookName = new TextBox();
            txtAuthor = new TextBox();
            txtPublication = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            panel1 = new Panel();
            btnExit = new Button();
            btnCansel = new Button();
            btnSave = new Button();
            dateTimePicker1 = new DateTimePicker();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            textBox6 = new TextBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 36);
            label1.Name = "label1";
            label1.Size = new Size(119, 28);
            label1.TabIndex = 0;
            label1.Text = "Book Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 90);
            label2.Name = "label2";
            label2.Size = new Size(188, 28);
            label2.TabIndex = 1;
            label2.Text = "Book Author Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 138);
            label3.Name = "label3";
            label3.Size = new Size(166, 28);
            label3.TabIndex = 2;
            label3.Text = "Book Publication";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 197);
            label4.Name = "label4";
            label4.Size = new Size(177, 25);
            label4.TabIndex = 3;
            label4.Text = "Book Purchase Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 254);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 4;
            label5.Text = "Book Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(20, 302);
            label6.Name = "label6";
            label6.Size = new Size(132, 25);
            label6.TabIndex = 5;
            label6.Text = "Book Quantity";
            // 
            // txtBookName
            // 
            txtBookName.BorderStyle = BorderStyle.FixedSingle;
            txtBookName.Location = new Point(212, 36);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(237, 27);
            txtBookName.TabIndex = 6;
            txtBookName.TextChanged += textBox1_TextChanged;
            // 
            // txtAuthor
            // 
            txtAuthor.BorderStyle = BorderStyle.FixedSingle;
            txtAuthor.Location = new Point(212, 90);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(237, 27);
            txtAuthor.TabIndex = 7;
            // 
            // txtPublication
            // 
            txtPublication.BorderStyle = BorderStyle.FixedSingle;
            txtPublication.Location = new Point(212, 138);
            txtPublication.Name = "txtPublication";
            txtPublication.Size = new Size(237, 27);
            txtPublication.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Location = new Point(212, 252);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(237, 27);
            txtPrice.TabIndex = 9;
            // 
            // txtQuantity
            // 
            txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtQuantity.Location = new Point(212, 300);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(237, 27);
            txtQuantity.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnCansel);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtQuantity);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtPublication);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtAuthor);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtBookName);
            panel1.Location = new Point(357, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 417);
            panel1.TabIndex = 12;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(231, 76, 60);
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(382, 363);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 40);
            btnExit.TabIndex = 15;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnCansel
            // 
            btnCansel.BackColor = Color.FromArgb(52, 152, 219);
            btnCansel.FlatStyle = FlatStyle.Popup;
            btnCansel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCansel.ForeColor = Color.White;
            btnCansel.Location = new Point(275, 362);
            btnCansel.Name = "btnCansel";
            btnCansel.Size = new Size(97, 41);
            btnCansel.TabIndex = 14;
            btnCansel.Text = "Cancel";
            btnCansel.UseVisualStyleBackColor = false;
            btnCansel.Click += btnCansel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(26, 188, 156);
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(171, 362);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 41);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(212, 197);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(237, 27);
            dateTimePicker1.TabIndex = 12;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(32, 119);
            panel2.Name = "panel2";
            panel2.Size = new Size(328, 417);
            panel2.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(328, 416);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(14, 128, 87);
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox6.ForeColor = Color.White;
            textBox6.Location = new Point(459, 41);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(141, 41);
            textBox6.TabIndex = 15;
            textBox6.Text = "Add Book";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(357, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(86, 88);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // addBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(14, 128, 87);
            ClientSize = new Size(878, 613);
            Controls.Add(pictureBox2);
            Controls.Add(textBox6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "addBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addBook";
            Load += addBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtBookName;
        private TextBox txtAuthor;
        private TextBox txtPublication;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnCansel;
        private Button btnSave;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox6;
        private Button btnExit;
        private PictureBox pictureBox2;
    }
}
namespace Database_Project
{
    partial class AddExpense
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddExpense));
            panel1 = new Panel();
            button4 = new Button();
            imageList2 = new ImageList(components);
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            imageList1 = new ImageList(components);
            panel3 = new Panel();
            Fetch = new Button();
            Edit = new Button();
            expense_type = new TextBox();
            Delete = new Button();
            label5 = new Label();
            Add = new Button();
            Enter_amount = new TextBox();
            label4 = new Label();
            label9 = new Label();
            label7 = new Label();
            Enter_name = new TextBox();
            Enter_phone_no = new TextBox();
            Sr_no = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label12 = new Label();
            button5 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 749);
            panel1.TabIndex = 2;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.ImageIndex = 0;
            button4.ImageList = imageList2;
            button4.Location = new Point(12, 267);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(248, 56);
            button4.TabIndex = 5;
            button4.Text = "Dashboard";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "dashboard.png");
            imageList2.Images.SetKeyName(1, "fee datails icon.jpg");
            imageList2.Images.SetKeyName(2, "expense details icon.png");
            imageList2.Images.SetKeyName(3, "add expense icon.png");
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.ImageIndex = 3;
            button3.ImageList = imageList2;
            button3.Location = new Point(12, 476);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(248, 56);
            button3.TabIndex = 4;
            button3.Text = "Add Expense";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.ImageIndex = 2;
            button2.ImageList = imageList2;
            button2.Location = new Point(12, 398);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(248, 56);
            button2.TabIndex = 2;
            button2.Text = "Expense Details";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageIndex = 1;
            button1.ImageList = imageList2;
            button1.Location = new Point(12, 327);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(248, 56);
            button1.TabIndex = 1;
            button1.Text = "Fee Details";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pic;
            pictureBox1.Location = new Point(27, 56);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "dropdown logo.png");
            imageList1.Images.SetKeyName(1, "logout.png");
            imageList1.Images.SetKeyName(2, "settings log.png");
            imageList1.Images.SetKeyName(3, "message logo.png");
            imageList1.Images.SetKeyName(4, "my profile.png");
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(Fetch);
            panel3.Controls.Add(Edit);
            panel3.Controls.Add(expense_type);
            panel3.Controls.Add(Delete);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(Add);
            panel3.Controls.Add(Enter_amount);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(Enter_name);
            panel3.Controls.Add(Enter_phone_no);
            panel3.Controls.Add(Sr_no);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(307, 172);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(955, 342);
            panel3.TabIndex = 12;
            panel3.Paint += panel3_Paint;
            // 
            // Fetch
            // 
            Fetch.BackColor = Color.FromArgb(255, 224, 192);
            Fetch.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Fetch.Location = new Point(565, 272);
            Fetch.Margin = new Padding(3, 2, 3, 2);
            Fetch.Name = "Fetch";
            Fetch.Size = new Size(150, 37);
            Fetch.TabIndex = 79;
            Fetch.Text = "Fetch";
            Fetch.UseVisualStyleBackColor = false;
            Fetch.Click += Fetch_Click;
            // 
            // Edit
            // 
            Edit.BackColor = Color.LightCoral;
            Edit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Edit.Location = new Point(97, 272);
            Edit.Margin = new Padding(3, 2, 3, 2);
            Edit.Name = "Edit";
            Edit.Size = new Size(150, 37);
            Edit.TabIndex = 80;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = false;
            Edit.Click += Edit_Click;
            // 
            // expense_type
            // 
            expense_type.Location = new Point(585, 216);
            expense_type.Margin = new Padding(3, 2, 3, 2);
            expense_type.Multiline = true;
            expense_type.Name = "expense_type";
            expense_type.Size = new Size(206, 35);
            expense_type.TabIndex = 75;
            expense_type.KeyPress += textBox2_KeyPress;
            // 
            // Delete
            // 
            Delete.BackColor = Color.FromArgb(192, 255, 192);
            Delete.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete.Location = new Point(253, 272);
            Delete.Margin = new Padding(3, 2, 3, 2);
            Delete.Name = "Delete";
            Delete.Size = new Size(150, 37);
            Delete.TabIndex = 81;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label5.Location = new Point(585, 178);
            label5.Name = "label5";
            label5.Size = new Size(164, 30);
            label5.TabIndex = 74;
            label5.Text = "ExpenseType *";
            // 
            // Add
            // 
            Add.BackColor = Color.FromArgb(192, 255, 255);
            Add.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add.Location = new Point(409, 272);
            Add.Margin = new Padding(3, 2, 3, 2);
            Add.Name = "Add";
            Add.Size = new Size(150, 37);
            Add.TabIndex = 78;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // Enter_amount
            // 
            Enter_amount.Location = new Point(585, 103);
            Enter_amount.Margin = new Padding(3, 2, 3, 2);
            Enter_amount.Multiline = true;
            Enter_amount.Name = "Enter_amount";
            Enter_amount.Size = new Size(206, 35);
            Enter_amount.TabIndex = 73;
            Enter_amount.KeyPress += textBox1_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(596, 60);
            label4.Name = "label4";
            label4.Size = new Size(112, 30);
            label4.TabIndex = 72;
            label4.Text = "Amount *";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label9.Location = new Point(25, 166);
            label9.Name = "label9";
            label9.Size = new Size(94, 30);
            label9.TabIndex = 22;
            label9.Text = "Phone *";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label7.Location = new Point(293, 166);
            label7.Name = "label7";
            label7.Size = new Size(78, 30);
            label7.TabIndex = 20;
            label7.Text = "Date *";
            // 
            // Enter_name
            // 
            Enter_name.Location = new Point(301, 93);
            Enter_name.Margin = new Padding(3, 2, 3, 2);
            Enter_name.Multiline = true;
            Enter_name.Name = "Enter_name";
            Enter_name.Size = new Size(206, 35);
            Enter_name.TabIndex = 19;
            Enter_name.KeyPress += textBox5_KeyPress;
            // 
            // Enter_phone_no
            // 
            Enter_phone_no.Location = new Point(25, 216);
            Enter_phone_no.Margin = new Padding(3, 2, 3, 2);
            Enter_phone_no.Multiline = true;
            Enter_phone_no.Name = "Enter_phone_no";
            Enter_phone_no.Size = new Size(206, 35);
            Enter_phone_no.TabIndex = 18;
            Enter_phone_no.KeyPress += textBox3_KeyPress;
            // 
            // Sr_no
            // 
            Sr_no.Location = new Point(25, 91);
            Sr_no.Margin = new Padding(3, 2, 3, 2);
            Sr_no.Multiline = true;
            Sr_no.Name = "Sr_no";
            Sr_no.Size = new Size(206, 35);
            Sr_no.TabIndex = 12;
            Sr_no.TextChanged += textBox4_TextChanged;
            Sr_no.KeyPress += textBox4_KeyPress;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(293, 216);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(214, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 60);
            label3.Name = "label3";
            label3.Size = new Size(86, 30);
            label3.TabIndex = 3;
            label3.Text = "Sr No *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.Location = new Point(301, 60);
            label2.Name = "label2";
            label2.Size = new Size(90, 30);
            label2.TabIndex = 2;
            label2.Text = "Name *";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(25, 13);
            label1.Name = "label1";
            label1.Size = new Size(246, 37);
            label1.TabIndex = 1;
            label1.Text = "Add New Expense";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cambria", 24F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(493, 7);
            label12.Name = "label12";
            label12.Size = new Size(412, 37);
            label12.TabIndex = 14;
            label12.Text = "Al Hamd Knowledge House";
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.ImageIndex = 1;
            button5.ImageList = imageList1;
            button5.Location = new Point(971, 0);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(113, 52);
            button5.TabIndex = 13;
            button5.Text = "Logout";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label12);
            panel2.Controls.Add(button5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(286, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1084, 52);
            panel2.TabIndex = 15;
            // 
            // AddExpense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddExpense";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddExpense";
            WindowState = FormWindowState.Maximized;
            Load += AddExpense_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private ImageList imageList1;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private TextBox Sr_no;
        private Label label12;
        private Button button5;
        private Panel panel2;
        private Button button4;
        private ImageList imageList2;
        private Label label9;
        private Label label7;
        private TextBox Enter_name;
        private TextBox Enter_phone_no;
        private TextBox Enter_amount;
        private Label label4;
        private TextBox expense_type;
        private Label label5;
        private Button Fetch;
        private Button Edit;
        private Button Delete;
        private Button Add;
    }
}
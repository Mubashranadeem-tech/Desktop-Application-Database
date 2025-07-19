namespace Database_Project
{
    partial class TeacherDetailsP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherDetailsP));
            imageList1 = new ImageList(components);
            panel4 = new Panel();
            Search = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            logout = new Button();
            label12 = new Label();
            imageList3 = new ImageList(components);
            panel1 = new Panel();
            button4 = new Button();
            button8 = new Button();
            button7 = new Button();
            button5 = new Button();
            button6 = new Button();
            button9 = new Button();
            pictureBox2 = new PictureBox();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "logout icon.png");
            // 
            // panel4
            // 
            panel4.Controls.Add(Search);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(textBox5);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(dataGridView1);
            panel4.Location = new Point(400, 107);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1208, 602);
            panel4.TabIndex = 66;
            // 
            // Search
            // 
            Search.BackColor = Color.Turquoise;
            Search.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Search.Location = new Point(570, 64);
            Search.Margin = new Padding(3, 2, 3, 2);
            Search.Name = "Search";
            Search.Size = new Size(149, 36);
            Search.TabIndex = 41;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = false;
            Search.Click += Search_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14F);
            textBox2.Location = new Point(386, 68);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Search by Class";
            textBox2.Size = new Size(154, 32);
            textBox2.TabIndex = 4;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(28, 68);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search by Name";
            textBox1.Size = new Size(168, 32);
            textBox1.TabIndex = 3;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 14F);
            textBox5.Location = new Point(202, 68);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Search by ID";
            textBox5.Size = new Size(165, 32);
            textBox5.TabIndex = 2;
            textBox5.TextChanged += textBox5_TextChanged;
            textBox5.KeyPress += textBox5_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 3);
            label1.Name = "label1";
            label1.Size = new Size(277, 45);
            label1.TabIndex = 0;
            label1.Text = "All Teachers Data";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Cursor = Cursors.IBeam;
            dataGridView1.Location = new Point(12, 104);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(744, 458);
            dataGridView1.TabIndex = 42;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(logout);
            panel2.Controls.Add(label12);
            panel2.Location = new Point(310, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1374, 52);
            panel2.TabIndex = 69;
            // 
            // logout
            // 
            logout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout.ImageAlign = ContentAlignment.MiddleLeft;
            logout.ImageIndex = 0;
            logout.ImageList = imageList1;
            logout.Location = new Point(1236, 0);
            logout.Margin = new Padding(3, 2, 3, 2);
            logout.Name = "logout";
            logout.Size = new Size(137, 52);
            logout.TabIndex = 70;
            logout.Text = "Logout";
            logout.TextAlign = ContentAlignment.MiddleRight;
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cambria", 24F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(397, 9);
            label12.Name = "label12";
            label12.Size = new Size(412, 37);
            label12.TabIndex = 70;
            label12.Text = "Al Hamd Knowledge House";
            // 
            // imageList3
            // 
            imageList3.ColorDepth = ColorDepth.Depth32Bit;
            imageList3.ImageStream = (ImageListStreamer)resources.GetObject("imageList3.ImageStream");
            imageList3.TransparentColor = Color.Transparent;
            imageList3.Images.SetKeyName(0, "exam.png");
            imageList3.Images.SetKeyName(1, "Dashboard-icon.png");
            imageList3.Images.SetKeyName(2, "student icon 1.png");
            imageList3.Images.SetKeyName(3, "teacher logo.png");
            imageList3.Images.SetKeyName(4, "expense details icon.png");
            imageList3.Images.SetKeyName(5, "attendance icon.jpg");
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 749);
            panel1.TabIndex = 101;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.ImageIndex = 4;
            button4.ImageList = imageList3;
            button4.Location = new Point(41, 422);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(248, 56);
            button4.TabIndex = 92;
            button4.Text = "Expense Details";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.ImageIndex = 3;
            button8.ImageList = imageList3;
            button8.Location = new Point(41, 644);
            button8.Margin = new Padding(3, 2, 3, 2);
            button8.Name = "button8";
            button8.Size = new Size(248, 56);
            button8.TabIndex = 6;
            button8.Text = "   Teacher Details";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.ImageIndex = 0;
            button7.ImageList = imageList3;
            button7.Location = new Point(41, 571);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(248, 56);
            button7.TabIndex = 5;
            button7.Text = "   Exam Result";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.ImageIndex = 1;
            button5.ImageList = imageList3;
            button5.Location = new Point(41, 268);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(248, 56);
            button5.TabIndex = 4;
            button5.Text = "  Dashboard";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.ImageIndex = 5;
            button6.ImageList = imageList3;
            button6.Location = new Point(41, 495);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(248, 56);
            button6.TabIndex = 3;
            button6.Text = "   Attendance";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click_1;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.ImageIndex = 2;
            button9.ImageList = imageList3;
            button9.Location = new Point(41, 344);
            button9.Margin = new Padding(3, 2, 3, 2);
            button9.Name = "button9";
            button9.Size = new Size(248, 56);
            button9.TabIndex = 1;
            button9.Text = "     Student Details";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Profile_icon;
            pictureBox2.Location = new Point(55, 52);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(215, 181);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // TeacherDetailsP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TeacherDetailsP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeacherDetailsP";
            WindowState = FormWindowState.Maximized;
            Load += TeacherDetailsP_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private Panel panel4;
        private Button Search;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox5;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label12;
        private Button logout;
        private ImageList imageList3;
        private Panel panel1;
        private Button button4;
        private Button button8;
        private Button button7;
        private Button button5;
        private Button button6;
        private Button button9;
        private PictureBox pictureBox2;
    }
}
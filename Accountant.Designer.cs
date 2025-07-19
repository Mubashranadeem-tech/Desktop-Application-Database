namespace Database_Project
{
    partial class Accountant
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accountant));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            button5 = new Button();
            imageList2 = new ImageList(components);
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            imageList1 = new ImageList(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            panel2 = new Panel();
            label12 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox7 = new PictureBox();
            StudentsCount = new Label();
            TeachersCount = new Label();
            Earnings1 = new Label();
            Earnings = new Label();
            pictureBox3 = new PictureBox();
            panelFemale = new Panel();
            lblFemaleStudents = new Label();
            lblFemaleCount = new Label();
            colorFemale = new Panel();
            chartPanel = new Panel();
            lblTitle = new Label();
            panelMale = new Panel();
            lblMaleStudents = new Label();
            lblMaleCount = new Label();
            colorMale = new Panel();
            chartExpenses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lblTotalCollections = new Label();
            lblTotalAmount = new Label();
            lblFeeCollection = new Label();
            lblExpenseAmount = new Label();
            timerRefresh = new System.Windows.Forms.Timer(components);
            panel5 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelFemale.SuspendLayout();
            panelMale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartExpenses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 749);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.ImageIndex = 0;
            button5.ImageList = imageList2;
            button5.Location = new Point(26, 267);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(215, 56);
            button5.TabIndex = 4;
            button5.Text = "Dashboard";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "dashboard.png");
            imageList2.Images.SetKeyName(1, "fee datails icon.jpg");
            imageList2.Images.SetKeyName(2, "add expense icon.png");
            imageList2.Images.SetKeyName(3, "expense details icon.png");
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.ImageIndex = 3;
            button2.ImageList = imageList2;
            button2.Location = new Point(26, 408);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(215, 56);
            button2.TabIndex = 2;
            button2.Text = "Expense Details";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.ImageIndex = 2;
            button3.ImageList = imageList2;
            button3.Location = new Point(26, 479);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(215, 56);
            button3.TabIndex = 3;
            button3.Text = "Add Expense";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageIndex = 1;
            button1.ImageList = imageList2;
            button1.Location = new Point(26, 338);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(215, 56);
            button1.TabIndex = 1;
            button1.Text = "Fee Details";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pic;
            pictureBox1.Location = new Point(26, 41);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.ImageIndex = 1;
            button4.ImageList = imageList1;
            button4.Location = new Point(993, 0);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(113, 52);
            button4.TabIndex = 4;
            button4.Text = "Logout";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
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
            imageList1.Images.SetKeyName(5, "dropup menu logo.png");
            // 
            // panel2
            // 
            panel2.Controls.Add(label12);
            panel2.Controls.Add(button4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(264, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1106, 52);
            panel2.TabIndex = 5;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cambria", 24F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(528, 7);
            label12.Name = "label12";
            label12.Size = new Size(412, 37);
            label12.TabIndex = 5;
            label12.Text = "Al Hamd Knowledge House";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.accountant_student_icon;
            pictureBox2.Location = new Point(270, 64);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(239, 112);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(515, 64);
            pictureBox7.Margin = new Padding(3, 2, 3, 2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(235, 112);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 11;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // StudentsCount
            // 
            StudentsCount.AutoSize = true;
            StudentsCount.BackColor = Color.White;
            StudentsCount.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StudentsCount.Location = new Point(424, 114);
            StudentsCount.Name = "StudentsCount";
            StudentsCount.Size = new Size(71, 45);
            StudentsCount.TabIndex = 15;
            StudentsCount.Text = "180";
            StudentsCount.Click += StudentsCount_Click;
            // 
            // TeachersCount
            // 
            TeachersCount.AutoSize = true;
            TeachersCount.BackColor = Color.White;
            TeachersCount.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeachersCount.Location = new Point(682, 114);
            TeachersCount.Name = "TeachersCount";
            TeachersCount.Size = new Size(54, 45);
            TeachersCount.TabIndex = 16;
            TeachersCount.Text = "11";
            TeachersCount.Click += TeachersCount_Click;
            // 
            // Earnings1
            // 
            Earnings1.AutoSize = true;
            Earnings1.BackColor = Color.White;
            Earnings1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Earnings1.ForeColor = SystemColors.AppWorkspace;
            Earnings1.Location = new Point(1446, 128);
            Earnings1.Name = "Earnings1";
            Earnings1.Size = new Size(122, 21);
            Earnings1.TabIndex = 119;
            Earnings1.Text = "             Earnings";
            // 
            // Earnings
            // 
            Earnings.AutoSize = true;
            Earnings.BackColor = Color.White;
            Earnings.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Earnings.Location = new Point(1434, 158);
            Earnings.Name = "Earnings";
            Earnings.Size = new Size(112, 30);
            Earnings.TabIndex = 118;
            Earnings.Text = "Rs.173000";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.expenses;
            pictureBox3.Location = new Point(756, 66);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(193, 110);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 117;
            pictureBox3.TabStop = false;
            // 
            // panelFemale
            // 
            panelFemale.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panelFemale.Controls.Add(lblFemaleStudents);
            panelFemale.Controls.Add(lblFemaleCount);
            panelFemale.Controls.Add(colorFemale);
            panelFemale.Location = new Point(1344, 851);
            panelFemale.Margin = new Padding(4);
            panelFemale.Name = "panelFemale";
            panelFemale.Size = new Size(156, 69);
            panelFemale.TabIndex = 122;
            // 
            // lblFemaleStudents
            // 
            lblFemaleStudents.AutoSize = true;
            lblFemaleStudents.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFemaleStudents.ForeColor = Color.Gray;
            lblFemaleStudents.Location = new Point(38, 11);
            lblFemaleStudents.Margin = new Padding(4, 0, 4, 0);
            lblFemaleStudents.Name = "lblFemaleStudents";
            lblFemaleStudents.Size = new Size(94, 15);
            lblFemaleStudents.TabIndex = 2;
            lblFemaleStudents.Text = "Female Students";
            // 
            // lblFemaleCount
            // 
            lblFemaleCount.AutoSize = true;
            lblFemaleCount.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFemaleCount.Location = new Point(70, 28);
            lblFemaleCount.Margin = new Padding(4, 0, 4, 0);
            lblFemaleCount.Name = "lblFemaleCount";
            lblFemaleCount.Size = new Size(37, 30);
            lblFemaleCount.TabIndex = 1;
            lblFemaleCount.Text = "90";
            lblFemaleCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // colorFemale
            // 
            colorFemale.BackColor = Color.FromArgb(43, 91, 226);
            colorFemale.Location = new Point(10, 11);
            colorFemale.Margin = new Padding(4);
            colorFemale.Name = "colorFemale";
            colorFemale.Size = new Size(21, 21);
            colorFemale.TabIndex = 0;
            // 
            // chartPanel
            // 
            chartPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartPanel.Location = new Point(1102, 277);
            chartPanel.Margin = new Padding(4);
            chartPanel.Name = "chartPanel";
            chartPanel.Size = new Size(236, 379);
            chartPanel.TabIndex = 121;
            chartPanel.Paint += chartPanel_Paint;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(1102, 248);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(91, 25);
            lblTitle.TabIndex = 120;
            lblTitle.Text = "Students";
            // 
            // panelMale
            // 
            panelMale.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panelMale.Controls.Add(lblMaleStudents);
            panelMale.Controls.Add(lblMaleCount);
            panelMale.Controls.Add(colorMale);
            panelMale.Location = new Point(1694, 851);
            panelMale.Margin = new Padding(4);
            panelMale.Name = "panelMale";
            panelMale.Size = new Size(150, 69);
            panelMale.TabIndex = 123;
            // 
            // lblMaleStudents
            // 
            lblMaleStudents.AutoSize = true;
            lblMaleStudents.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaleStudents.ForeColor = Color.Gray;
            lblMaleStudents.Location = new Point(38, 11);
            lblMaleStudents.Margin = new Padding(4, 0, 4, 0);
            lblMaleStudents.Name = "lblMaleStudents";
            lblMaleStudents.Size = new Size(82, 15);
            lblMaleStudents.TabIndex = 2;
            lblMaleStudents.Text = "Male Students";
            // 
            // lblMaleCount
            // 
            lblMaleCount.AutoSize = true;
            lblMaleCount.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaleCount.Location = new Point(70, 28);
            lblMaleCount.Margin = new Padding(4, 0, 4, 0);
            lblMaleCount.Name = "lblMaleCount";
            lblMaleCount.Size = new Size(49, 30);
            lblMaleCount.TabIndex = 1;
            lblMaleCount.Text = "110";
            lblMaleCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // colorMale
            // 
            colorMale.BackColor = Color.FromArgb(255, 168, 0);
            colorMale.Location = new Point(10, 11);
            colorMale.Margin = new Padding(4);
            colorMale.Name = "colorMale";
            colorMale.Size = new Size(21, 21);
            colorMale.TabIndex = 0;
            // 
            // chartExpenses
            // 
            chartArea1.AxisX.Title = "Expense Type";
            chartArea1.AxisY.Title = "Total Amount";
            chartArea1.Name = "ChartArea1";
            chartExpenses.ChartAreas.Add(chartArea1);
            chartExpenses.Location = new Point(855, 279);
            chartExpenses.Margin = new Padding(3, 2, 3, 2);
            chartExpenses.Name = "chartExpenses";
            chartExpenses.Size = new Size(240, 344);
            chartExpenses.TabIndex = 128;
            chartExpenses.Text = "Expense Chart";
            chartExpenses.Click += chartExpenses_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(901, 252);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 129;
            label1.Text = "Expenses";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(901, 604);
            label2.Name = "label2";
            label2.Size = new Size(35, 19);
            label2.TabIndex = 130;
            label2.Text = "Paid";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(958, 595);
            label3.Name = "label3";
            label3.Size = new Size(53, 19);
            label3.TabIndex = 131;
            label3.Text = "UnPaid";
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumSeaGreen;
            panel3.Location = new Point(928, 604);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(23, 10);
            panel3.TabIndex = 132;
            // 
            // panel4
            // 
            panel4.BackColor = Color.IndianRed;
            panel4.Location = new Point(1018, 604);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(20, 10);
            panel4.TabIndex = 133;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(270, 279);
            chart1.Margin = new Padding(4);
            chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "Fee Collection";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Expenses";
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Size = new Size(578, 377);
            chart1.TabIndex = 134;
            chart1.Text = "chart1";
            // 
            // lblTotalCollections
            // 
            lblTotalCollections.AutoSize = true;
            lblTotalCollections.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalCollections.ForeColor = Color.Gray;
            lblTotalCollections.Location = new Point(18, 16);
            lblTotalCollections.Margin = new Padding(4, 0, 4, 0);
            lblTotalCollections.Name = "lblTotalCollections";
            lblTotalCollections.Size = new Size(110, 20);
            lblTotalCollections.TabIndex = 1;
            lblTotalCollections.Text = "Fee Collection";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.ForeColor = Color.Blue;
            lblTotalAmount.Location = new Point(18, 36);
            lblTotalAmount.Margin = new Padding(4, 0, 4, 0);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(148, 31);
            lblTotalAmount.TabIndex = 3;
            lblTotalAmount.Text = "Rs.75,000";
            // 
            // lblFeeCollection
            // 
            lblFeeCollection.AutoSize = true;
            lblFeeCollection.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFeeCollection.ForeColor = Color.Gray;
            lblFeeCollection.Location = new Point(244, 16);
            lblFeeCollection.Margin = new Padding(4, 0, 4, 0);
            lblFeeCollection.Name = "lblFeeCollection";
            lblFeeCollection.Size = new Size(118, 20);
            lblFeeCollection.TabIndex = 2;
            lblFeeCollection.Text = "Total Expenses";
            // 
            // lblExpenseAmount
            // 
            lblExpenseAmount.AutoSize = true;
            lblExpenseAmount.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpenseAmount.ForeColor = Color.Red;
            lblExpenseAmount.Location = new Point(243, 36);
            lblExpenseAmount.Margin = new Padding(4, 0, 4, 0);
            lblExpenseAmount.Name = "lblExpenseAmount";
            lblExpenseAmount.Size = new Size(148, 31);
            lblExpenseAmount.TabIndex = 4;
            lblExpenseAmount.Text = "Rs.15,000";
            // 
            // timerRefresh
            // 
            timerRefresh.Interval = 30000;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(dateTimePicker1);
            panel5.Controls.Add(lblTotalCollections);
            panel5.Controls.Add(lblTotalAmount);
            panel5.Controls.Add(lblFeeCollection);
            panel5.Controls.Add(lblExpenseAmount);
            panel5.Location = new Point(270, 182);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(640, 75);
            panel5.TabIndex = 135;
            panel5.Paint += panel5_Paint;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(399, 28);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(232, 23);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Accountant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(chartExpenses);
            Controls.Add(chart1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panelFemale);
            Controls.Add(chartPanel);
            Controls.Add(lblTitle);
            Controls.Add(panelMale);
            Controls.Add(Earnings1);
            Controls.Add(Earnings);
            Controls.Add(pictureBox3);
            Controls.Add(TeachersCount);
            Controls.Add(StudentsCount);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Accountant";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Accountant_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelFemale.ResumeLayout(false);
            panelFemale.PerformLayout();
            panelMale.ResumeLayout(false);
            panelMale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartExpenses).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ImageList imageList1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Panel panel2;
        private Label label12;
        private Button button5;
        private ImageList imageList2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox7;
        private Label StudentsCount;
        private Label TeachersCount;
        private Label Earnings1;
        private Label Earnings;
        private PictureBox pictureBox3;
        private Panel panelFemale;
        private Label lblFemaleStudents;
        private Label lblFemaleCount;
        private Panel colorFemale;
        private Panel chartPanel;
        private Label lblTitle;
        private Panel panelMale;
        private Label lblMaleStudents;
        private Label lblMaleCount;
        private Panel colorMale;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartExpenses;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel3;
        private Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label lblTotalCollections;
        private Label lblTotalAmount;
        private Label lblFeeCollection;
        private Label lblExpenseAmount;
        private System.Windows.Forms.Timer timerRefresh;
        private Panel panel5;
        private DateTimePicker dateTimePicker1;
    }
}




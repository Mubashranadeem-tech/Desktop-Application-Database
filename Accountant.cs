using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;
//using Mysqlx.Notice;

namespace Database_Project
{
    public partial class Accountant : Form
    {
        private int maleCount = 0;
        private int femaleCount = 0;
        private string connectionString = "Server=localhost;Database=school_management_system_try10;Uid=root;Pwd=Mubashra;";

        private AccountantDBConnection dbConnect;
        private bool isCollapsed;


        // line chart k liye 
        private Dictionary<DateTime, decimal> feeData = new Dictionary<DateTime, decimal>();
        private Dictionary<DateTime, decimal> expenseData = new Dictionary<DateTime, decimal>();
        public Accountant()
        {
            InitializeComponent();
            dbConnect = new AccountantDBConnection();
            LoadStudentData();
            LoadExpenseChart();

        }
        private void LoadExpenseChart()
        {
            decimal paid = 0;
            decimal unpaid = 0;

            // fetch totals from DB
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                const string query = "SELECT status, SUM(amount) as total FROM expenses GROUP BY status";
                try
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var status = reader.GetString("status");
                            var total = reader.GetDecimal("total");
                            if (status == "Paid")
                                paid = total;
                            else if (status == "Unpaid")
                                unpaid = total;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading expenses: " + ex.Message);
                    return;
                }
            }

            // clear any existing series
            chartExpenses.Series.Clear();
            chartExpenses.ChartAreas.Clear();

            // Create chart area
            ChartArea chartArea = new ChartArea();
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartExpenses.ChartAreas.Add(chartArea);

            // Shared X value (e.g., "Expenses")
            string xValue = "Expense";

            // Series #1 — Paid
            var paidSeries = new Series("Paid")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };
            paidSeries.Points.AddXY(xValue, paid);
            paidSeries.Color = Color.MediumSeaGreen;
            chartExpenses.Series.Add(paidSeries);

            // Series #2 — Unpaid
            var unpaidSeries = new Series("Unpaid")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };
            unpaidSeries.Points.AddXY(xValue, unpaid);
            unpaidSeries.Color = Color.IndianRed;
            chartExpenses.Series.Add(unpaidSeries);

            // Make bars thicker by increasing PointWidth
            foreach (var series in chartExpenses.Series)
            {
                series["PointWidth"] = "1.0"; // Increase to make the bars thicker
            }


        }



        public void LoadStudentData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Count male students
                    string maleSql = "SELECT COUNT(*) FROM students WHERE gender = 'Male'";
                    using (MySqlCommand maleCmd = new MySqlCommand(maleSql, connection))
                    {
                        maleCount = Convert.ToInt32(maleCmd.ExecuteScalar());
                        lblMaleCount.Text = maleCount.ToString();
                    }

                    // Count female students
                    string femaleSql = "SELECT COUNT(*) FROM students WHERE gender = 'Female'";
                    using (MySqlCommand femaleCmd = new MySqlCommand(femaleSql, connection))
                    {
                        femaleCount = Convert.ToInt32(femaleCmd.ExecuteScalar());
                        lblFemaleCount.Text = femaleCount.ToString();
                    }
                }

                // Force the chart to redraw with new data
                chartPanel.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student data: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            AddExpense F4 = new AddExpense();
            F4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Expenses F2 = new Expenses();
            F2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FeeCollection F3 = new FeeCollection();
            F3.Show();
            this.Hide();
        }



        private void Accountant_Load(object sender, EventArgs e)
        {
            UpdateDashboardCounts();

            InitializeChart();
            LoadData();
            UpdateChart();

            // Start auto-refresh timer (every 30 seconds)
            timerRefresh.Start();

            // Set date picker to current date
            dateTimePicker1.Value = DateTime.Now;
        }
        private void UpdateDashboardCounts()
        {
            try
            {

                // Get and display total earnings (from fee collection)
                decimal totalEarnings = dbConnect.GetDecimal("SELECT SUM(fee_amount) FROM fee_collection WHERE payment_status = 'Paid'");
                Earnings.Text = $"Rs.{totalEarnings:N0}";

                // Get and display total student count
                int studentCount = dbConnect.GetCount("SELECT COUNT(*) FROM students");
                StudentsCount.Text = studentCount.ToString();

                // Get and display total teacher count
                int teacherCount = dbConnect.GetCount("SELECT COUNT(*) FROM teachers");
                TeachersCount.Text = teacherCount.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating dashboard: {ex.Message}");
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            MainDashboard F3 = new MainDashboard();
            F3.Show();
            this.Hide();
        }



        private void button5_Click(object sender, EventArgs e)
        {
            Accountant F3 = new Accountant();
            F3.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void chartPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawDonutChart(e.Graphics);
        }
        private void DrawDonutChart(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Get panel dimensions
            int width = chartPanel.Width;
            int height = chartPanel.Height;

            // Calculate chart radius and center
            int radius = Math.Min(width, height) / 2 - 10;
            int centerX = width / 2;
            int centerY = height / 2;

            // Calculate total students
            int totalStudents = maleCount + femaleCount;

            if (totalStudents == 0)
            {
                // Draw empty circle if there are no students
                using (Pen pen = new Pen(Color.Gray, 20))
                {
                    g.DrawEllipse(pen, centerX - radius, centerY - radius, radius * 2, radius * 2);
                }
                return;
            }

            // Define colors
            Color maleColor = Color.FromArgb(255, 168, 0);    // Orange
            Color femaleColor = Color.FromArgb(43, 91, 226);  // Blue

            // Calculate angles
            float femaleAngle = (float)femaleCount / totalStudents * 360;
            float maleAngle = (float)maleCount / totalStudents * 360;

            // Draw female segment
            if (femaleCount > 0)
            {
                using (SolidBrush brush = new SolidBrush(femaleColor))
                {
                    g.FillPie(brush, centerX - radius, centerY - radius, radius * 2, radius * 2, 0, femaleAngle);
                }
            }

            // Draw male segment
            if (maleCount > 0)
            {
                using (SolidBrush brush = new SolidBrush(maleColor))
                {
                    g.FillPie(brush, centerX - radius, centerY - radius, radius * 2, radius * 2, femaleAngle, maleAngle);
                }
            }

            // Draw inner white circle (to create donut effect)
            int innerRadius = radius - 20;
            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                g.FillEllipse(brush, centerX - innerRadius, centerY - innerRadius, innerRadius * 2, innerRadius * 2);
            }
        }


        private void InitializeChart()
        {
            // Configure chart appearance
            chart1.BackColor = Color.WhiteSmoke;
            chart1.ChartAreas[0].BackColor = Color.White;
            chart1.ChartAreas[0].BorderColor = Color.LightGray;
            chart1.ChartAreas[0].BorderWidth = 1;

            // Configure axes
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            // Hide X-axis labels and marks
            chart1.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            chart1.ChartAreas[0].AxisX.MajorTickMark.Enabled = false;
            chart1.ChartAreas[0].AxisX.MinorTickMark.Enabled = false;
            chart1.ChartAreas[0].AxisX.LineColor = Color.Transparent;

            // Configure series for horizontal lines
            chart1.Series["Fee Collection"].Color = Color.Blue;
            chart1.Series["Fee Collection"].BorderWidth = 4;
            chart1.Series["Fee Collection"].ChartType = SeriesChartType.Line;

            chart1.Series["Expenses"].Color = Color.Red;
            chart1.Series["Expenses"].BorderWidth = 4;
            chart1.Series["Expenses"].ChartType = SeriesChartType.Line;

            // Configure legend
            chart1.Legends[0].BackColor = Color.Transparent;
            chart1.Legends[0].Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
        }


        private void LoadData()
        {
            try
            {
                feeData.Clear();
                expenseData.Clear();

                // Get the selected date (date only, without time)
                DateTime selectedDate = dateTimePicker1.Value.Date;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Load fee collection data for the specific selected date
                    string feeQuery = @"
                        SELECT SUM(fee_amount) as total_amount 
                        FROM fee_collection 
                        WHERE payment_status = 'Paid' 
                        AND DATE(fee_date) = @selectedDate";

                    using (MySqlCommand command = new MySqlCommand(feeQuery, connection))
                    {
                        command.Parameters.AddWithValue("@selectedDate", selectedDate);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read() && !reader.IsDBNull(reader.GetOrdinal("total_amount")))
                            {
                                decimal amount = Convert.ToDecimal(reader["total_amount"]);
                                feeData[selectedDate] = amount;
                            }
                            else
                            {
                                feeData[selectedDate] = 0;
                            }

                        }
                    }

                    // Load expense data for the specific selected date
                    string expenseQuery = @"
                        SELECT SUM(amount) as total_amount 
                        FROM expenses 
                        WHERE status = 'Paid' 
                        AND DATE(expense_date) = @selectedDate";

                    using (MySqlCommand command = new MySqlCommand(expenseQuery, connection))
                    {
                        command.Parameters.AddWithValue("@selectedDate", selectedDate);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read() && !reader.IsDBNull(reader.GetOrdinal("total_amount")))
                            {
                                decimal amount = Convert.ToDecimal(reader["total_amount"]);
                                expenseData[selectedDate] = amount;
                            }
                            else
                            {
                                expenseData[selectedDate] = 0;
                            }
                        }
                    }
                }

                UpdateSummaryLabels();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateSummaryLabels()
        {
            DateTime selectedDate = dateTimePicker1.Value.Date;

            // Get amounts for the specific selected date
            decimal dailyFees = feeData.ContainsKey(selectedDate) ? feeData[selectedDate] : 0;
            decimal dailyExpenses = expenseData.ContainsKey(selectedDate) ? expenseData[selectedDate] : 0;

            lblTotalAmount.Text = $"Rs.{dailyFees:N0}";
            lblExpenseAmount.Text = $"Rs.{dailyExpenses:N0}";
        }

        private void UpdateChart()
        {
            try
            {
                // Clear existing data
                chart1.Series["Fee Collection"].Points.Clear();
                chart1.Series["Expenses"].Points.Clear();

                DateTime selectedDate = dateTimePicker1.Value.Date;

                // Get amounts for the specific selected date
                decimal dailyFees = feeData.ContainsKey(selectedDate) ? feeData[selectedDate] : 0;
                decimal dailyExpenses = expenseData.ContainsKey(selectedDate) ? expenseData[selectedDate] : 0;

                // Create chart range for the selected date (show a day's span)
                DateTime startTime = selectedDate.Date; // Start of the day (00:00)
                DateTime endTime = selectedDate.Date.AddDays(1).AddMilliseconds(-1); // End of the day (23:59:59.999)

                // Create horizontal lines showing the daily amounts
                // Fee Collection horizontal line (Blue)
                chart1.Series["Fee Collection"].Points.AddXY(startTime, dailyFees);
                chart1.Series["Fee Collection"].Points.AddXY(endTime, dailyFees);

                // Expenses horizontal line (Red)
                chart1.Series["Expenses"].Points.AddXY(startTime, dailyExpenses);
                chart1.Series["Expenses"].Points.AddXY(endTime, dailyExpenses);

                // Set the chart X-axis range to show the full day
                chart1.ChartAreas[0].AxisX.Minimum = startTime.ToOADate();
                chart1.ChartAreas[0].AxisX.Maximum = endTime.ToOADate();

                // Ensure Y-axis shows appropriate range
                decimal maxValue = Math.Max(dailyFees, dailyExpenses);
                if (maxValue == 0)
                {
                    chart1.ChartAreas[0].AxisY.Maximum = 1000; // Default range when no data
                    chart1.ChartAreas[0].AxisY.Minimum = 0;
                }
                else
                {
                    chart1.ChartAreas[0].AxisY.Maximum = (double)(maxValue * 1.2m); // Add 20% padding
                    chart1.ChartAreas[0].AxisY.Minimum = 0;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating chart: {ex.Message}", "Chart Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
            UpdateChart();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void StudentsCount_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void TeachersCount_Click(object sender, EventArgs e)
        {

        }

        private void chartExpenses_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


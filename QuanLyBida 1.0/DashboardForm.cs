using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyBanBida
{
    public partial class ChatBot : Form
    {
        string connectionString = "Data Source=DESKTOP-N764A3I\\SQLEXPRESS;Initial Catalog=QuanLyQuanBiDaFinal1;Integrated Security=True";



        public ChatBot()
        {

            InitializeComponent();
            rbMonth.Checked = true;
            LoadStatistics();
            LoadRevenueStatistics();
        }

        private void ChatBot_Load(object sender, EventArgs e)
        {
            // Mặc định, chọn thống kê theo tháng
            rbDay.Checked = true;
            LoadStatistics();
        }


        private void LoadRevenueStatistics()
        {
            DateTime fromDate = DatePicker.Value;
            DateTime yesterday = fromDate.AddDays(-1);
            DateTime today = fromDate;
            DateTime firstDayOfMonth = new DateTime(fromDate.Year, fromDate.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            string query = @"
    SELECT 
        SUM(CASE WHEN CONVERT(date, DateCheckIn) = @Today THEN totalPrice ELSE 0 END) AS TodayRevenue,
        SUM(CASE WHEN CONVERT(date, DateCheckIn) = @Yesterday THEN totalPrice ELSE 0 END) AS YesterdayRevenue,
        SUM(CASE WHEN CONVERT(date, DateCheckIn) BETWEEN @FirstDayOfMonth AND @LastDayOfMonth THEN totalPrice ELSE 0 END) AS MonthlyRevenue
    FROM 
        Bill
    WHERE 
        status = 1
    ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Today", today.Date);
                command.Parameters.AddWithValue("@Yesterday", yesterday.Date);
                command.Parameters.AddWithValue("@FirstDayOfMonth", firstDayOfMonth.Date);
                command.Parameters.AddWithValue("@LastDayOfMonth", lastDayOfMonth.Date);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];

                    // Kiểm tra giá trị có phải là DBNull không trước khi chuyển đổi
                    decimal todayRevenue = row["TodayRevenue"] != DBNull.Value ? Convert.ToDecimal(row["TodayRevenue"]) : 0;
                    decimal yesterdayRevenue = row["YesterdayRevenue"] != DBNull.Value ? Convert.ToDecimal(row["YesterdayRevenue"]) : 0;
                    decimal monthlyRevenue = row["MonthlyRevenue"] != DBNull.Value ? Convert.ToDecimal(row["MonthlyRevenue"]) : 0;

                    decimal maxRevenueMonth = 10000000;
                    decimal maxRevenue = 1000000;
                    int todayProgress = (int)((todayRevenue / maxRevenue) * 100);
                    int yesterdayProgress = (int)((yesterdayRevenue / maxRevenue) * 100);
                    int monthlyProgress = (int)((monthlyRevenue / maxRevenueMonth) * 100);

                    progressBarTodayRevenue.Maximum = 100;
                    progressBarTodayRevenue.Value = todayProgress;
                    lblTodayRevenue.Text = "Doanh thu hôm nay: $" + todayRevenue.ToString("N2");

                    progressBarYesterdayRevenue.Maximum = 100;
                    progressBarYesterdayRevenue.Value = yesterdayProgress;
                    lblYesterdayRevenue.Text = "Doanh thu hôm qua: $" + yesterdayRevenue.ToString("N2");

                    progressBarMonthlyRevenue.Maximum = 100;
                    progressBarMonthlyRevenue.Value = monthlyProgress;
                    lblMonthlyRevenue.Text = "Doanh thu tháng: $" + monthlyRevenue.ToString("N2");
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu cho thời gian này.");
                }
            }
        }

        private void LoadStatistics()
        {
            DateTime selectedDate = DatePicker.Value;

            string query = "";
            if (rbMonth.Checked)
            {
                int selectedMonth = selectedDate.Month;
                int selectedYear = selectedDate.Year;
                query = "EXEC USP_GetDashboardDataByMonth @SelectedMonth, @SelectedYear";
            }
            else if (rbDay.Checked)
            {
                query = "EXEC USP_GetDashboardDataByDay @SelectedDate";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    if (rbMonth.Checked)
                    {
                        command.Parameters.AddWithValue("@SelectedMonth", selectedDate.Month);
                        command.Parameters.AddWithValue("@SelectedYear", selectedDate.Year);
                    }
                    else if (rbDay.Checked)
                    {
                        command.Parameters.AddWithValue("@SelectedDate", selectedDate);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        DataRow row = dataTable.Rows[0];

                        // Kiểm tra giá trị có phải là DBNull không trước khi chuyển đổi
                        txtTotalTables.Text = row["TotalTables"] != DBNull.Value ? row["TotalTables"].ToString() : "0";
                        txtTotalBills.Text = row["TotalBills"] != DBNull.Value ? row["TotalBills"].ToString() : "0";
                        txtTotalRevenue.Text = row["TotalRevenue"] != DBNull.Value ? row["TotalRevenue"].ToString() : "0";
                        txtTotalFoodOrdered.Text = row["TotalFoodOrdered"] != DBNull.Value ? row["TotalFoodOrdered"].ToString() : "0";
                        txtTotalCustomers.Text = row["TotalCustomers"] != DBNull.Value ? row["TotalCustomers"].ToString() : "0";
                        txtTotalStaff.Text = row["TotalStaff"] != DBNull.Value ? row["TotalStaff"].ToString() : "0";
                    }
                    else
                    {
                        MessageBox.Show("No data available.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void rbMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMonth.Checked)
            {
                LoadStatistics();
            }
        }

        private void rbDay_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDay.Checked)
            {
                LoadStatistics();
            }
        }


        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadStatistics();
        }

        private void rbDay_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbDay.Checked)
            {
                LoadStatistics();
            }
        }

        private void rbMonth_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbMonth.Checked)
            {
                LoadStatistics();
            }
        }

        private void DatePicker_ValueChanged_1(object sender, EventArgs e)
        {
            LoadStatistics();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }



}

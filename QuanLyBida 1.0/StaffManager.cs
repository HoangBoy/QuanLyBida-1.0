using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using QuanLyBanBida.DAO;
using QuanLyBanBida.DTO;

namespace QuanLyBanBida
{
    public partial class StaffManager : Form
    {
        public StaffManager()
        {
            InitializeComponent();
            LoadAcountId();
        }

        private void lbl_NameCategory_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddTable_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private string connectionString = "Data Source=DESKTOP - N764A3I\\SQLEXPRESS;Initial Catalog=QuanLyQuanBiDaFinal1;Integrated Security=True";

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string mucLuongText = txtMucLuong.Text;
            double hourlyRate;
            // Lấy thông tin từ TextBox và DateTimePicker
            if (!double.TryParse(mucLuongText, out hourlyRate))
            {
                MessageBox.Show("Mức lương không hợp lệ. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng xử lý tiếp tục nếu giá trị không hợp lệ
            }
            try {
                
            
            
                
                // Mức lương trên mỗi giờ
                DateTime startDate = new DateTime(dateTimePickerThang.Value.Year, dateTimePickerThang.Value.Month, 1);
                DateTime endDate = startDate.AddMonths(1).AddDays(-1);

                // Chuỗi kết nối đến cơ sở dữ liệu

                
                // Tạo câu lệnh SQL để truy vấn cơ sở dữ liệu và tính lương
                string query = "SELECT EmployeeName, WorkDate, CheckInTime, CheckOutTime FROM Attendance WHERE WorkDate >= @StartDate AND WorkDate <= @EndDate AND AccountName = @AccountName";
                string account = ComboBoxIdAccount.Text;
                // Tạo DataTable để lưu dữ liệu từ cơ sở dữ liệu
                DataTable dataTable = new DataTable();

                // Kết nối đến cơ sở dữ liệu và thực thi câu lệnh SQL
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số vào câu lệnh SQL
                        command.Parameters.AddWithValue("@StartDate", startDate); 
                        command.Parameters.AddWithValue("@EndDate", endDate);
                        command.Parameters.AddWithValue("@AccountName", account);

                        // Tạo DataAdapter để lấy dữ liệu từ cơ sở dữ liệu
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                        // Mở kết nối
                        connection.Open();

                        // Đổ dữ liệu từ cơ sở dữ liệu vào DataTable
                        dataAdapter.Fill(dataTable);
                    }
                }

                // Tính tổng số giờ làm trong tháng
                double totalHoursWorked = TinhTongGioLam(dataTable);

                // Tính lương từ số giờ làm và mức lương/giờ
                double totalSalary = Convert.ToInt32(totalHoursWorked) * hourlyRate;
                buttonTotalHours.Text = $"{totalHoursWorked:N2} giờ";
                buttonTotalSalary.Text = $"{totalSalary.ToString("#,##0 đ")}";
                // Hiển thị kết quả tính toán
                MessageBox.Show(
         $"Tổng số giờ làm trong tháng: {totalHoursWorked:N2} giờ\n" +
         $"Tổng lương: {totalSalary.ToString("#,##0 đ")}",
         "Kết quả tính lương",
         MessageBoxButtons.OK,
         MessageBoxIcon.Information
     );

                dataGridView.DataSource = dataTable;
            }catch(Exception ex)
            {
                MessageBox.Show($"Lỗi {ex} vui lòng thử lại");
            }
           
        }

        // Hàm tính tổng số giờ làm từ dữ liệu trong DataTable
        private double TinhTongGioLam(DataTable dataTable)
        {
            double totalHoursWorked = 0;

            // Duyệt qua từng dòng trong DataTable
            foreach (DataRow row in dataTable.Rows)
            {
                TimeSpan checkInTime = TimeSpan.Parse(row["CheckInTime"].ToString());
                TimeSpan checkOutTime = TimeSpan.Parse(row["CheckOutTime"].ToString());

                // Tính số giờ làm trong mỗi ngày
                double hoursWorked = (checkOutTime - checkInTime).TotalHours;

                // Cộng dồn vào tổng số giờ làm
                totalHoursWorked += hoursWorked;
            }

            return totalHoursWorked;
        }
      
        void LoadAcountId()
        {
            List<Account> listAccount = AccountDAO.Instance.GetListAccount();
            ComboBoxIdAccount.DataSource = listAccount;
            ComboBoxIdAccount.DisplayMember = "UserName";
        }
        private void ComboBoxIdAccount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StaffManager_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

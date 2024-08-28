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
using QuanLyBanBida.DTO;

namespace QuanLyBanBida.DAO
{
    public partial class ChamCong : Form
    {
        public ChamCong()
        {
            InitializeComponent();
            LoadAcountId();
            LoadBangChamCong();
        }
        private string connectionString = "Data Source=DESKTOP-N764A3I\\SQLEXPRESS;Initial Catalog=QuanLyQuanBiDaFinal1;Integrated Security=True";

        private void btn_ChamCong_Click(object sender, EventArgs e)
        {
            string taiKhoan = ComboBoxIdAccount.Text;
            string tenNhanVien = tenNV.Text;
            DateTime ngayChamCong = NgayChamCong.Value;
            TimeSpan checkIn = TimeCheckIn.Value.TimeOfDay;
            TimeSpan checkOut = TimeCheckOut.Value.TimeOfDay;

            if (tenNhanVien == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Attendance (AccountName, EmployeeName, WorkDate, CheckInTime, CheckOutTime) " +
                    "VALUES (@AccountName, @EmployeeName, @WorkDate, @CheckInTime, @CheckOutTime)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("AccountName", taiKhoan);
                command.Parameters.AddWithValue("EmployeeName", tenNhanVien);
                command.Parameters.AddWithValue("@WorkDate", ngayChamCong);
                command.Parameters.AddWithValue("@CheckInTime", checkIn);
                command.Parameters.AddWithValue("@CheckOutTime", checkOut);

                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();

                // Kiểm tra xem có dòng nào được thêm vào cơ sở dữ liệu không
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Chấm công thành công!");
                    LoadBangChamCong();
                }
                else
                {
                    MessageBox.Show("Chấm công thất bại!");
                }
            }

        }

        void LoadBangChamCong()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "select * from Attendance";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);

                DataSet dataSet = new DataSet();

                sqlDataAdapter.Fill(dataSet, "Attendance");
                guna2DataGridView1.DataSource = dataSet.Tables["Attendance"];
            }
        }
        void LoadAcountId()
        {
            List<Account> listAccount = AccountDAO.Instance.GetListAccount();
            ComboBoxIdAccount.DataSource = listAccount;
            ComboBoxIdAccount.DisplayMember = "UserName";
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_idtable_TextChanged(object sender, EventArgs e)
        {

        }

        private void tenNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

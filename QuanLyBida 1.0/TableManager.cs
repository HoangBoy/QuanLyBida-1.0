using QuanLyBanBida.DAO;
using QuanLyBanBida.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Drawing.Layout;
using System.IO;
using PdfSharp.Fonts;
using System.Drawing;
using System.IO;
using System.Drawing;
using System.IO;
using System.IO;
using System.Drawing.Imaging;
using QuanLyBida_1._0.DTO;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace QuanLyBanBida
{

    public partial class f_TableManager : Form
    {
        List<TablePlayTime> tablePlayTimes = new List<TablePlayTime>();

        DateTime startTime;
        DateTime endTime;




        private void SaveStartTimeToDatabase(DateTime startTime, int tableID)
        {
            // Kiểm tra xem thời gian bắt đầu có giá trị hợp lệ hay không
            if (startTime != DateTime.MinValue)
            {
               
                // Kết nối đến cơ sở dữ liệu và cập nhật thời gian bắt đầu cho bàn chơi
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-N764A3I\\SQLEXPRESS;Initial Catalog=QuanLyQuanBiDaFinal1;Integrated Security=True"))
                {
                    connection.Open();

                    // Xóa dữ liệu cũ của bàn chơi (nếu có)
                    SqlCommand deleteCommand = new SqlCommand("DELETE FROM TablePlayTime WHERE TableID = @TableID", connection);
                    deleteCommand.Parameters.AddWithValue("@TableID", tableID);
                    deleteCommand.ExecuteNonQuery();

                    // Chèn thời gian bắt đầu mới cho bàn chơi
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO TablePlayTime (TableID, StartTime) VALUES (@TableID, @StartTime)", connection);
                    insertCommand.Parameters.AddWithValue("@TableID", tableID);
                    insertCommand.Parameters.AddWithValue("@StartTime", startTime);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        private void SaveEndTimeToDatabase(DateTime endTime, int tableID)
        {
            // Kiểm tra xem thời gian kết thúc có giá trị hợp lệ hay không
            if (endTime != DateTime.MinValue)
            {
                // Kết nối đến cơ sở dữ liệu và cập nhật thời gian kết thúc cho bàn chơi
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-N764A3I\\SQLEXPRESS;Initial Catalog=QuanLyQuanBiDaFinal1;Integrated Security=True"))
                {
                    connection.Open();

                    // Cập nhật thời gian kết thúc cho bàn chơi
                    SqlCommand updateCommand = new SqlCommand("UPDATE TablePlayTime SET EndTime = @EndTime WHERE TableID = @TableID", connection);
                    updateCommand.Parameters.AddWithValue("@TableID", tableID);
                    updateCommand.Parameters.AddWithValue("@EndTime", endTime);
                    updateCommand.ExecuteNonQuery();
                }
            }
        }

        private void LoadTablePlayTimesFromDatabase()
        {
            // Kết nối đến cơ sở dữ liệu và truy vấn thông tin thời gian chơi từ bảng TablePlayTime
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-N764A3I\\SQLEXPRESS;Initial Catalog=QuanLyQuanBiDaFinal1;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM TablePlayTime", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int tableID = Convert.ToInt32(reader["TableID"]);

                    // Kiểm tra trước khi chuyển đổi giá trị StartTime từ cơ sở dữ liệu
                    DateTime startTime = reader.IsDBNull(reader.GetOrdinal("StartTime")) ? DateTime.MinValue : Convert.ToDateTime(reader["StartTime"]);

                    // Kiểm tra trước khi chuyển đổi giá trị EndTime từ cơ sở dữ liệu
                    DateTime endTime = reader.IsDBNull(reader.GetOrdinal("EndTime")) ? DateTime.MinValue : Convert.ToDateTime(reader["EndTime"]);

                    // Thêm thông tin thời gian chơi vào danh sách
                    tablePlayTimes.Add(new TablePlayTime(tableID, startTime, endTime));
                }
                reader.Close();
            }
        }

        public f_TableManager()
        {

            InitializeComponent();
            Table();
            LoadCategory();
            LoadComboBoxTable(cb_SwitchTable);

           

        }
        #region Methods
        public void Table()
        {
            // Xóa dữ liệu cũ trong danh sách thời gian chơi của bàn
            tablePlayTimes.Clear();

            // Load danh sách bàn chơi và hiển thị trên giao diện
            LoadTablePlayTimesFromDatabase();
            flpTable.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                // Tạo button cho mỗi bàn
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += Btn_Click;
                btn.Tag = item;

                // Thiết lập màu nền cho button dựa trên trạng thái của bàn
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.MediumSeaGreen;
                        break;
                    case "Có Người":
                        btn.BackColor = Color.DarkRed;
                        break;
                    case "Đặt bàn":
                        btn.BackColor = Color.GreenYellow;
                        break;
                }

                // Hiển thị nút trên flowLayoutPanel
                flpTable.Controls.Add(btn);
                btn.TextImageRelation = TextImageRelation.ImageAboveText;
                btn.Font = new Font("Arial", 9, FontStyle.Bold);
                btn.TextAlign = ContentAlignment.MiddleCenter;

                // Hiển thị thông tin thời gian chơi nếu có
                TablePlayTime playTime = tablePlayTimes.FirstOrDefault(t => t.TableID == item.ID);
                if (playTime != null)
                {
                    // Nếu có thông tin thời gian chơi, cập nhật lại trên giao diện
      
                    UpdatePlayTimeInfoOnUI1(playTime);
                }
            }
        }

        

        private void UpdatePlayTimeInfoOnUI1(TablePlayTime playTime)
        {
            dateTimePickerStartTime.Text = playTime.StartTime.ToString();
            dateTimePickerEndTime.Text = playTime.EndTime.ToString();
        }

        void ShowBill(int id)
        {
            lsvBill.Rows.Clear();
            List<QuanLyBanBida.DTO.Mennu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            double totalPrice = 0;
            foreach (QuanLyBanBida.DTO.Mennu item in listBillInfo)
            {
                lsvBill.Rows.Add(item.FoodName, item.Count, item.Price, item.TotalPrice);
                totalPrice += item.TotalPrice;
            }
            CultureInfo culture = new CultureInfo("vi-VN");

            txttongtien.Text = totalPrice.ToString("c", culture);
        }



        void LoadComboBoxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }

        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }

        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbfood.DataSource = listFood;
            cbfood.DisplayMember = "Name";
        }
        private string GenerateBillText(int tableID, double discount, double timeplayprice, double totalPrice, double finalTotalPrice, double hoursPlayed, double tableHourlyRate)
        {
            StringBuilder billText = new StringBuilder();
            string FoodName = "Tên món";
            string Count = "Số lượng";
            string Price = "Đơn giá";
            string TotalPrice = "Tổng tiền món";

            // Thêm tiêu đề "Thế Giới Bi-da"
            billText.AppendLine("THẾ GIỚI BI-DA");
            billText.AppendLine("".PadRight(72, '-')); // 72 is the total width of the line
            billText.AppendLine($"HÓA ĐƠN BÀN {tableID}");
            billText.AppendLine("".PadRight(72, '-'));

            List<QuanLyBanBida.DTO.Mennu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(tableID);
            billText.AppendLine($"{FoodName,20}{Count,20}{Price,20}{TotalPrice,20}");
            foreach (QuanLyBanBida.DTO.Mennu item in listBillInfo)
            {
                billText.AppendLine($"{item.FoodName,0}{item.Count,22}{item.Price,24}{item.TotalPrice,25}");
            }

            billText.AppendLine("".PadRight(72, '-')); // Add a line to separate items from total section
            CultureInfo culture = new CultureInfo("vi-VN");
            billText.AppendLine($"Giá bàn 1 giờ: {tableHourlyRate.ToString("c", culture)}");
            billText.AppendLine($"Số giờ chơi: {hoursPlayed} giờ");
            billText.AppendLine($"Tiền giờ: {timeplayprice.ToString("c", culture)}");
            billText.AppendLine($"Tổng tiền: {totalPrice.ToString("c", culture)}");
            billText.AppendLine($"Giảm giá: {discount}%");
            billText.AppendLine($"Tổng cộng: {finalTotalPrice.ToString("c", culture)}");

            return billText.ToString();
        }

        private void SaveBillToPdf(int tableID, string billText)
        {
            int fileIndex = 1;
            string filePath = $"Bill_Table_{tableID}_{fileIndex}.pdf";

            while (File.Exists(filePath))
            {
                fileIndex++;
                filePath = $"Bill_Table_{tableID}_{fileIndex}.pdf";
            }

            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            if (GlobalFontSettings.FontResolver == null)
            {
                // Nếu chưa, cài đặt Font Resolver
                GlobalFontSettings.FontResolver = new CustomFontResolver();
            }

            // Tạo font mới
            XFont font = new XFont("Arial", 14);

            //Sử dụng font Arial với kiểu Regular

            XGraphics gfx = XGraphics.FromPdfPage(page);
            XRect rect = new XRect(80, 80, page.Width - 80, page.Height - 80);
            XTextFormatter tf = new XTextFormatter(gfx);
            tf.Alignment = XParagraphAlignment.Left;
            tf.DrawString(billText, font, XBrushes.Black, rect);

            // Chèn hình ảnh vào cuối hóa đơn
            string imagePath = "C:\\Users\\viethoang\\source\\repos\\QuanLyBida 1.0\\QuanLyBida 1.0\\Resources\\qrcode.jpg"; // Đường dẫn đến tệp hình ảnh của bạn
            XImage image = XImage.FromFile(imagePath);
            // Giả sử bạn muốn đặt hình ảnh lớn hơn và nằm dưới bill
            double imageWidth = 300; // Độ rộng của hình ảnh
            double imageHeight = 450; // Độ cao của hình ảnh
            double imageX = (page.Width - imageWidth) / 2; // Đặt hình ảnh ở giữa trang theo chiều ngang
            double imageY = page.Height / 2; // Đặt hình ảnh ở dưới bill

            // Vẽ hình ảnh vào trang PDF với vị trí và kích thước mới
            gfx.DrawImage(image, imageX, imageY, imageWidth, imageHeight);


            document.Save(filePath);
            document.Close();

            // Mở tệp PDF bằng ứng dụng đọc PDF mặc định của hệ điều hành
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = filePath,
                UseShellExecute = true
            });
        }

        // Phương thức để lấy chuỗi hexa của hình ảnh từ đường dẫn tệp







        #endregion

        #region Events
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = ((sender as Button).Tag);
            ShowBill(tableID);

            // Hiển thị thông tin thời gian chơi nếu có
            TablePlayTime playTime = tablePlayTimes.FirstOrDefault(t => t.TableID == tableID);
            if (playTime != null)
            {
                dateTimePickerStartTime.Text = playTime.StartTime.ToString();
                dateTimePickerEndTime.Text = playTime.EndTime.ToString();
            }
            else
            {
                // Nếu không có thông tin thời gian chơi, đặt lại giá trị mặc định
                dateTimePickerStartTime.Text = "";
                dateTimePickerEndTime.Text = "";
            }
        }




        #endregion

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            Category selected = cb.SelectedItem as Category;
            id = selected.Id;
            LoadFoodListByCategoryID(id);
        }

        private void btn_AddFood_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = (cbfood.SelectedItem as Food).Id;
            int count = (int)nmFoodCount.Value;

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }



            ShowBill(table.ID);

            Table();
        }




        private void btn_Checkout_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            int idBill;
            int discount = (int)nm_Discount.Value;
            if (BillDAO.Instance != null)
            {
                // BillDAO.Instance đã được khởi tạo, có thể gọi phương thức của nó
                idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
               
            }
            else
            {

                MessageBox.Show("BillDAO.Instance chưa được khởi tạo!");
                return;
            }
            if (idBill != -1)
            {
                TablePlayTime playTime = tablePlayTimes.FirstOrDefault(t => t.TableID == table.ID);
                // Kiểm tra nếu startTime và endTime đã được cập nhật
                if (playTime.StartTime == DateTime.MinValue || playTime.EndTime == DateTime.MinValue)
                {
                    MessageBox.Show("Vui lòng nhập thời điểm bắt đầu và kết thúc chơi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Không thực hiện các tính toán nếu thiếu dữ liệu
                }

                // Tính toán số giờ chơi
                TimeSpan timePlayed =  playTime.EndTime - playTime.StartTime;

                // Chuyển đổi số giờ chơi sang số double
                double hoursPlayed = timePlayed.TotalHours;

                // Lấy giá bàn 1 giờ chơi từ CSDL hoặc các nguồn khác
                double tableHourlyRate = 50000; // Giả sử giá bàn là 50 đồng/giờ

                // Tính tiền chơi theo giờ
                double timePlayPrice = hoursPlayed * (tableHourlyRate);

                string totalPriceString = txttongtien.Text.Replace(" ₫", "").Replace(",", "");
                double totalPrice  = double.Parse(totalPriceString)*1000;

                // Tính tổng số tiền sau khi áp dụng chiết khấu
                double finalTotalPrice = totalPrice - (totalPrice * discount / 100) + timePlayPrice;

                string billText = GenerateBillText(table.ID, discount, timePlayPrice, totalPrice, finalTotalPrice, hoursPlayed, tableHourlyRate);
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thanh toán tiền bàn không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    // Thanh toán và cập nhật dữ liệu
                    BillDAO.Instance.CheckOut(idBill, discount, (float)finalTotalPrice);
                    BillDAO.Instance.DeleteBillInfoByBillID(idBill);
                    SaveBillToPdf(table.ID, billText);
                    Table();
                }
            }
        }



        private void btn_SwitchTable_Click(object sender, EventArgs e)
        {
            int id1 = (lsvBill.Tag as Table).ID;

            int id2 = (cb_SwitchTable.SelectedItem as Table).ID;
            if (id1 == id2)
            {
                MessageBox.Show("Vui lòng chọn bàn muốn chuyển sang");
                return;
            }
            if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển bàn {0} qua bàn {1}", (lsvBill.Tag as Table).Name, (cb_SwitchTable.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.SwitchTable(id1, id2);

                Table();
            }
        }

        private void dateTimePickerEndTime_ValueChanged(object sender, EventArgs e)
        {

        }
        public static class FontHelper
        {
            public static readonly byte[] Arial = File.ReadAllBytes("Arial.ttf");
            public static readonly byte[] Helvetica = File.ReadAllBytes("Helvetica.ttf");
            public static readonly byte[] TimesNewRoman = File.ReadAllBytes("TimesNewRoman.ttf");
        }
        public class CustomFontResolver : IFontResolver
        {
            public byte[] GetFont(string faceName)
            {
                // Đường dẫn đến file font
                string fontPath = "C:\\Windows\\Fonts\\Arial.ttf";

                // Kiểm tra xem file font có tồn tại không
                if (File.Exists(fontPath))
                {
                    // Đọc dữ liệu từ file font
                    return File.ReadAllBytes(fontPath);
                }
                else
                {
                    // Trả về null nếu không tìm thấy font
                    return null;
                }
            }
            public FontResolverInfo? ResolveTypeface(string familyName, bool isBold, bool isItalic)
            {
                // Đây là một triển khai đơn giản, bạn có thể điều chỉnh cho phù hợp với nhu cầu của bạn
                return new FontResolverInfo(familyName);
            }



            public string DefaultFontName => "Arial"; // Font mặc định
        }

        private void cbfood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerEndTime_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (table != null)
            {
                DateTime currentTime = DateTime.UtcNow;
                currentTime.AddHours(7);
                TablePlayTime playTime = tablePlayTimes.FirstOrDefault(t => t.TableID == table.ID);
                if (playTime == null || playTime.StartTime == DateTime.MinValue)
                {
                    MessageBox.Show("Vui lòng nhập thời điểm bắt đầu trước khi nhập thời điểm kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                playTime.EndTime = currentTime;
                dateTimePickerEndTime.Text = playTime.EndTime.ToString();

                SaveEndTimeToDatabase(currentTime, table.ID);
                btn_AddFood_Click(sender, e);
            }
        }

        private void dateTimePickerStartTime_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (table != null)
            {
                DateTime currentTime = DateTime.UtcNow ;
                currentTime.AddHours(7);
                TablePlayTime playTime = tablePlayTimes.FirstOrDefault(t => t.TableID == table.ID);
                if (playTime == null)
                {
                    playTime = new TablePlayTime
                    {
                        TableID = table.ID,
                        StartTime = currentTime
                    };
                    tablePlayTimes.Add(playTime);
                }
                else
                {
                    playTime.StartTime = currentTime  ;
                }

                dateTimePickerStartTime.Text = playTime.StartTime.ToString();
                SaveStartTimeToDatabase(currentTime, table.ID);
                btn_AddFood_Click(sender, e);


            }
        }




        private void flpTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txttongtien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

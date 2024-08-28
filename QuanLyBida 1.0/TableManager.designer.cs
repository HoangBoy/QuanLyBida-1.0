namespace QuanLyBanBida
{
    partial class f_TableManager
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel3 = new Panel();
            label4 = new Label();
            cb_SwitchTable = new ComboBox();
            btn_SwitchTable = new Button();
            txttongtien = new Guna.UI2.WinForms.Guna2TextBox();
            nm_Discount = new NumericUpDown();
            btn_Checkout = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            dateTimePickerEndTime = new Guna.UI2.WinForms.Guna2Button();
            dateTimePickerStartTime = new Guna.UI2.WinForms.Guna2Button();
            flpTable = new FlowLayoutPanel();
            btn_AddFood = new Button();
            nmFoodCount = new NumericUpDown();
            cbCategory = new ComboBox();
            cbfood = new ComboBox();
            panel4 = new Panel();
            lsvBill = new Guna.UI2.WinForms.Guna2DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nm_Discount).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lsvBill).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.Azure;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(cb_SwitchTable);
            panel3.Controls.Add(btn_SwitchTable);
            panel3.Location = new Point(650, 236);
            panel3.Name = "panel3";
            panel3.Size = new Size(360, 131);
            panel3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(65, 9);
            label4.Name = "label4";
            label4.Size = new Size(74, 13);
            label4.TabIndex = 12;
            label4.Text = "Chuyển bàn";
            // 
            // cb_SwitchTable
            // 
            cb_SwitchTable.BackColor = Color.DimGray;
            cb_SwitchTable.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cb_SwitchTable.ForeColor = Color.White;
            cb_SwitchTable.FormattingEnabled = true;
            cb_SwitchTable.ItemHeight = 13;
            cb_SwitchTable.Location = new Point(65, 34);
            cb_SwitchTable.Name = "cb_SwitchTable";
            cb_SwitchTable.Size = new Size(207, 21);
            cb_SwitchTable.TabIndex = 4;
            // 
            // btn_SwitchTable
            // 
            btn_SwitchTable.BackColor = Color.FromArgb(94, 148, 255);
            btn_SwitchTable.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_SwitchTable.ForeColor = Color.White;
            btn_SwitchTable.Location = new Point(101, 70);
            btn_SwitchTable.Name = "btn_SwitchTable";
            btn_SwitchTable.Size = new Size(147, 47);
            btn_SwitchTable.TabIndex = 6;
            btn_SwitchTable.Text = "Chuyển bàn";
            btn_SwitchTable.UseVisualStyleBackColor = false;
            btn_SwitchTable.Click += btn_SwitchTable_Click;
            // 
            // txttongtien
            // 
            txttongtien.Animated = true;
            txttongtien.AutoRoundedCorners = true;
            txttongtien.BorderColor = Color.Transparent;
            txttongtien.BorderRadius = 31;
            txttongtien.Cursor = Cursors.IBeam;
            txttongtien.CustomizableEdges = customizableEdges1;
            txttongtien.DefaultText = "Tổng Tiền";
            txttongtien.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txttongtien.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txttongtien.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txttongtien.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txttongtien.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txttongtien.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txttongtien.ForeColor = Color.Black;
            txttongtien.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txttongtien.Location = new Point(650, 7);
            txttongtien.Margin = new Padding(4);
            txttongtien.Name = "txttongtien";
            txttongtien.PasswordChar = '\0';
            txttongtien.PlaceholderForeColor = Color.White;
            txttongtien.PlaceholderText = "";
            txttongtien.SelectedText = "";
            txttongtien.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txttongtien.Size = new Size(360, 65);
            txttongtien.TabIndex = 33;
            txttongtien.TextAlign = HorizontalAlignment.Center;
            txttongtien.TextChanged += txttongtien_TextChanged;
            // 
            // nm_Discount
            // 
            nm_Discount.BackColor = Color.Silver;
            nm_Discount.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nm_Discount.ForeColor = Color.White;
            nm_Discount.Location = new Point(72, 188);
            nm_Discount.Name = "nm_Discount";
            nm_Discount.Size = new Size(230, 19);
            nm_Discount.TabIndex = 4;
            nm_Discount.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_Checkout
            // 
            btn_Checkout.BackColor = Color.LimeGreen;
            btn_Checkout.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Checkout.ForeColor = Color.White;
            btn_Checkout.Location = new Point(72, 223);
            btn_Checkout.Name = "btn_Checkout";
            btn_Checkout.Size = new Size(224, 61);
            btn_Checkout.TabIndex = 4;
            btn_Checkout.Text = "Thanh toán";
            btn_Checkout.UseVisualStyleBackColor = false;
            btn_Checkout.Click += btn_Checkout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(72, 22);
            label1.Name = "label1";
            label1.Size = new Size(108, 13);
            label1.TabIndex = 9;
            label1.Text = "Thời gian bắt đầu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(72, 94);
            label2.Name = "label2";
            label2.Size = new Size(111, 13);
            label2.TabIndex = 10;
            label2.Text = "Thời gian kết thúc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(72, 172);
            label3.Name = "label3";
            label3.Size = new Size(69, 13);
            label3.TabIndex = 11;
            label3.Text = "Giảm giá %";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(dateTimePickerEndTime);
            panel1.Controls.Add(dateTimePickerStartTime);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_Checkout);
            panel1.Controls.Add(nm_Discount);
            panel1.Location = new Point(650, 385);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 305);
            panel1.TabIndex = 9;
            // 
            // dateTimePickerEndTime
            // 
            dateTimePickerEndTime.CustomizableEdges = customizableEdges3;
            dateTimePickerEndTime.DisabledState.BorderColor = Color.DarkGray;
            dateTimePickerEndTime.DisabledState.CustomBorderColor = Color.DarkGray;
            dateTimePickerEndTime.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            dateTimePickerEndTime.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            dateTimePickerEndTime.FillColor = Color.White;
            dateTimePickerEndTime.Font = new Font("Segoe UI", 10.875F);
            dateTimePickerEndTime.ForeColor = Color.Black;
            dateTimePickerEndTime.Location = new Point(72, 110);
            dateTimePickerEndTime.Name = "dateTimePickerEndTime";
            dateTimePickerEndTime.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dateTimePickerEndTime.Size = new Size(224, 45);
            dateTimePickerEndTime.TabIndex = 15;
            dateTimePickerEndTime.Text = "Kết Thúc ";
            dateTimePickerEndTime.Click += dateTimePickerEndTime_Click;
            // 
            // dateTimePickerStartTime
            // 
            dateTimePickerStartTime.CustomizableEdges = customizableEdges5;
            dateTimePickerStartTime.DisabledState.BorderColor = Color.DarkGray;
            dateTimePickerStartTime.DisabledState.CustomBorderColor = Color.DarkGray;
            dateTimePickerStartTime.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            dateTimePickerStartTime.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            dateTimePickerStartTime.FillColor = Color.White;
            dateTimePickerStartTime.Font = new Font("Segoe UI", 10.875F);
            dateTimePickerStartTime.ForeColor = Color.Black;
            dateTimePickerStartTime.Location = new Point(72, 46);
            dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            dateTimePickerStartTime.ShadowDecoration.CustomizableEdges = customizableEdges6;
            dateTimePickerStartTime.Size = new Size(224, 45);
            dateTimePickerStartTime.TabIndex = 14;
            dateTimePickerStartTime.Text = "Bắt Đầu Chơi";
            dateTimePickerStartTime.Click += dateTimePickerStartTime_Click;
            // 
            // flpTable
            // 
            flpTable.BackColor = Color.Teal;
            flpTable.BackgroundImageLayout = ImageLayout.Center;
            flpTable.Location = new Point(12, 12);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(310, 678);
            flpTable.TabIndex = 5;
            flpTable.Paint += flpTable_Paint;
            // 
            // btn_AddFood
            // 
            btn_AddFood.BackColor = Color.MediumSeaGreen;
            btn_AddFood.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AddFood.ForeColor = Color.White;
            btn_AddFood.Location = new Point(101, 85);
            btn_AddFood.Name = "btn_AddFood";
            btn_AddFood.Size = new Size(147, 43);
            btn_AddFood.TabIndex = 2;
            btn_AddFood.Text = "Đặt dịch vụ";
            btn_AddFood.UseVisualStyleBackColor = false;
            btn_AddFood.Click += btn_AddFood_Click;
            // 
            // nmFoodCount
            // 
            nmFoodCount.BackColor = Color.DimGray;
            nmFoodCount.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nmFoodCount.ForeColor = Color.White;
            nmFoodCount.Location = new Point(101, 50);
            nmFoodCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nmFoodCount.Name = "nmFoodCount";
            nmFoodCount.Size = new Size(130, 19);
            nmFoodCount.TabIndex = 3;
            nmFoodCount.TextAlign = HorizontalAlignment.Center;
            nmFoodCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbCategory
            // 
            cbCategory.BackColor = Color.DimGray;
            cbCategory.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbCategory.ForeColor = Color.White;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(19, 14);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(143, 21);
            cbCategory.TabIndex = 0;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // cbfood
            // 
            cbfood.BackColor = Color.DimGray;
            cbfood.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbfood.ForeColor = Color.White;
            cbfood.FormattingEnabled = true;
            cbfood.Location = new Point(181, 14);
            cbfood.Name = "cbfood";
            cbfood.Size = new Size(121, 21);
            cbfood.TabIndex = 1;
            cbfood.SelectedIndexChanged += cbfood_SelectedIndexChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Azure;
            panel4.Controls.Add(cbfood);
            panel4.Controls.Add(cbCategory);
            panel4.Controls.Add(nmFoodCount);
            panel4.Controls.Add(btn_AddFood);
            panel4.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel4.Location = new Point(650, 79);
            panel4.Name = "panel4";
            panel4.Size = new Size(359, 141);
            panel4.TabIndex = 8;
            // 
            // lsvBill
            // 
            lsvBill.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            lsvBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            lsvBill.BackgroundColor = Color.Azure;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            lsvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            lsvBill.ColumnHeadersHeight = 40;
            lsvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            lsvBill.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, Column5, Column6 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            lsvBill.DefaultCellStyle = dataGridViewCellStyle3;
            lsvBill.GridColor = Color.FromArgb(242, 245, 250);
            lsvBill.Location = new Point(331, 12);
            lsvBill.Margin = new Padding(6, 7, 6, 7);
            lsvBill.Name = "lsvBill";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            lsvBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            lsvBill.RowHeadersVisible = false;
            lsvBill.RowHeadersWidth = 82;
            lsvBill.RowTemplate.DividerHeight = 5;
            lsvBill.RowTemplate.Height = 40;
            lsvBill.Size = new Size(300, 678);
            lsvBill.TabIndex = 59;
            lsvBill.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            lsvBill.ThemeStyle.AlternatingRowsStyle.Font = null;
            lsvBill.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            lsvBill.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            lsvBill.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            lsvBill.ThemeStyle.BackColor = Color.Azure;
            lsvBill.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            lsvBill.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            lsvBill.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            lsvBill.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 8F);
            lsvBill.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            lsvBill.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            lsvBill.ThemeStyle.HeaderStyle.Height = 40;
            lsvBill.ThemeStyle.ReadOnly = false;
            lsvBill.ThemeStyle.RowsStyle.BackColor = Color.White;
            lsvBill.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            lsvBill.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10.5F);
            lsvBill.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            lsvBill.ThemeStyle.RowsStyle.Height = 40;
            lsvBill.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 0, 192);
            lsvBill.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.FillWeight = 99.49239F;
            dataGridViewTextBoxColumn2.HeaderText = "Tên Món";
            dataGridViewTextBoxColumn2.MinimumWidth = 10;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.FillWeight = 99.49239F;
            dataGridViewTextBoxColumn3.HeaderText = "Số Lượng";
            dataGridViewTextBoxColumn3.MinimumWidth = 10;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Column5
            // 
            Column5.FillWeight = 99.49239F;
            Column5.HeaderText = "Đơn Giá";
            Column5.MinimumWidth = 10;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.FillWeight = 99.49239F;
            Column6.HeaderText = "Thành Tiền";
            Column6.MinimumWidth = 10;
            Column6.Name = "Column6";
            // 
            // f_TableManager
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(242, 245, 250);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1042, 760);
            Controls.Add(lsvBill);
            Controls.Add(txttongtien);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(flpTable);
            Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(242, 245, 250);
            Margin = new Padding(4);
            Name = "f_TableManager";
            Text = "Quản lý bàn";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nm_Discount).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)lsvBill).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cb_SwitchTable;
        private System.Windows.Forms.Button btn_SwitchTable;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txttongtien;
        private System.Windows.Forms.NumericUpDown nm_Discount;
        private System.Windows.Forms.Button btn_Checkout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Button btn_AddFood;
        private System.Windows.Forms.NumericUpDown nmFoodCount;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbfood;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2DataGridView lsvBill;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Guna.UI2.WinForms.Guna2Button dateTimePickerEndTime;
        private Guna.UI2.WinForms.Guna2Button dateTimePickerStartTime;
    }
}
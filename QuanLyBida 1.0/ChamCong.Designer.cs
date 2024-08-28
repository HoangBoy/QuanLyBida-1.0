namespace QuanLyBanBida.DAO
{
    partial class ChamCong
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChamCong));
            panel4 = new Panel();
            ComboBoxIdAccount = new Guna.UI2.WinForms.Guna2ComboBox();
            TimeCheckOut = new Guna.UI2.WinForms.Guna2DateTimePicker();
            TimeCheckIn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            NgayChamCong = new Guna.UI2.WinForms.Guna2DateTimePicker();
            btn_ChamCong = new Button();
            tenNV = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lbl_NameCategory = new Label();
            lbl_CategoryID = new Label();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            button1 = new Button();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(btn_ChamCong);
            panel4.Controls.Add(ComboBoxIdAccount);
            panel4.Controls.Add(TimeCheckOut);
            panel4.Controls.Add(TimeCheckIn);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(NgayChamCong);
            panel4.Controls.Add(tenNV);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(lbl_NameCategory);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(lbl_CategoryID);
            panel4.Location = new Point(1092, 219);
            panel4.Margin = new Padding(4, 8, 4, 8);
            panel4.Name = "panel4";
            panel4.Size = new Size(652, 885);
            panel4.TabIndex = 21;
            panel4.Paint += panel4_Paint;
            // 
            // ComboBoxIdAccount
            // 
            ComboBoxIdAccount.BackColor = Color.Transparent;
            ComboBoxIdAccount.BorderColor = Color.Black;
            ComboBoxIdAccount.BorderRadius = 20;
            ComboBoxIdAccount.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            ComboBoxIdAccount.CustomizableEdges = customizableEdges11;
            ComboBoxIdAccount.DrawMode = DrawMode.OwnerDrawFixed;
            ComboBoxIdAccount.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxIdAccount.FocusedColor = Color.FromArgb(94, 148, 255);
            ComboBoxIdAccount.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            ComboBoxIdAccount.Font = new Font("Segoe UI", 10F);
            ComboBoxIdAccount.ForeColor = Color.FromArgb(68, 88, 112);
            ComboBoxIdAccount.ItemHeight = 30;
            ComboBoxIdAccount.Location = new Point(80, 117);
            ComboBoxIdAccount.Margin = new Padding(3, 4, 3, 4);
            ComboBoxIdAccount.Name = "ComboBoxIdAccount";
            ComboBoxIdAccount.ShadowDecoration.CustomizableEdges = customizableEdges12;
            ComboBoxIdAccount.Size = new Size(194, 36);
            ComboBoxIdAccount.TabIndex = 46;
            // 
            // TimeCheckOut
            // 
            TimeCheckOut.BorderRadius = 10;
            TimeCheckOut.Checked = true;
            TimeCheckOut.CustomizableEdges = customizableEdges13;
            TimeCheckOut.FillColor = Color.White;
            TimeCheckOut.Font = new Font("Segoe UI", 9F);
            TimeCheckOut.ForeColor = SystemColors.ActiveCaptionText;
            TimeCheckOut.Format = DateTimePickerFormat.Time;
            TimeCheckOut.Location = new Point(389, 297);
            TimeCheckOut.Margin = new Padding(3, 4, 3, 4);
            TimeCheckOut.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            TimeCheckOut.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            TimeCheckOut.Name = "TimeCheckOut";
            TimeCheckOut.ShadowDecoration.CustomizableEdges = customizableEdges14;
            TimeCheckOut.ShowUpDown = true;
            TimeCheckOut.Size = new Size(217, 58);
            TimeCheckOut.TabIndex = 45;
            TimeCheckOut.Value = new DateTime(2024, 4, 10, 16, 37, 20, 695);
            // 
            // TimeCheckIn
            // 
            TimeCheckIn.BorderRadius = 10;
            TimeCheckIn.Checked = true;
            TimeCheckIn.CustomizableEdges = customizableEdges15;
            TimeCheckIn.FillColor = Color.White;
            TimeCheckIn.Font = new Font("Segoe UI", 9F);
            TimeCheckIn.ForeColor = SystemColors.ActiveCaptionText;
            TimeCheckIn.Format = DateTimePickerFormat.Time;
            TimeCheckIn.Location = new Point(389, 469);
            TimeCheckIn.Margin = new Padding(3, 4, 3, 4);
            TimeCheckIn.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            TimeCheckIn.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            TimeCheckIn.Name = "TimeCheckIn";
            TimeCheckIn.ShadowDecoration.CustomizableEdges = customizableEdges16;
            TimeCheckIn.ShowUpDown = true;
            TimeCheckIn.Size = new Size(217, 58);
            TimeCheckIn.TabIndex = 44;
            TimeCheckIn.Value = new DateTime(2024, 4, 10, 16, 37, 20, 695);
            // 
            // NgayChamCong
            // 
            NgayChamCong.BorderRadius = 10;
            NgayChamCong.Checked = true;
            NgayChamCong.CustomizableEdges = customizableEdges17;
            NgayChamCong.FillColor = Color.White;
            NgayChamCong.Font = new Font("Segoe UI", 9F);
            NgayChamCong.ForeColor = SystemColors.ActiveCaptionText;
            NgayChamCong.Format = DateTimePickerFormat.Short;
            NgayChamCong.Location = new Point(389, 132);
            NgayChamCong.Margin = new Padding(3, 4, 3, 4);
            NgayChamCong.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            NgayChamCong.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            NgayChamCong.Name = "NgayChamCong";
            NgayChamCong.ShadowDecoration.CustomizableEdges = customizableEdges18;
            NgayChamCong.Size = new Size(217, 58);
            NgayChamCong.TabIndex = 22;
            NgayChamCong.Value = new DateTime(2024, 4, 10, 16, 42, 30, 319);
            NgayChamCong.ValueChanged += guna2DateTimePicker1_ValueChanged;
            // 
            // btn_ChamCong
            // 
            btn_ChamCong.BackColor = Color.LimeGreen;
            btn_ChamCong.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ChamCong.ForeColor = Color.White;
            btn_ChamCong.Location = new Point(244, 660);
            btn_ChamCong.Margin = new Padding(4, 8, 4, 8);
            btn_ChamCong.Name = "btn_ChamCong";
            btn_ChamCong.Size = new Size(210, 106);
            btn_ChamCong.TabIndex = 1;
            btn_ChamCong.Text = "Chấm Công";
            btn_ChamCong.UseVisualStyleBackColor = false;
            btn_ChamCong.Click += btn_ChamCong_Click;
            // 
            // tenNV
            // 
            tenNV.Animated = true;
            tenNV.AutoRoundedCorners = true;
            tenNV.BackColor = Color.Transparent;
            tenNV.BorderColor = Color.Transparent;
            tenNV.BorderRadius = 27;
            tenNV.Cursor = Cursors.IBeam;
            tenNV.CustomizableEdges = customizableEdges19;
            tenNV.DefaultText = "";
            tenNV.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tenNV.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tenNV.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tenNV.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tenNV.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tenNV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tenNV.ForeColor = Color.White;
            tenNV.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tenNV.Location = new Point(82, 298);
            tenNV.Margin = new Padding(13, 15, 13, 15);
            tenNV.Name = "tenNV";
            tenNV.PasswordChar = '\0';
            tenNV.PlaceholderForeColor = Color.White;
            tenNV.PlaceholderText = "";
            tenNV.SelectedText = "";
            tenNV.ShadowDecoration.CustomizableEdges = customizableEdges20;
            tenNV.Size = new Size(224, 57);
            tenNV.TabIndex = 39;
            tenNV.TextChanged += tenNV_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(382, 246);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(114, 37);
            label3.TabIndex = 38;
            label3.Text = "Giờ ra:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(382, 418);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(136, 37);
            label2.TabIndex = 36;
            label2.Text = "Giờ vào:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(382, 67);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 37);
            label1.TabIndex = 34;
            label1.Text = "Ngày :";
            // 
            // lbl_NameCategory
            // 
            lbl_NameCategory.AutoSize = true;
            lbl_NameCategory.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NameCategory.ForeColor = Color.Black;
            lbl_NameCategory.Location = new Point(74, 246);
            lbl_NameCategory.Margin = new Padding(4, 0, 4, 0);
            lbl_NameCategory.Name = "lbl_NameCategory";
            lbl_NameCategory.Size = new Size(232, 37);
            lbl_NameCategory.TabIndex = 2;
            lbl_NameCategory.Text = "Tên Nhân Viên";
            // 
            // lbl_CategoryID
            // 
            lbl_CategoryID.AutoSize = true;
            lbl_CategoryID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CategoryID.ForeColor = Color.Black;
            lbl_CategoryID.Location = new Point(82, 67);
            lbl_CategoryID.Margin = new Padding(4, 0, 4, 0);
            lbl_CategoryID.Name = "lbl_CategoryID";
            lbl_CategoryID.Size = new Size(168, 37);
            lbl_CategoryID.TabIndex = 1;
            lbl_CategoryID.Text = "Tài khoản:";
            // 
            // guna2DataGridView1
            // 
            guna2DataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            guna2DataGridView1.BackgroundColor = Color.Azure;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 8F);
            dataGridViewCellStyle6.ForeColor = Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            guna2DataGridView1.ColumnHeadersHeight = 40;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            guna2DataGridView1.GridColor = Color.FromArgb(242, 245, 250);
            guna2DataGridView1.Location = new Point(43, 219);
            guna2DataGridView1.Margin = new Padding(6, 7, 6, 7);
            guna2DataGridView1.Name = "guna2DataGridView1";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 82;
            guna2DataGridView1.RowTemplate.DividerHeight = 5;
            guna2DataGridView1.RowTemplate.Height = 40;
            guna2DataGridView1.Size = new Size(973, 885);
            guna2DataGridView1.TabIndex = 59;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.Azure;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 8F);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 40;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10.5F);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 40;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 0, 192);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumAquamarine;
            button1.Font = new Font("Microsoft Sans Serif", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(43, 43);
            button1.Margin = new Padding(4, 8, 4, 8);
            button1.Name = "button1";
            button1.Size = new Size(1920, 104);
            button1.TabIndex = 47;
            button1.Text = " Bảng Chấm Công Nhân Viên";
            button1.UseVisualStyleBackColor = false;
            // 
            // ChamCong
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 245, 250);
            ClientSize = new Size(1806, 1157);
            Controls.Add(button1);
            Controls.Add(guna2DataGridView1);
            Controls.Add(panel4);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ChamCong";
            Text = "ChamCong";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2TextBox tenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_NameCategory;
        private System.Windows.Forms.Label lbl_CategoryID;
        private System.Windows.Forms.Button btn_ChamCong;
        private Guna.UI2.WinForms.Guna2DateTimePicker NgayChamCong;
        private Guna.UI2.WinForms.Guna2DateTimePicker TimeCheckOut;
        private Guna.UI2.WinForms.Guna2DateTimePicker TimeCheckIn;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxIdAccount;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Button button1;
    }
}
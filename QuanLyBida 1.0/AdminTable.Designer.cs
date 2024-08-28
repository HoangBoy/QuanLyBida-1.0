namespace QuanLyBanBida
{
    partial class AdminTable
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminTable));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            btn_ViewTable = new Button();
            btn_EditTable = new Button();
            btn_SearchTable = new Button();
            panel5 = new Panel();
            btn_DeleteTable = new Button();
            btn_AddTable = new Button();
            panel6 = new Panel();
            txt_SearchTableName = new Guna.UI2.WinForms.Guna2TextBox();
            panel4 = new Panel();
            cb_TableStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            lbl_CategoryID = new Label();
            txt_TableName = new Guna.UI2.WinForms.Guna2TextBox();
            lbl_NameCategory = new Label();
            label1 = new Label();
            txt_idtable = new Guna.UI2.WinForms.Guna2TextBox();
            panel1 = new Panel();
            btn_LastCategory = new Button();
            btn_PrevioursCategory = new Button();
            btn_FristCategory = new Button();
            btn_NextCategory = new Button();
            dtgv_Table = new Guna.UI2.WinForms.Guna2DataGridView();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_Table).BeginInit();
            SuspendLayout();
            // 
            // btn_ViewTable
            // 
            btn_ViewTable.BackColor = Color.Blue;
            btn_ViewTable.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ViewTable.ForeColor = Color.White;
            btn_ViewTable.Location = new Point(323, 190);
            btn_ViewTable.Margin = new Padding(4, 8, 4, 8);
            btn_ViewTable.Name = "btn_ViewTable";
            btn_ViewTable.Size = new Size(121, 106);
            btn_ViewTable.TabIndex = 4;
            btn_ViewTable.Text = "Xem";
            btn_ViewTable.UseVisualStyleBackColor = false;
            btn_ViewTable.Click += btn_ViewTable_Click;
            // 
            // btn_EditTable
            // 
            btn_EditTable.BackColor = Color.FromArgb(192, 192, 0);
            btn_EditTable.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_EditTable.ForeColor = Color.White;
            btn_EditTable.Location = new Point(98, 197);
            btn_EditTable.Margin = new Padding(4, 8, 4, 8);
            btn_EditTable.Name = "btn_EditTable";
            btn_EditTable.Size = new Size(121, 106);
            btn_EditTable.TabIndex = 3;
            btn_EditTable.Text = "Sửa";
            btn_EditTable.UseVisualStyleBackColor = false;
            btn_EditTable.Click += btn_EditTable_Click;
            // 
            // btn_SearchTable
            // 
            btn_SearchTable.BackColor = Color.SeaGreen;
            btn_SearchTable.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_SearchTable.ForeColor = Color.White;
            btn_SearchTable.Location = new Point(1609, 40);
            btn_SearchTable.Margin = new Padding(4, 8, 4, 8);
            btn_SearchTable.Name = "btn_SearchTable";
            btn_SearchTable.Size = new Size(223, 72);
            btn_SearchTable.TabIndex = 5;
            btn_SearchTable.Text = "Tìm kiếm";
            btn_SearchTable.UseVisualStyleBackColor = false;
            btn_SearchTable.Click += btn_SearchTable_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(btn_ViewTable);
            panel5.Controls.Add(btn_DeleteTable);
            panel5.Controls.Add(btn_AddTable);
            panel5.Controls.Add(btn_EditTable);
            panel5.Location = new Point(1451, 794);
            panel5.Margin = new Padding(4, 8, 4, 8);
            panel5.Name = "panel5";
            panel5.Size = new Size(522, 370);
            panel5.TabIndex = 14;
            panel5.Paint += panel5_Paint;
            // 
            // btn_DeleteTable
            // 
            btn_DeleteTable.BackColor = Color.FromArgb(192, 0, 0);
            btn_DeleteTable.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_DeleteTable.ForeColor = Color.White;
            btn_DeleteTable.Location = new Point(323, 68);
            btn_DeleteTable.Margin = new Padding(4, 8, 4, 8);
            btn_DeleteTable.Name = "btn_DeleteTable";
            btn_DeleteTable.Size = new Size(121, 106);
            btn_DeleteTable.TabIndex = 4;
            btn_DeleteTable.Text = "Xóa";
            btn_DeleteTable.UseVisualStyleBackColor = false;
            btn_DeleteTable.Click += btn_DeleteTable_Click_1;
            // 
            // btn_AddTable
            // 
            btn_AddTable.BackColor = Color.ForestGreen;
            btn_AddTable.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AddTable.ForeColor = Color.White;
            btn_AddTable.Location = new Point(98, 68);
            btn_AddTable.Margin = new Padding(4, 8, 4, 8);
            btn_AddTable.Name = "btn_AddTable";
            btn_AddTable.Size = new Size(121, 106);
            btn_AddTable.TabIndex = 3;
            btn_AddTable.Text = "Thêm";
            btn_AddTable.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Azure;
            panel6.Controls.Add(txt_SearchTableName);
            panel6.Controls.Add(btn_SearchTable);
            panel6.Location = new Point(22, 17);
            panel6.Margin = new Padding(4, 8, 4, 8);
            panel6.Name = "panel6";
            panel6.Size = new Size(1951, 150);
            panel6.TabIndex = 16;
            // 
            // txt_SearchTableName
            // 
            txt_SearchTableName.Animated = true;
            txt_SearchTableName.AutoRoundedCorners = true;
            txt_SearchTableName.BorderColor = Color.DarkCyan;
            txt_SearchTableName.BorderRadius = 35;
            txt_SearchTableName.BorderThickness = 3;
            txt_SearchTableName.Cursor = Cursors.IBeam;
            txt_SearchTableName.CustomizableEdges = customizableEdges9;
            txt_SearchTableName.DefaultText = "";
            txt_SearchTableName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_SearchTableName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_SearchTableName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_SearchTableName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_SearchTableName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_SearchTableName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txt_SearchTableName.ForeColor = Color.White;
            txt_SearchTableName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_SearchTableName.Location = new Point(144, 40);
            txt_SearchTableName.Margin = new Padding(13, 15, 13, 15);
            txt_SearchTableName.Name = "txt_SearchTableName";
            txt_SearchTableName.PasswordChar = '\0';
            txt_SearchTableName.PlaceholderForeColor = Color.White;
            txt_SearchTableName.PlaceholderText = "";
            txt_SearchTableName.SelectedText = "";
            txt_SearchTableName.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txt_SearchTableName.Size = new Size(1330, 72);
            txt_SearchTableName.TabIndex = 30;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(cb_TableStatus);
            panel4.Controls.Add(lbl_CategoryID);
            panel4.Controls.Add(txt_TableName);
            panel4.Controls.Add(lbl_NameCategory);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(txt_idtable);
            panel4.Location = new Point(1451, 185);
            panel4.Margin = new Padding(4, 8, 4, 8);
            panel4.Name = "panel4";
            panel4.Size = new Size(522, 572);
            panel4.TabIndex = 19;
            // 
            // cb_TableStatus
            // 
            cb_TableStatus.AutoRoundedCorners = true;
            cb_TableStatus.BackColor = Color.Transparent;
            cb_TableStatus.BorderColor = Color.DarkCyan;
            cb_TableStatus.BorderRadius = 17;
            cb_TableStatus.BorderThickness = 3;
            cb_TableStatus.CustomizableEdges = customizableEdges11;
            cb_TableStatus.DrawMode = DrawMode.OwnerDrawFixed;
            cb_TableStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_TableStatus.FocusedColor = Color.FromArgb(94, 148, 255);
            cb_TableStatus.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cb_TableStatus.Font = new Font("Segoe UI", 10F);
            cb_TableStatus.ForeColor = Color.Black;
            cb_TableStatus.ItemHeight = 30;
            cb_TableStatus.Items.AddRange(new object[] { "Trống", "Đang Hoạt Động" });
            cb_TableStatus.Location = new Point(86, 395);
            cb_TableStatus.Margin = new Padding(4, 8, 4, 8);
            cb_TableStatus.Name = "cb_TableStatus";
            cb_TableStatus.ShadowDecoration.CustomizableEdges = customizableEdges12;
            cb_TableStatus.Size = new Size(300, 36);
            cb_TableStatus.TabIndex = 37;
            // 
            // lbl_CategoryID
            // 
            lbl_CategoryID.AutoSize = true;
            lbl_CategoryID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CategoryID.ForeColor = Color.Black;
            lbl_CategoryID.Location = new Point(81, 70);
            lbl_CategoryID.Margin = new Padding(4, 0, 4, 0);
            lbl_CategoryID.Name = "lbl_CategoryID";
            lbl_CategoryID.Size = new Size(66, 37);
            lbl_CategoryID.TabIndex = 34;
            lbl_CategoryID.Text = "ID: ";
            // 
            // txt_TableName
            // 
            txt_TableName.Animated = true;
            txt_TableName.AutoRoundedCorners = true;
            txt_TableName.BackColor = Color.Transparent;
            txt_TableName.BorderColor = Color.DarkCyan;
            txt_TableName.BorderRadius = 28;
            txt_TableName.BorderThickness = 3;
            txt_TableName.Cursor = Cursors.IBeam;
            txt_TableName.CustomizableEdges = customizableEdges13;
            txt_TableName.DefaultText = "";
            txt_TableName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_TableName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_TableName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_TableName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_TableName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_TableName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txt_TableName.ForeColor = Color.Black;
            txt_TableName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_TableName.Location = new Point(86, 262);
            txt_TableName.Margin = new Padding(13, 15, 13, 15);
            txt_TableName.Name = "txt_TableName";
            txt_TableName.PasswordChar = '\0';
            txt_TableName.PlaceholderForeColor = Color.White;
            txt_TableName.PlaceholderText = "";
            txt_TableName.SelectedText = "";
            txt_TableName.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txt_TableName.Size = new Size(305, 59);
            txt_TableName.TabIndex = 39;
            // 
            // lbl_NameCategory
            // 
            lbl_NameCategory.AutoSize = true;
            lbl_NameCategory.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NameCategory.ForeColor = Color.Black;
            lbl_NameCategory.Location = new Point(81, 210);
            lbl_NameCategory.Margin = new Padding(4, 0, 4, 0);
            lbl_NameCategory.Name = "lbl_NameCategory";
            lbl_NameCategory.Size = new Size(156, 37);
            lbl_NameCategory.TabIndex = 35;
            lbl_NameCategory.Text = "Tên Bàn: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(86, 336);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(181, 37);
            label1.TabIndex = 36;
            label1.Text = "Trạng thái: ";
            // 
            // txt_idtable
            // 
            txt_idtable.Animated = true;
            txt_idtable.AutoRoundedCorners = true;
            txt_idtable.BackColor = Color.Transparent;
            txt_idtable.BorderColor = Color.DarkCyan;
            txt_idtable.BorderRadius = 28;
            txt_idtable.BorderThickness = 3;
            txt_idtable.Cursor = Cursors.IBeam;
            txt_idtable.CustomizableEdges = customizableEdges15;
            txt_idtable.DefaultText = "";
            txt_idtable.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_idtable.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_idtable.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_idtable.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_idtable.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_idtable.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txt_idtable.ForeColor = Color.Black;
            txt_idtable.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_idtable.Location = new Point(81, 122);
            txt_idtable.Margin = new Padding(13, 15, 13, 15);
            txt_idtable.Name = "txt_idtable";
            txt_idtable.PasswordChar = '\0';
            txt_idtable.PlaceholderForeColor = Color.White;
            txt_idtable.PlaceholderText = "";
            txt_idtable.SelectedText = "";
            txt_idtable.ShadowDecoration.CustomizableEdges = customizableEdges16;
            txt_idtable.Size = new Size(305, 59);
            txt_idtable.TabIndex = 38;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_LastCategory);
            panel1.Controls.Add(btn_PrevioursCategory);
            panel1.Controls.Add(btn_FristCategory);
            panel1.Controls.Add(btn_NextCategory);
            panel1.Location = new Point(22, 1165);
            panel1.Margin = new Padding(4, 8, 4, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(1401, 100);
            panel1.TabIndex = 40;
            // 
            // btn_LastCategory
            // 
            btn_LastCategory.BackColor = Color.DarkCyan;
            btn_LastCategory.FlatAppearance.BorderSize = 0;
            btn_LastCategory.FlatStyle = FlatStyle.Flat;
            btn_LastCategory.Image = (Image)resources.GetObject("btn_LastCategory.Image");
            btn_LastCategory.Location = new Point(937, 29);
            btn_LastCategory.Margin = new Padding(4, 8, 4, 8);
            btn_LastCategory.Name = "btn_LastCategory";
            btn_LastCategory.Size = new Size(121, 47);
            btn_LastCategory.TabIndex = 32;
            btn_LastCategory.UseVisualStyleBackColor = false;
            btn_LastCategory.Click += btn_LastCategory_Click_1;
            // 
            // btn_PrevioursCategory
            // 
            btn_PrevioursCategory.BackColor = Color.DarkTurquoise;
            btn_PrevioursCategory.FlatAppearance.BorderSize = 0;
            btn_PrevioursCategory.FlatStyle = FlatStyle.Flat;
            btn_PrevioursCategory.Image = (Image)resources.GetObject("btn_PrevioursCategory.Image");
            btn_PrevioursCategory.Location = new Point(368, 29);
            btn_PrevioursCategory.Margin = new Padding(4, 8, 4, 8);
            btn_PrevioursCategory.Name = "btn_PrevioursCategory";
            btn_PrevioursCategory.Size = new Size(121, 47);
            btn_PrevioursCategory.TabIndex = 34;
            btn_PrevioursCategory.UseVisualStyleBackColor = false;
            btn_PrevioursCategory.Click += btn_PrevioursCategory_Click_1;
            // 
            // btn_FristCategory
            // 
            btn_FristCategory.BackColor = Color.DarkCyan;
            btn_FristCategory.FlatAppearance.BorderSize = 0;
            btn_FristCategory.FlatStyle = FlatStyle.Flat;
            btn_FristCategory.Image = (Image)resources.GetObject("btn_FristCategory.Image");
            btn_FristCategory.Location = new Point(31, 29);
            btn_FristCategory.Margin = new Padding(4, 8, 4, 8);
            btn_FristCategory.Name = "btn_FristCategory";
            btn_FristCategory.Size = new Size(121, 47);
            btn_FristCategory.TabIndex = 33;
            btn_FristCategory.UseVisualStyleBackColor = false;
            btn_FristCategory.Click += btn_FristCategory_Click_1;
            // 
            // btn_NextCategory
            // 
            btn_NextCategory.BackColor = Color.DarkTurquoise;
            btn_NextCategory.FlatAppearance.BorderSize = 0;
            btn_NextCategory.FlatStyle = FlatStyle.Flat;
            btn_NextCategory.Image = (Image)resources.GetObject("btn_NextCategory.Image");
            btn_NextCategory.Location = new Point(620, 29);
            btn_NextCategory.Margin = new Padding(4, 8, 4, 8);
            btn_NextCategory.Name = "btn_NextCategory";
            btn_NextCategory.Size = new Size(121, 47);
            btn_NextCategory.TabIndex = 35;
            btn_NextCategory.UseVisualStyleBackColor = false;
            btn_NextCategory.Click += btn_NextCategory_Click_1;
            // 
            // dtgv_Table
            // 
            dtgv_Table.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            dtgv_Table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dtgv_Table.BackgroundColor = Color.Azure;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 8F);
            dataGridViewCellStyle6.ForeColor = Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dtgv_Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dtgv_Table.ColumnHeadersHeight = 40;
            dtgv_Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dtgv_Table.DefaultCellStyle = dataGridViewCellStyle7;
            dtgv_Table.GridColor = Color.FromArgb(242, 245, 250);
            dtgv_Table.Location = new Point(15, 185);
            dtgv_Table.Margin = new Padding(6, 7, 6, 7);
            dtgv_Table.Name = "dtgv_Table";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dtgv_Table.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dtgv_Table.RowHeadersVisible = false;
            dtgv_Table.RowHeadersWidth = 82;
            dtgv_Table.RowTemplate.DividerHeight = 5;
            dtgv_Table.RowTemplate.Height = 40;
            dtgv_Table.Size = new Size(1408, 956);
            dtgv_Table.TabIndex = 60;
            dtgv_Table.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dtgv_Table.ThemeStyle.AlternatingRowsStyle.Font = null;
            dtgv_Table.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dtgv_Table.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dtgv_Table.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dtgv_Table.ThemeStyle.BackColor = Color.Azure;
            dtgv_Table.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            dtgv_Table.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            dtgv_Table.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgv_Table.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 8F);
            dtgv_Table.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            dtgv_Table.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dtgv_Table.ThemeStyle.HeaderStyle.Height = 40;
            dtgv_Table.ThemeStyle.ReadOnly = false;
            dtgv_Table.ThemeStyle.RowsStyle.BackColor = Color.White;
            dtgv_Table.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgv_Table.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10.5F);
            dtgv_Table.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dtgv_Table.ThemeStyle.RowsStyle.Height = 40;
            dtgv_Table.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 0, 192);
            dtgv_Table.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // AdminTable
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 245, 250);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1986, 1282);
            Controls.Add(dtgv_Table);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Margin = new Padding(4, 8, 4, 8);
            Name = "AdminTable";
            Text = "AdminTable";
            Load += AdminTable_Load;
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_Table).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btn_ViewTable;
        private System.Windows.Forms.Button btn_EditTable;
        private System.Windows.Forms.Button btn_SearchTable;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2TextBox txt_SearchTableName;
        private Button btn_DeleteTable;
        private Button btn_AddTable;
        private Panel panel4;
        private Guna.UI2.WinForms.Guna2ComboBox cb_TableStatus;
        private Label lbl_CategoryID;
        private Guna.UI2.WinForms.Guna2TextBox txt_TableName;
        private Label lbl_NameCategory;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_idtable;
        private Panel panel1;
        private Button btn_LastCategory;
        private Button btn_PrevioursCategory;
        private Button btn_FristCategory;
        private Button btn_NextCategory;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_Table;
    }
}
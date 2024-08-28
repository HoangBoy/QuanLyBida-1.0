namespace QuanLyBanBida
{
    partial class AdminCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCategory));
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
            panel1 = new Panel();
            btn_LastCategory = new Button();
            btn_PrevioursCategory = new Button();
            btn_FristCategory = new Button();
            btn_NextCategory = new Button();
            panel6 = new Panel();
            txt_SearchCategoryName = new Guna.UI2.WinForms.Guna2TextBox();
            btn_SearchCategory = new Button();
            panel4 = new Panel();
            txt_NameCategory = new Guna.UI2.WinForms.Guna2TextBox();
            txt_idCategory = new Guna.UI2.WinForms.Guna2TextBox();
            lbl_NameCategory = new Label();
            lbl_CategoryID = new Label();
            panel5 = new Panel();
            btn_ViewCategory = new Button();
            btn_EditCategory = new Button();
            btn_DeleteCategory = new Button();
            btn_AddCategory = new Button();
            dtgv_Category = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_Category).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_LastCategory);
            panel1.Controls.Add(btn_PrevioursCategory);
            panel1.Controls.Add(btn_FristCategory);
            panel1.Controls.Add(btn_NextCategory);
            panel1.Location = new Point(22, 1288);
            panel1.Margin = new Padding(4, 8, 4, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(1380, 111);
            panel1.TabIndex = 12;
            // 
            // btn_LastCategory
            // 
            btn_LastCategory.BackColor = Color.DarkCyan;
            btn_LastCategory.FlatAppearance.BorderSize = 0;
            btn_LastCategory.FlatStyle = FlatStyle.Flat;
            btn_LastCategory.Image = (Image)resources.GetObject("btn_LastCategory.Image");
            btn_LastCategory.Location = new Point(1175, 29);
            btn_LastCategory.Margin = new Padding(4, 8, 4, 8);
            btn_LastCategory.Name = "btn_LastCategory";
            btn_LastCategory.Size = new Size(121, 47);
            btn_LastCategory.TabIndex = 32;
            btn_LastCategory.UseVisualStyleBackColor = false;
            btn_LastCategory.Click += btn_LastCategory_Click;
            // 
            // btn_PrevioursCategory
            // 
            btn_PrevioursCategory.BackColor = Color.DarkCyan;
            btn_PrevioursCategory.FlatAppearance.BorderSize = 0;
            btn_PrevioursCategory.FlatStyle = FlatStyle.Flat;
            btn_PrevioursCategory.Image = (Image)resources.GetObject("btn_PrevioursCategory.Image");
            btn_PrevioursCategory.Location = new Point(470, 29);
            btn_PrevioursCategory.Margin = new Padding(4, 8, 4, 8);
            btn_PrevioursCategory.Name = "btn_PrevioursCategory";
            btn_PrevioursCategory.Size = new Size(121, 47);
            btn_PrevioursCategory.TabIndex = 34;
            btn_PrevioursCategory.UseVisualStyleBackColor = false;
            btn_PrevioursCategory.Click += btn_PrevioursCategory_Click;
            // 
            // btn_FristCategory
            // 
            btn_FristCategory.BackColor = Color.DarkCyan;
            btn_FristCategory.FlatAppearance.BorderSize = 0;
            btn_FristCategory.FlatStyle = FlatStyle.Flat;
            btn_FristCategory.Image = (Image)resources.GetObject("btn_FristCategory.Image");
            btn_FristCategory.Location = new Point(4, 29);
            btn_FristCategory.Margin = new Padding(4, 8, 4, 8);
            btn_FristCategory.Name = "btn_FristCategory";
            btn_FristCategory.Size = new Size(121, 47);
            btn_FristCategory.TabIndex = 33;
            btn_FristCategory.UseVisualStyleBackColor = false;
            btn_FristCategory.Click += btn_FristCategory_Click;
            // 
            // btn_NextCategory
            // 
            btn_NextCategory.BackColor = Color.DarkCyan;
            btn_NextCategory.FlatAppearance.BorderSize = 0;
            btn_NextCategory.FlatStyle = FlatStyle.Flat;
            btn_NextCategory.Image = (Image)resources.GetObject("btn_NextCategory.Image");
            btn_NextCategory.Location = new Point(711, 29);
            btn_NextCategory.Margin = new Padding(4, 8, 4, 8);
            btn_NextCategory.Name = "btn_NextCategory";
            btn_NextCategory.Size = new Size(121, 47);
            btn_NextCategory.TabIndex = 35;
            btn_NextCategory.UseVisualStyleBackColor = false;
            btn_NextCategory.Click += btn_NextCategory_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Azure;
            panel6.Controls.Add(txt_SearchCategoryName);
            panel6.Controls.Add(btn_SearchCategory);
            panel6.Location = new Point(22, 29);
            panel6.Margin = new Padding(4, 8, 4, 8);
            panel6.Name = "panel6";
            panel6.Size = new Size(1992, 141);
            panel6.TabIndex = 11;
            // 
            // txt_SearchCategoryName
            // 
            txt_SearchCategoryName.Animated = true;
            txt_SearchCategoryName.AutoRoundedCorners = true;
            txt_SearchCategoryName.BorderColor = Color.Black;
            txt_SearchCategoryName.BorderRadius = 35;
            txt_SearchCategoryName.Cursor = Cursors.IBeam;
            txt_SearchCategoryName.CustomizableEdges = customizableEdges1;
            txt_SearchCategoryName.DefaultText = "";
            txt_SearchCategoryName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_SearchCategoryName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_SearchCategoryName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_SearchCategoryName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_SearchCategoryName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_SearchCategoryName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txt_SearchCategoryName.ForeColor = Color.Black;
            txt_SearchCategoryName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_SearchCategoryName.Location = new Point(47, 34);
            txt_SearchCategoryName.Margin = new Padding(13, 15, 13, 15);
            txt_SearchCategoryName.Name = "txt_SearchCategoryName";
            txt_SearchCategoryName.PasswordChar = '\0';
            txt_SearchCategoryName.PlaceholderForeColor = Color.White;
            txt_SearchCategoryName.PlaceholderText = "";
            txt_SearchCategoryName.SelectedText = "";
            txt_SearchCategoryName.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txt_SearchCategoryName.Size = new Size(1552, 72);
            txt_SearchCategoryName.TabIndex = 28;
            // 
            // btn_SearchCategory
            // 
            btn_SearchCategory.BackColor = Color.DarkGreen;
            btn_SearchCategory.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_SearchCategory.ForeColor = Color.White;
            btn_SearchCategory.Location = new Point(1700, 32);
            btn_SearchCategory.Margin = new Padding(4, 8, 4, 8);
            btn_SearchCategory.Name = "btn_SearchCategory";
            btn_SearchCategory.Size = new Size(195, 74);
            btn_SearchCategory.TabIndex = 5;
            btn_SearchCategory.Text = "Tìm kiếm";
            btn_SearchCategory.UseVisualStyleBackColor = false;
            btn_SearchCategory.Click += btn_SearchCategory_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(txt_NameCategory);
            panel4.Controls.Add(txt_idCategory);
            panel4.Controls.Add(lbl_NameCategory);
            panel4.Controls.Add(lbl_CategoryID);
            panel4.Location = new Point(1447, 225);
            panel4.Margin = new Padding(4, 8, 4, 8);
            panel4.Name = "panel4";
            panel4.Size = new Size(555, 290);
            panel4.TabIndex = 10;
            // 
            // txt_NameCategory
            // 
            txt_NameCategory.Animated = true;
            txt_NameCategory.AutoRoundedCorners = true;
            txt_NameCategory.BorderColor = Color.DarkCyan;
            txt_NameCategory.BorderRadius = 28;
            txt_NameCategory.BorderThickness = 3;
            txt_NameCategory.Cursor = Cursors.IBeam;
            txt_NameCategory.CustomizableEdges = customizableEdges3;
            txt_NameCategory.DefaultText = "";
            txt_NameCategory.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_NameCategory.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_NameCategory.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_NameCategory.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_NameCategory.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_NameCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txt_NameCategory.ForeColor = Color.Black;
            txt_NameCategory.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_NameCategory.Location = new Point(235, 165);
            txt_NameCategory.Margin = new Padding(13, 15, 13, 15);
            txt_NameCategory.Name = "txt_NameCategory";
            txt_NameCategory.PasswordChar = '\0';
            txt_NameCategory.PlaceholderForeColor = Color.Black;
            txt_NameCategory.PlaceholderText = "";
            txt_NameCategory.SelectedText = "";
            txt_NameCategory.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txt_NameCategory.Size = new Size(284, 59);
            txt_NameCategory.TabIndex = 14;
            // 
            // txt_idCategory
            // 
            txt_idCategory.Animated = true;
            txt_idCategory.AutoRoundedCorners = true;
            txt_idCategory.BorderColor = Color.DarkCyan;
            txt_idCategory.BorderRadius = 28;
            txt_idCategory.BorderThickness = 3;
            txt_idCategory.Cursor = Cursors.IBeam;
            txt_idCategory.CustomizableEdges = customizableEdges5;
            txt_idCategory.DefaultText = "";
            txt_idCategory.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_idCategory.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_idCategory.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_idCategory.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_idCategory.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_idCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txt_idCategory.ForeColor = Color.Black;
            txt_idCategory.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_idCategory.Location = new Point(235, 33);
            txt_idCategory.Margin = new Padding(13, 15, 13, 15);
            txt_idCategory.Name = "txt_idCategory";
            txt_idCategory.PasswordChar = '\0';
            txt_idCategory.PlaceholderForeColor = Color.Black;
            txt_idCategory.PlaceholderText = "";
            txt_idCategory.SelectedText = "";
            txt_idCategory.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txt_idCategory.Size = new Size(284, 59);
            txt_idCategory.TabIndex = 13;
            // 
            // lbl_NameCategory
            // 
            lbl_NameCategory.AutoSize = true;
            lbl_NameCategory.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NameCategory.ForeColor = Color.Black;
            lbl_NameCategory.Location = new Point(31, 178);
            lbl_NameCategory.Margin = new Padding(4, 0, 4, 0);
            lbl_NameCategory.Name = "lbl_NameCategory";
            lbl_NameCategory.Size = new Size(173, 37);
            lbl_NameCategory.TabIndex = 2;
            lbl_NameCategory.Text = "Danh mục:";
            // 
            // lbl_CategoryID
            // 
            lbl_CategoryID.AutoSize = true;
            lbl_CategoryID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CategoryID.ForeColor = Color.Black;
            lbl_CategoryID.Location = new Point(138, 44);
            lbl_CategoryID.Margin = new Padding(4, 0, 4, 0);
            lbl_CategoryID.Name = "lbl_CategoryID";
            lbl_CategoryID.Size = new Size(66, 37);
            lbl_CategoryID.TabIndex = 1;
            lbl_CategoryID.Text = "ID: ";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(btn_ViewCategory);
            panel5.Controls.Add(btn_EditCategory);
            panel5.Controls.Add(btn_DeleteCategory);
            panel5.Controls.Add(btn_AddCategory);
            panel5.Location = new Point(1447, 567);
            panel5.Margin = new Padding(4, 8, 4, 8);
            panel5.Name = "panel5";
            panel5.Size = new Size(555, 433);
            panel5.TabIndex = 9;
            // 
            // btn_ViewCategory
            // 
            btn_ViewCategory.BackColor = Color.FromArgb(0, 192, 192);
            btn_ViewCategory.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ViewCategory.ForeColor = Color.White;
            btn_ViewCategory.Location = new Point(338, 231);
            btn_ViewCategory.Margin = new Padding(4, 8, 4, 8);
            btn_ViewCategory.Name = "btn_ViewCategory";
            btn_ViewCategory.Size = new Size(121, 106);
            btn_ViewCategory.TabIndex = 4;
            btn_ViewCategory.Text = "Xem";
            btn_ViewCategory.UseVisualStyleBackColor = false;
            btn_ViewCategory.Click += btn_ViewCategory_Click;
            // 
            // btn_EditCategory
            // 
            btn_EditCategory.BackColor = Color.FromArgb(192, 192, 0);
            btn_EditCategory.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_EditCategory.ForeColor = Color.White;
            btn_EditCategory.Location = new Point(126, 231);
            btn_EditCategory.Margin = new Padding(4, 8, 4, 8);
            btn_EditCategory.Name = "btn_EditCategory";
            btn_EditCategory.Size = new Size(121, 106);
            btn_EditCategory.TabIndex = 3;
            btn_EditCategory.Text = "Sửa";
            btn_EditCategory.UseVisualStyleBackColor = false;
            btn_EditCategory.Click += btn_EditCategory_Click;
            // 
            // btn_DeleteCategory
            // 
            btn_DeleteCategory.BackColor = Color.FromArgb(192, 0, 0);
            btn_DeleteCategory.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_DeleteCategory.ForeColor = Color.White;
            btn_DeleteCategory.Location = new Point(338, 80);
            btn_DeleteCategory.Margin = new Padding(4, 8, 4, 8);
            btn_DeleteCategory.Name = "btn_DeleteCategory";
            btn_DeleteCategory.Size = new Size(121, 106);
            btn_DeleteCategory.TabIndex = 2;
            btn_DeleteCategory.Text = "Xóa";
            btn_DeleteCategory.UseVisualStyleBackColor = false;
            btn_DeleteCategory.Click += btn_DeleteCategory_Click;
            // 
            // btn_AddCategory
            // 
            btn_AddCategory.BackColor = Color.SeaGreen;
            btn_AddCategory.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AddCategory.ForeColor = Color.White;
            btn_AddCategory.Location = new Point(126, 80);
            btn_AddCategory.Margin = new Padding(4, 8, 4, 8);
            btn_AddCategory.Name = "btn_AddCategory";
            btn_AddCategory.Size = new Size(121, 106);
            btn_AddCategory.TabIndex = 1;
            btn_AddCategory.Text = "Thêm";
            btn_AddCategory.UseVisualStyleBackColor = false;
            btn_AddCategory.Click += btn_AddCategory_Click;
            // 
            // dtgv_Category
            // 
            dtgv_Category.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dtgv_Category.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_Category.BackgroundColor = Color.Azure;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8F);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgv_Category.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgv_Category.ColumnHeadersHeight = 40;
            dtgv_Category.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtgv_Category.DefaultCellStyle = dataGridViewCellStyle3;
            dtgv_Category.GridColor = Color.FromArgb(242, 245, 250);
            dtgv_Category.Location = new Point(26, 225);
            dtgv_Category.Margin = new Padding(6, 7, 6, 7);
            dtgv_Category.Name = "dtgv_Category";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtgv_Category.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtgv_Category.RowHeadersVisible = false;
            dtgv_Category.RowHeadersWidth = 82;
            dtgv_Category.RowTemplate.DividerHeight = 5;
            dtgv_Category.RowTemplate.Height = 40;
            dtgv_Category.Size = new Size(1376, 1012);
            dtgv_Category.TabIndex = 62;
            dtgv_Category.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dtgv_Category.ThemeStyle.AlternatingRowsStyle.Font = null;
            dtgv_Category.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dtgv_Category.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dtgv_Category.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dtgv_Category.ThemeStyle.BackColor = Color.Azure;
            dtgv_Category.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            dtgv_Category.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            dtgv_Category.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgv_Category.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 8F);
            dtgv_Category.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            dtgv_Category.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dtgv_Category.ThemeStyle.HeaderStyle.Height = 40;
            dtgv_Category.ThemeStyle.ReadOnly = false;
            dtgv_Category.ThemeStyle.RowsStyle.BackColor = Color.White;
            dtgv_Category.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgv_Category.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10.5F);
            dtgv_Category.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dtgv_Category.ThemeStyle.RowsStyle.Height = 40;
            dtgv_Category.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 0, 192);
            dtgv_Category.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // AdminCategory
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 245, 250);
            ClientSize = new Size(2044, 1431);
            Controls.Add(dtgv_Category);
            Controls.Add(panel1);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Margin = new Padding(4, 8, 4, 8);
            Name = "AdminCategory";
            Text = "Danh Mục";
            Load += AdminCategory_Load;
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_Category).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_SearchCategory;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_ViewCategory;
        private System.Windows.Forms.Button btn_EditCategory;
        private System.Windows.Forms.Button btn_DeleteCategory;
        private System.Windows.Forms.Button btn_AddCategory;
        private System.Windows.Forms.Label lbl_CategoryID;
        private System.Windows.Forms.Label lbl_NameCategory;
        private Guna.UI2.WinForms.Guna2TextBox txt_idCategory;
        private Guna.UI2.WinForms.Guna2TextBox txt_NameCategory;
        private Guna.UI2.WinForms.Guna2TextBox txt_SearchCategoryName;
        private System.Windows.Forms.Button btn_LastCategory;
        private System.Windows.Forms.Button btn_PrevioursCategory;
        private System.Windows.Forms.Button btn_FristCategory;
        private System.Windows.Forms.Button btn_NextCategory;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_Category;
      
    }
}
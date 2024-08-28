namespace QuanLyBanBida
{
    partial class AdminFood
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminFood));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btn_ViewFood = new Button();
            btn_EditFood = new Button();
            panel6 = new Panel();
            txt_SearchFoodName = new Guna.UI2.WinForms.Guna2TextBox();
            btn_SearchFood = new Button();
            panel4 = new Panel();
            panel10 = new Panel();
            txt_Price = new Guna.UI2.WinForms.Guna2TextBox();
            lbl_FoodPrice = new Label();
            panel8 = new Panel();
            txt_NameFood = new Guna.UI2.WinForms.Guna2TextBox();
            lbl_NameFood = new Label();
            panel9 = new Panel();
            cb_Category = new Guna.UI2.WinForms.Guna2ComboBox();
            lbl_Category = new Label();
            panel1 = new Panel();
            btn_LastFood = new Button();
            btn_PrevioursFood = new Button();
            btn_NextFood = new Button();
            btn_FristFood = new Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel5 = new Panel();
            btn_DeleteFood = new Button();
            btn_AddFood = new Button();
            panel7 = new Panel();
            txt_idFood = new Guna.UI2.WinForms.Guna2TextBox();
            lbl_FoodID = new Label();
            dtgv_Food = new Guna.UI2.WinForms.Guna2DataGridView();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel10.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_Food).BeginInit();
            SuspendLayout();
            // 
            // btn_ViewFood
            // 
            btn_ViewFood.BackColor = Color.FromArgb(0, 192, 192);
            btn_ViewFood.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ViewFood.ForeColor = Color.White;
            btn_ViewFood.Location = new Point(346, 260);
            btn_ViewFood.Margin = new Padding(4, 8, 4, 8);
            btn_ViewFood.Name = "btn_ViewFood";
            btn_ViewFood.Size = new Size(121, 106);
            btn_ViewFood.TabIndex = 4;
            btn_ViewFood.Text = "Xem";
            btn_ViewFood.UseVisualStyleBackColor = false;
            btn_ViewFood.Click += btn_ViewFood_Click;
            // 
            // btn_EditFood
            // 
            btn_EditFood.BackColor = Color.FromArgb(192, 192, 0);
            btn_EditFood.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_EditFood.ForeColor = Color.White;
            btn_EditFood.Location = new Point(118, 260);
            btn_EditFood.Margin = new Padding(4, 8, 4, 8);
            btn_EditFood.Name = "btn_EditFood";
            btn_EditFood.Size = new Size(121, 106);
            btn_EditFood.TabIndex = 3;
            btn_EditFood.Text = "Sửa";
            btn_EditFood.UseVisualStyleBackColor = false;
            btn_EditFood.Click += btn_EditFood_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Azure;
            panel6.Controls.Add(txt_SearchFoodName);
            panel6.Controls.Add(btn_SearchFood);
            panel6.Location = new Point(36, 17);
            panel6.Margin = new Padding(4, 8, 4, 8);
            panel6.Name = "panel6";
            panel6.Size = new Size(1947, 147);
            panel6.TabIndex = 6;
            // 
            // txt_SearchFoodName
            // 
            txt_SearchFoodName.Animated = true;
            txt_SearchFoodName.AutoRoundedCorners = true;
            txt_SearchFoodName.BackColor = Color.Transparent;
            txt_SearchFoodName.BorderColor = Color.Transparent;
            txt_SearchFoodName.BorderRadius = 39;
            txt_SearchFoodName.Cursor = Cursors.IBeam;
            txt_SearchFoodName.CustomizableEdges = customizableEdges1;
            txt_SearchFoodName.DefaultText = "";
            txt_SearchFoodName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_SearchFoodName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_SearchFoodName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_SearchFoodName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_SearchFoodName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_SearchFoodName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txt_SearchFoodName.ForeColor = Color.Black;
            txt_SearchFoodName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_SearchFoodName.Location = new Point(63, 29);
            txt_SearchFoodName.Margin = new Padding(13, 15, 13, 15);
            txt_SearchFoodName.Name = "txt_SearchFoodName";
            txt_SearchFoodName.PasswordChar = '\0';
            txt_SearchFoodName.PlaceholderForeColor = Color.White;
            txt_SearchFoodName.PlaceholderText = "";
            txt_SearchFoodName.SelectedText = "";
            txt_SearchFoodName.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txt_SearchFoodName.Size = new Size(1491, 81);
            txt_SearchFoodName.TabIndex = 29;
            // 
            // btn_SearchFood
            // 
            btn_SearchFood.BackColor = Color.SeaGreen;
            btn_SearchFood.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_SearchFood.ForeColor = Color.White;
            btn_SearchFood.Location = new Point(1603, 29);
            btn_SearchFood.Margin = new Padding(4, 8, 4, 8);
            btn_SearchFood.Name = "btn_SearchFood";
            btn_SearchFood.Size = new Size(204, 81);
            btn_SearchFood.TabIndex = 5;
            btn_SearchFood.Text = "Tìm kiếm";
            btn_SearchFood.UseVisualStyleBackColor = false;
            btn_SearchFood.Click += btn_SearchFood_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel10);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(panel9);
            panel4.Location = new Point(1377, 246);
            panel4.Margin = new Padding(4, 8, 4, 8);
            panel4.Name = "panel4";
            panel4.Size = new Size(587, 560);
            panel4.TabIndex = 5;
            // 
            // panel10
            // 
            panel10.Controls.Add(txt_Price);
            panel10.Controls.Add(lbl_FoodPrice);
            panel10.Location = new Point(6, 335);
            panel10.Margin = new Padding(4, 8, 4, 8);
            panel10.Name = "panel10";
            panel10.Size = new Size(577, 83);
            panel10.TabIndex = 8;
            // 
            // txt_Price
            // 
            txt_Price.Animated = true;
            txt_Price.AutoRoundedCorners = true;
            txt_Price.BackColor = Color.Transparent;
            txt_Price.BorderColor = Color.DarkCyan;
            txt_Price.BorderRadius = 28;
            txt_Price.BorderThickness = 3;
            txt_Price.Cursor = Cursors.IBeam;
            txt_Price.CustomizableEdges = customizableEdges3;
            txt_Price.DefaultText = "";
            txt_Price.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_Price.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_Price.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_Price.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_Price.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_Price.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txt_Price.ForeColor = Color.Black;
            txt_Price.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_Price.Location = new Point(260, 9);
            txt_Price.Margin = new Padding(13, 15, 13, 15);
            txt_Price.Name = "txt_Price";
            txt_Price.PasswordChar = '\0';
            txt_Price.PlaceholderForeColor = Color.Black;
            txt_Price.PlaceholderText = "";
            txt_Price.SelectedText = "";
            txt_Price.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txt_Price.Size = new Size(314, 59);
            txt_Price.TabIndex = 35;
            // 
            // lbl_FoodPrice
            // 
            lbl_FoodPrice.AutoSize = true;
            lbl_FoodPrice.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_FoodPrice.ForeColor = Color.Black;
            lbl_FoodPrice.Location = new Point(118, 23);
            lbl_FoodPrice.Margin = new Padding(4, 0, 4, 0);
            lbl_FoodPrice.Name = "lbl_FoodPrice";
            lbl_FoodPrice.Size = new Size(77, 36);
            lbl_FoodPrice.TabIndex = 34;
            lbl_FoodPrice.Text = "Giá: ";
            // 
            // panel8
            // 
            panel8.Controls.Add(txt_NameFood);
            panel8.Controls.Add(lbl_NameFood);
            panel8.Location = new Point(4, 107);
            panel8.Margin = new Padding(4, 8, 4, 8);
            panel8.Name = "panel8";
            panel8.Size = new Size(590, 77);
            panel8.TabIndex = 7;
            // 
            // txt_NameFood
            // 
            txt_NameFood.Animated = true;
            txt_NameFood.AutoRoundedCorners = true;
            txt_NameFood.BackColor = Color.Transparent;
            txt_NameFood.BorderColor = Color.DarkCyan;
            txt_NameFood.BorderRadius = 28;
            txt_NameFood.BorderThickness = 3;
            txt_NameFood.Cursor = Cursors.IBeam;
            txt_NameFood.CustomizableEdges = customizableEdges5;
            txt_NameFood.DefaultText = "";
            txt_NameFood.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_NameFood.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_NameFood.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_NameFood.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_NameFood.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_NameFood.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txt_NameFood.ForeColor = Color.Black;
            txt_NameFood.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_NameFood.Location = new Point(258, 9);
            txt_NameFood.Margin = new Padding(13, 15, 13, 15);
            txt_NameFood.Name = "txt_NameFood";
            txt_NameFood.PasswordChar = '\0';
            txt_NameFood.PlaceholderForeColor = Color.Black;
            txt_NameFood.PlaceholderText = "";
            txt_NameFood.SelectedText = "";
            txt_NameFood.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txt_NameFood.Size = new Size(314, 59);
            txt_NameFood.TabIndex = 34;
            // 
            // lbl_NameFood
            // 
            lbl_NameFood.AutoSize = true;
            lbl_NameFood.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NameFood.ForeColor = Color.Black;
            lbl_NameFood.Location = new Point(18, 23);
            lbl_NameFood.Margin = new Padding(4, 0, 4, 0);
            lbl_NameFood.Name = "lbl_NameFood";
            lbl_NameFood.Size = new Size(188, 36);
            lbl_NameFood.TabIndex = 33;
            lbl_NameFood.Text = "Tên Dịch Vụ:";
            // 
            // panel9
            // 
            panel9.Controls.Add(cb_Category);
            panel9.Controls.Add(lbl_Category);
            panel9.Location = new Point(4, 214);
            panel9.Margin = new Padding(4, 8, 4, 8);
            panel9.Name = "panel9";
            panel9.Size = new Size(590, 91);
            panel9.TabIndex = 6;
            // 
            // cb_Category
            // 
            cb_Category.AutoRoundedCorners = true;
            cb_Category.BackColor = Color.Transparent;
            cb_Category.BorderColor = Color.DarkCyan;
            cb_Category.BorderRadius = 17;
            cb_Category.BorderThickness = 3;
            cb_Category.CustomizableEdges = customizableEdges7;
            cb_Category.DrawMode = DrawMode.OwnerDrawFixed;
            cb_Category.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Category.FocusedColor = Color.FromArgb(94, 148, 255);
            cb_Category.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cb_Category.Font = new Font("Segoe UI", 10F);
            cb_Category.ForeColor = Color.Black;
            cb_Category.ItemHeight = 30;
            cb_Category.Items.AddRange(new object[] { "1", "2", "3" });
            cb_Category.Location = new Point(256, 27);
            cb_Category.Margin = new Padding(4, 8, 4, 8);
            cb_Category.Name = "cb_Category";
            cb_Category.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cb_Category.Size = new Size(309, 36);
            cb_Category.TabIndex = 10;
            // 
            // lbl_Category
            // 
            lbl_Category.AutoSize = true;
            lbl_Category.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Category.ForeColor = Color.Black;
            lbl_Category.Location = new Point(37, 27);
            lbl_Category.Margin = new Padding(4, 0, 4, 0);
            lbl_Category.Name = "lbl_Category";
            lbl_Category.Size = new Size(167, 36);
            lbl_Category.TabIndex = 9;
            lbl_Category.Text = "Danh Mục: ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_LastFood);
            panel1.Controls.Add(btn_PrevioursFood);
            panel1.Controls.Add(btn_NextFood);
            panel1.Controls.Add(btn_FristFood);
            panel1.Location = new Point(17, 1199);
            panel1.Margin = new Padding(4, 8, 4, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(1307, 106);
            panel1.TabIndex = 7;
            // 
            // btn_LastFood
            // 
            btn_LastFood.BackColor = Color.DarkGreen;
            btn_LastFood.FlatAppearance.BorderSize = 0;
            btn_LastFood.FlatStyle = FlatStyle.Flat;
            btn_LastFood.Image = (Image)resources.GetObject("btn_LastFood.Image");
            btn_LastFood.Location = new Point(1041, 29);
            btn_LastFood.Margin = new Padding(4, 8, 4, 8);
            btn_LastFood.Name = "btn_LastFood";
            btn_LastFood.Size = new Size(121, 47);
            btn_LastFood.TabIndex = 28;
            btn_LastFood.UseVisualStyleBackColor = false;
            btn_LastFood.Click += btn_LastFood_Click;
            // 
            // btn_PrevioursFood
            // 
            btn_PrevioursFood.BackColor = Color.DarkGreen;
            btn_PrevioursFood.FlatAppearance.BorderSize = 0;
            btn_PrevioursFood.FlatStyle = FlatStyle.Flat;
            btn_PrevioursFood.Image = (Image)resources.GetObject("btn_PrevioursFood.Image");
            btn_PrevioursFood.Location = new Point(392, 29);
            btn_PrevioursFood.Margin = new Padding(4, 8, 4, 8);
            btn_PrevioursFood.Name = "btn_PrevioursFood";
            btn_PrevioursFood.Size = new Size(121, 47);
            btn_PrevioursFood.TabIndex = 30;
            btn_PrevioursFood.UseVisualStyleBackColor = false;
            btn_PrevioursFood.Click += btn_PrevioursFood_Click;
            // 
            // btn_NextFood
            // 
            btn_NextFood.BackColor = Color.DarkGreen;
            btn_NextFood.BackgroundImage = (Image)resources.GetObject("btn_NextFood.BackgroundImage");
            btn_NextFood.FlatAppearance.BorderSize = 0;
            btn_NextFood.FlatStyle = FlatStyle.Flat;
            btn_NextFood.Image = (Image)resources.GetObject("btn_NextFood.Image");
            btn_NextFood.Location = new Point(670, 29);
            btn_NextFood.Margin = new Padding(4, 8, 4, 8);
            btn_NextFood.Name = "btn_NextFood";
            btn_NextFood.Size = new Size(121, 47);
            btn_NextFood.TabIndex = 31;
            btn_NextFood.UseVisualStyleBackColor = false;
            btn_NextFood.Click += btn_NextFood_Click;
            // 
            // btn_FristFood
            // 
            btn_FristFood.BackColor = Color.DarkGreen;
            btn_FristFood.FlatAppearance.BorderSize = 0;
            btn_FristFood.FlatStyle = FlatStyle.Flat;
            btn_FristFood.Image = (Image)resources.GetObject("btn_FristFood.Image");
            btn_FristFood.Location = new Point(4, 29);
            btn_FristFood.Margin = new Padding(4, 8, 4, 8);
            btn_FristFood.Name = "btn_FristFood";
            btn_FristFood.Size = new Size(121, 47);
            btn_FristFood.TabIndex = 29;
            btn_FristFood.UseVisualStyleBackColor = false;
            btn_FristFood.Click += btn_FristFood_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(btn_ViewFood);
            panel5.Controls.Add(btn_DeleteFood);
            panel5.Controls.Add(btn_AddFood);
            panel5.Controls.Add(btn_EditFood);
            panel5.Location = new Point(1383, 858);
            panel5.Margin = new Padding(4, 8, 4, 8);
            panel5.Name = "panel5";
            panel5.Size = new Size(577, 447);
            panel5.TabIndex = 4;
            // 
            // btn_DeleteFood
            // 
            btn_DeleteFood.BackColor = Color.FromArgb(192, 0, 0);
            btn_DeleteFood.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_DeleteFood.ForeColor = Color.White;
            btn_DeleteFood.Location = new Point(346, 105);
            btn_DeleteFood.Margin = new Padding(4, 8, 4, 8);
            btn_DeleteFood.Name = "btn_DeleteFood";
            btn_DeleteFood.Size = new Size(121, 106);
            btn_DeleteFood.TabIndex = 4;
            btn_DeleteFood.Text = "Xóa";
            btn_DeleteFood.UseVisualStyleBackColor = false;
            btn_DeleteFood.Click += btn_DeleteFood_Click_1;
            // 
            // btn_AddFood
            // 
            btn_AddFood.BackColor = Color.FromArgb(0, 192, 0);
            btn_AddFood.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AddFood.ForeColor = Color.White;
            btn_AddFood.Location = new Point(118, 105);
            btn_AddFood.Margin = new Padding(4, 8, 4, 8);
            btn_AddFood.Name = "btn_AddFood";
            btn_AddFood.Size = new Size(121, 106);
            btn_AddFood.TabIndex = 3;
            btn_AddFood.Text = "Thêm";
            btn_AddFood.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(txt_idFood);
            panel7.Controls.Add(lbl_FoodID);
            panel7.Location = new Point(1374, 246);
            panel7.Margin = new Padding(4, 8, 4, 8);
            panel7.Name = "panel7";
            panel7.Size = new Size(590, 115);
            panel7.TabIndex = 5;
            // 
            // txt_idFood
            // 
            txt_idFood.Animated = true;
            txt_idFood.AutoRoundedCorners = true;
            txt_idFood.BackColor = Color.Transparent;
            txt_idFood.BorderColor = Color.DarkCyan;
            txt_idFood.BorderRadius = 28;
            txt_idFood.BorderThickness = 3;
            txt_idFood.Cursor = Cursors.IBeam;
            txt_idFood.CustomizableEdges = customizableEdges9;
            txt_idFood.DefaultText = "";
            txt_idFood.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_idFood.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_idFood.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_idFood.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_idFood.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_idFood.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txt_idFood.ForeColor = Color.Black;
            txt_idFood.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_idFood.Location = new Point(267, 15);
            txt_idFood.Margin = new Padding(13, 15, 13, 15);
            txt_idFood.Name = "txt_idFood";
            txt_idFood.PasswordChar = '\0';
            txt_idFood.PlaceholderForeColor = Color.Black;
            txt_idFood.PlaceholderText = "";
            txt_idFood.SelectedText = "";
            txt_idFood.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txt_idFood.Size = new Size(314, 59);
            txt_idFood.TabIndex = 33;
            // 
            // lbl_FoodID
            // 
            lbl_FoodID.AutoSize = true;
            lbl_FoodID.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_FoodID.ForeColor = Color.Black;
            lbl_FoodID.Location = new Point(126, 28);
            lbl_FoodID.Margin = new Padding(4, 0, 4, 0);
            lbl_FoodID.Name = "lbl_FoodID";
            lbl_FoodID.Size = new Size(60, 36);
            lbl_FoodID.TabIndex = 32;
            lbl_FoodID.Text = "ID: ";
            // 
            // dtgv_Food
            // 
            dtgv_Food.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dtgv_Food.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_Food.BackgroundColor = Color.Azure;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8F);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgv_Food.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgv_Food.ColumnHeadersHeight = 40;
            dtgv_Food.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtgv_Food.DefaultCellStyle = dataGridViewCellStyle3;
            dtgv_Food.GridColor = Color.FromArgb(242, 245, 250);
            dtgv_Food.Location = new Point(17, 246);
            dtgv_Food.Margin = new Padding(6, 7, 6, 7);
            dtgv_Food.Name = "dtgv_Food";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtgv_Food.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtgv_Food.RowHeadersVisible = false;
            dtgv_Food.RowHeadersWidth = 82;
            dtgv_Food.RowTemplate.DividerHeight = 5;
            dtgv_Food.RowTemplate.Height = 40;
            dtgv_Food.Size = new Size(1307, 911);
            dtgv_Food.TabIndex = 61;
            dtgv_Food.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dtgv_Food.ThemeStyle.AlternatingRowsStyle.Font = null;
            dtgv_Food.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dtgv_Food.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dtgv_Food.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dtgv_Food.ThemeStyle.BackColor = Color.Azure;
            dtgv_Food.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            dtgv_Food.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            dtgv_Food.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgv_Food.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 8F);
            dtgv_Food.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            dtgv_Food.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dtgv_Food.ThemeStyle.HeaderStyle.Height = 40;
            dtgv_Food.ThemeStyle.ReadOnly = false;
            dtgv_Food.ThemeStyle.RowsStyle.BackColor = Color.White;
            dtgv_Food.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgv_Food.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10.5F);
            dtgv_Food.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dtgv_Food.ThemeStyle.RowsStyle.Height = 40;
            dtgv_Food.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 0, 192);
            dtgv_Food.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // AdminFood
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 245, 250);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2007, 1408);
            Controls.Add(dtgv_Food);
            Controls.Add(panel7);
            Controls.Add(panel1);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Margin = new Padding(4, 8, 4, 8);
            Name = "AdminFood";
            Text = "Thức Ăn";
            Load += AdminFood_Load;
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_Food).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btn_ViewFood;
        private System.Windows.Forms.Button btn_EditFood;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_SearchFood;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txt_SearchFoodName;
        private System.Windows.Forms.Button btn_LastFood;
        private System.Windows.Forms.Button btn_NextFood;
        private System.Windows.Forms.Button btn_FristFood;
        private System.Windows.Forms.Button btn_PrevioursFood;
        private Panel panel10;
        private Guna.UI2.WinForms.Guna2TextBox txt_Price;
        private Label lbl_FoodPrice;
        private Panel panel8;
        private Guna.UI2.WinForms.Guna2TextBox txt_NameFood;
        private Label lbl_NameFood;
        private Panel panel5;
        private Button btn_DeleteFood;
        private Button btn_AddFood;
        private Panel panel9;
        private Guna.UI2.WinForms.Guna2ComboBox cb_Category;
        private Label lbl_Category;
        private Panel panel7;
        private Guna.UI2.WinForms.Guna2TextBox txt_idFood;
        private Label lbl_FoodID;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_Food;
    }
}
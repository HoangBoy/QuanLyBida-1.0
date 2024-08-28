namespace QuanLyBanBida
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelSideMenu = new Panel();
            btnExit = new Button();
            btn_Help = new Button();
            panelAccount = new Panel();
            btn_Account = new Button();
            btn_InfoAccount = new Button();
            panelAdmin = new Panel();
            TinhLuongBtn = new Button();
            btn_Customer = new Button();
            btn_acc = new Button();
            btn_Table = new Button();
            btn_Category = new Button();
            btn_ThucAn = new Button();
            btn_DoanhThu = new Button();
            btn_Admin = new Button();
            btn_Home = new Button();
            panelLogo = new Panel();
            pictureBox2 = new PictureBox();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            panelChildForm = new Panel();
            panelSideMenu.SuspendLayout();
            panelAccount.SuspendLayout();
            panelAdmin.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = Color.DarkCyan;
            panelSideMenu.Controls.Add(btnExit);
            panelSideMenu.Controls.Add(btn_Help);
            panelSideMenu.Controls.Add(panelAccount);
            panelSideMenu.Controls.Add(btn_InfoAccount);
            panelSideMenu.Controls.Add(panelAdmin);
            panelSideMenu.Controls.Add(btn_Admin);
            panelSideMenu.Controls.Add(btn_Home);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(321, 718);
            panelSideMenu.TabIndex = 0;
            panelSideMenu.Paint += panelSideMenu_Paint;
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(0, 673);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(5, 0, 0, 0);
            btnExit.Size = new Size(321, 45);
            btnExit.TabIndex = 9;
            btnExit.Text = "   Exit";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btn_Help
            // 
            btn_Help.Dock = DockStyle.Top;
            btn_Help.FlatAppearance.BorderSize = 0;
            btn_Help.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            btn_Help.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            btn_Help.FlatStyle = FlatStyle.Flat;
            btn_Help.Font = new Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Help.ForeColor = Color.White;
            btn_Help.Image = (Image)resources.GetObject("btn_Help.Image");
            btn_Help.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Help.Location = new Point(0, 541);
            btn_Help.Name = "btn_Help";
            btn_Help.Padding = new Padding(5, 0, 0, 0);
            btn_Help.Size = new Size(321, 45);
            btn_Help.TabIndex = 8;
            btn_Help.Text = "Chấm Công";
            btn_Help.TextAlign = ContentAlignment.MiddleLeft;
            btn_Help.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Help.UseVisualStyleBackColor = true;
            btn_Help.Click += btnHelp_Click;
            // 
            // panelAccount
            // 
            panelAccount.BackColor = Color.FromArgb(35, 32, 39);
            panelAccount.Controls.Add(btn_Account);
            panelAccount.Dock = DockStyle.Top;
            panelAccount.Location = new Point(0, 500);
            panelAccount.Name = "panelAccount";
            panelAccount.Size = new Size(321, 41);
            panelAccount.TabIndex = 7;
            panelAccount.Paint += panelAccount_Paint;
            // 
            // btn_Account
            // 
            btn_Account.BackColor = Color.DarkCyan;
            btn_Account.Dock = DockStyle.Top;
            btn_Account.FlatAppearance.BorderSize = 0;
            btn_Account.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 38, 46);
            btn_Account.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 38, 46);
            btn_Account.FlatStyle = FlatStyle.Flat;
            btn_Account.Font = new Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Account.ForeColor = Color.White;
            btn_Account.Location = new Point(0, 0);
            btn_Account.Name = "btn_Account";
            btn_Account.Padding = new Padding(35, 0, 0, 0);
            btn_Account.Size = new Size(321, 47);
            btn_Account.TabIndex = 0;
            btn_Account.Text = "   Tài khoản cá nhân";
            btn_Account.TextAlign = ContentAlignment.MiddleLeft;
            btn_Account.UseVisualStyleBackColor = false;
            btn_Account.Click += btn_Account_Click;
            // 
            // btn_InfoAccount
            // 
            btn_InfoAccount.Dock = DockStyle.Top;
            btn_InfoAccount.FlatAppearance.BorderSize = 0;
            btn_InfoAccount.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            btn_InfoAccount.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            btn_InfoAccount.FlatStyle = FlatStyle.Flat;
            btn_InfoAccount.Font = new Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_InfoAccount.ForeColor = Color.White;
            btn_InfoAccount.Image = (Image)resources.GetObject("btn_InfoAccount.Image");
            btn_InfoAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btn_InfoAccount.Location = new Point(0, 455);
            btn_InfoAccount.Name = "btn_InfoAccount";
            btn_InfoAccount.Padding = new Padding(5, 0, 0, 0);
            btn_InfoAccount.Size = new Size(321, 45);
            btn_InfoAccount.TabIndex = 6;
            btn_InfoAccount.Text = "   Thông tin cá nhân";
            btn_InfoAccount.TextAlign = ContentAlignment.MiddleLeft;
            btn_InfoAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_InfoAccount.UseVisualStyleBackColor = true;
            btn_InfoAccount.Click += btnTools_Click;
            // 
            // panelAdmin
            // 
            panelAdmin.BackColor = Color.FromArgb(35, 32, 39);
            panelAdmin.Controls.Add(TinhLuongBtn);
            panelAdmin.Controls.Add(btn_Customer);
            panelAdmin.Controls.Add(btn_acc);
            panelAdmin.Controls.Add(btn_Table);
            panelAdmin.Controls.Add(btn_Category);
            panelAdmin.Controls.Add(btn_ThucAn);
            panelAdmin.Controls.Add(btn_DoanhThu);
            panelAdmin.Dock = DockStyle.Top;
            panelAdmin.Location = new Point(0, 182);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(321, 273);
            panelAdmin.TabIndex = 4;
            panelAdmin.Paint += panelAdmin_Paint;
            // 
            // TinhLuongBtn
            // 
            TinhLuongBtn.BackColor = Color.DarkCyan;
            TinhLuongBtn.Dock = DockStyle.Top;
            TinhLuongBtn.FlatAppearance.BorderSize = 0;
            TinhLuongBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 38, 46);
            TinhLuongBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 38, 46);
            TinhLuongBtn.FlatStyle = FlatStyle.Flat;
            TinhLuongBtn.Font = new Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TinhLuongBtn.ForeColor = Color.White;
            TinhLuongBtn.Location = new Point(0, 240);
            TinhLuongBtn.Name = "TinhLuongBtn";
            TinhLuongBtn.Padding = new Padding(35, 0, 0, 0);
            TinhLuongBtn.Size = new Size(321, 40);
            TinhLuongBtn.TabIndex = 6;
            TinhLuongBtn.Text = "   Tính Lương NV";
            TinhLuongBtn.TextAlign = ContentAlignment.MiddleLeft;
            TinhLuongBtn.UseVisualStyleBackColor = false;
            TinhLuongBtn.Click += TinhLuongBtn_Click;
            // 
            // btn_Customer
            // 
            btn_Customer.BackColor = Color.DarkCyan;
            btn_Customer.Dock = DockStyle.Top;
            btn_Customer.FlatAppearance.BorderSize = 0;
            btn_Customer.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 38, 46);
            btn_Customer.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 38, 46);
            btn_Customer.FlatStyle = FlatStyle.Flat;
            btn_Customer.Font = new Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Customer.ForeColor = Color.White;
            btn_Customer.Location = new Point(0, 200);
            btn_Customer.Name = "btn_Customer";
            btn_Customer.Padding = new Padding(35, 0, 0, 0);
            btn_Customer.Size = new Size(321, 40);
            btn_Customer.TabIndex = 5;
            btn_Customer.Text = "   Thông Tin Khách Hàng";
            btn_Customer.TextAlign = ContentAlignment.MiddleLeft;
            btn_Customer.UseVisualStyleBackColor = false;
            btn_Customer.Click += button3_Click_1;
            // 
            // btn_acc
            // 
            btn_acc.BackColor = Color.DarkCyan;
            btn_acc.Dock = DockStyle.Top;
            btn_acc.FlatAppearance.BorderSize = 0;
            btn_acc.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 38, 46);
            btn_acc.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 38, 46);
            btn_acc.FlatStyle = FlatStyle.Flat;
            btn_acc.Font = new Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_acc.ForeColor = Color.White;
            btn_acc.Location = new Point(0, 160);
            btn_acc.Name = "btn_acc";
            btn_acc.Padding = new Padding(35, 0, 0, 0);
            btn_acc.Size = new Size(321, 40);
            btn_acc.TabIndex = 4;
            btn_acc.Text = "   Tài Khoản";
            btn_acc.TextAlign = ContentAlignment.MiddleLeft;
            btn_acc.UseVisualStyleBackColor = false;
            btn_acc.Click += btn_acc_Click;
            // 
            // btn_Table
            // 
            btn_Table.BackColor = Color.DarkCyan;
            btn_Table.Dock = DockStyle.Top;
            btn_Table.FlatAppearance.BorderSize = 0;
            btn_Table.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 38, 46);
            btn_Table.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 38, 46);
            btn_Table.FlatStyle = FlatStyle.Flat;
            btn_Table.Font = new Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Table.ForeColor = Color.White;
            btn_Table.Location = new Point(0, 120);
            btn_Table.Name = "btn_Table";
            btn_Table.Padding = new Padding(35, 0, 0, 0);
            btn_Table.Size = new Size(321, 40);
            btn_Table.TabIndex = 3;
            btn_Table.Text = "   Bàn";
            btn_Table.TextAlign = ContentAlignment.MiddleLeft;
            btn_Table.UseVisualStyleBackColor = false;
            btn_Table.Click += btn_Table_Click;
            // 
            // btn_Category
            // 
            btn_Category.BackColor = Color.DarkCyan;
            btn_Category.Dock = DockStyle.Top;
            btn_Category.FlatAppearance.BorderSize = 0;
            btn_Category.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 38, 46);
            btn_Category.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 38, 46);
            btn_Category.FlatStyle = FlatStyle.Flat;
            btn_Category.Font = new Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Category.ForeColor = Color.White;
            btn_Category.Location = new Point(0, 80);
            btn_Category.Name = "btn_Category";
            btn_Category.Padding = new Padding(35, 0, 0, 0);
            btn_Category.Size = new Size(321, 40);
            btn_Category.TabIndex = 2;
            btn_Category.Text = "   Danh Mục";
            btn_Category.TextAlign = ContentAlignment.MiddleLeft;
            btn_Category.UseVisualStyleBackColor = false;
            btn_Category.Click += btn_Category_Click;
            // 
            // btn_ThucAn
            // 
            btn_ThucAn.BackColor = Color.DarkCyan;
            btn_ThucAn.Dock = DockStyle.Top;
            btn_ThucAn.FlatAppearance.BorderSize = 0;
            btn_ThucAn.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 38, 46);
            btn_ThucAn.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 38, 46);
            btn_ThucAn.FlatStyle = FlatStyle.Flat;
            btn_ThucAn.Font = new Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ThucAn.ForeColor = Color.White;
            btn_ThucAn.Location = new Point(0, 40);
            btn_ThucAn.Name = "btn_ThucAn";
            btn_ThucAn.Padding = new Padding(35, 0, 0, 0);
            btn_ThucAn.Size = new Size(321, 40);
            btn_ThucAn.TabIndex = 1;
            btn_ThucAn.Text = "   Dụng Cụ Bida";
            btn_ThucAn.TextAlign = ContentAlignment.MiddleLeft;
            btn_ThucAn.UseVisualStyleBackColor = false;
            btn_ThucAn.Click += btn_ThucAn_Click;
            // 
            // btn_DoanhThu
            // 
            btn_DoanhThu.BackColor = Color.DarkCyan;
            btn_DoanhThu.Dock = DockStyle.Top;
            btn_DoanhThu.FlatAppearance.BorderSize = 0;
            btn_DoanhThu.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 38, 46);
            btn_DoanhThu.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 38, 46);
            btn_DoanhThu.FlatStyle = FlatStyle.Flat;
            btn_DoanhThu.Font = new Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_DoanhThu.ForeColor = Color.White;
            btn_DoanhThu.Location = new Point(0, 0);
            btn_DoanhThu.Name = "btn_DoanhThu";
            btn_DoanhThu.Padding = new Padding(35, 0, 0, 0);
            btn_DoanhThu.Size = new Size(321, 40);
            btn_DoanhThu.TabIndex = 0;
            btn_DoanhThu.Text = "   Doanh Thu";
            btn_DoanhThu.TextAlign = ContentAlignment.MiddleLeft;
            btn_DoanhThu.UseVisualStyleBackColor = false;
            btn_DoanhThu.Click += btn_DoanhThu_Click;
            // 
            // btn_Admin
            // 
            btn_Admin.Dock = DockStyle.Top;
            btn_Admin.Enabled = false;
            btn_Admin.FlatAppearance.BorderSize = 0;
            btn_Admin.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            btn_Admin.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            btn_Admin.FlatStyle = FlatStyle.Flat;
            btn_Admin.Font = new Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Admin.ForeColor = Color.White;
            btn_Admin.Image = (Image)resources.GetObject("btn_Admin.Image");
            btn_Admin.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Admin.Location = new Point(0, 137);
            btn_Admin.Name = "btn_Admin";
            btn_Admin.Padding = new Padding(5, 0, 0, 0);
            btn_Admin.Size = new Size(321, 45);
            btn_Admin.TabIndex = 3;
            btn_Admin.Text = "   Admin";
            btn_Admin.TextAlign = ContentAlignment.MiddleLeft;
            btn_Admin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Admin.UseVisualStyleBackColor = true;
            btn_Admin.Click += btnPlaylist_Click;
            // 
            // btn_Home
            // 
            btn_Home.Dock = DockStyle.Top;
            btn_Home.FlatAppearance.BorderSize = 0;
            btn_Home.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            btn_Home.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            btn_Home.FlatStyle = FlatStyle.Flat;
            btn_Home.Font = new Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Home.ForeColor = Color.White;
            btn_Home.Image = (Image)resources.GetObject("btn_Home.Image");
            btn_Home.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Home.Location = new Point(0, 92);
            btn_Home.Name = "btn_Home";
            btn_Home.Padding = new Padding(5, 0, 0, 0);
            btn_Home.Size = new Size(321, 45);
            btn_Home.TabIndex = 1;
            btn_Home.Text = "   Home";
            btn_Home.TextAlign = ContentAlignment.MiddleLeft;
            btn_Home.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Home.UseVisualStyleBackColor = true;
            btn_Home.Click += btn_Home_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox2);
            panelLogo.Controls.Add(guna2PictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(321, 92);
            panelLogo.TabIndex = 0;
            panelLogo.Paint += panelLogo_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 27);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackColor = Color.Transparent;
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.ErrorImage = (Image)resources.GetObject("guna2PictureBox1.ErrorImage");
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.InitialImage = (Image)resources.GetObject("guna2PictureBox1.InitialImage");
            guna2PictureBox1.Location = new Point(-20, 0);
            guna2PictureBox1.Margin = new Padding(6);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(365, 98);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2PictureBox1.TabIndex = 1;
            guna2PictureBox1.TabStop = false;
            guna2PictureBox1.UseTransparentBackground = true;
            guna2PictureBox1.Click += guna2PictureBox1_Click;
            // 
            // guna2ContextMenuStrip1
            // 
            guna2ContextMenuStrip1.ImageScalingSize = new Size(32, 32);
            guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            guna2ContextMenuStrip1.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            guna2ContextMenuStrip1.RenderStyle.BorderColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SeparatorColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            guna2ContextMenuStrip1.Size = new Size(61, 4);
            guna2ContextMenuStrip1.Opening += guna2ContextMenuStrip1_Opening;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.WhiteSmoke;
            panelChildForm.BackgroundImageLayout = ImageLayout.Stretch;
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(321, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(1072, 718);
            panelChildForm.TabIndex = 2;
            panelChildForm.Paint += panelChildForm_Paint;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1393, 718);
            Controls.Add(panelChildForm);
            Controls.Add(panelSideMenu);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            panelSideMenu.ResumeLayout(false);
            panelSideMenu.PerformLayout();
            panelAccount.ResumeLayout(false);
            panelAdmin.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Panel panelAccount;
        private System.Windows.Forms.Button btn_Account;
        private System.Windows.Forms.Button btn_InfoAccount;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Button btn_Table;
        private System.Windows.Forms.Button btn_Category;
        private System.Windows.Forms.Button btn_ThucAn;
        private System.Windows.Forms.Button btn_DoanhThu;
        private System.Windows.Forms.Button btn_Admin;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Button btn_acc;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button TinhLuongBtn;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Panel panelChildForm;
    }
}


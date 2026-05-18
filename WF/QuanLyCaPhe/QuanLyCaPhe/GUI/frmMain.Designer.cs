namespace QuanLyCaPhe.GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            pnTop = new Panel();
            lblUser = new Label();
            btnMenu = new Button();
            lblTitle = new Label();
            pnLeft = new Panel();
            btnLogout = new Button();
            btnBaoCao = new Button();
            pnQuanLy = new Panel();
            btnPhieuNhap = new Button();
            btnNguyenLieu = new Button();
            btnKho = new Button();
            btnKhuVuc = new Button();
            btnBan = new Button();
            btnMon = new Button();
            btnNhanVien = new Button();
            btnQuanLy = new Button();
            btnHoaDon = new Button();
            btnBanHang = new Button();
            pnMain = new Panel();
            pnTop.SuspendLayout();
            pnLeft.SuspendLayout();
            pnQuanLy.SuspendLayout();
            SuspendLayout();
            // 
            // pnTop
            // 
            pnTop.BackColor = Color.Brown;
            pnTop.Controls.Add(lblUser);
            pnTop.Controls.Add(btnMenu);
            pnTop.Controls.Add(lblTitle);
            pnTop.Dock = DockStyle.Top;
            pnTop.ForeColor = Color.White;
            pnTop.Location = new Point(0, 0);
            pnTop.Name = "pnTop";
            pnTop.Size = new Size(1166, 140);
            pnTop.TabIndex = 0;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(12, 20);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(55, 23);
            lblUser.TabIndex = 3;
            lblUser.Text = "label1";
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Transparent;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenu.ForeColor = Color.White;
            btnMenu.Location = new Point(0, 89);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(153, 48);
            btnMenu.TabIndex = 2;
            btnMenu.Text = "☰ Danh mục";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Brown;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Image = (Image)resources.GetObject("lblTitle.Image");
            lblTitle.ImageAlign = ContentAlignment.TopCenter;
            lblTitle.Location = new Point(425, -2);
            lblTitle.Name = "lblTitle";
            lblTitle.RightToLeft = RightToLeft.Yes;
            lblTitle.Size = new Size(351, 131);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "COFFEE HOANG  TUNG";
            lblTitle.TextAlign = ContentAlignment.BottomCenter;
            // 
            // pnLeft
            // 
            pnLeft.AutoScroll = true;
            pnLeft.BackColor = Color.RosyBrown;
            pnLeft.Controls.Add(btnLogout);
            pnLeft.Controls.Add(btnBaoCao);
            pnLeft.Controls.Add(pnQuanLy);
            pnLeft.Controls.Add(btnQuanLy);
            pnLeft.Controls.Add(btnHoaDon);
            pnLeft.Controls.Add(btnBanHang);
            pnLeft.Dock = DockStyle.Left;
            pnLeft.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnLeft.ForeColor = Color.White;
            pnLeft.Location = new Point(0, 140);
            pnLeft.Name = "pnLeft";
            pnLeft.Size = new Size(220, 626);
            pnLeft.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.BackgroundImage = (Image)resources.GetObject("btnLogout.BackgroundImage");
            btnLogout.BackgroundImageLayout = ImageLayout.None;
            btnLogout.Dock = DockStyle.Top;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(0, 460);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(10, 0, 0, 0);
            btnLogout.Size = new Size(220, 45);
            btnLogout.TabIndex = 3;
            btnLogout.Tag = "parent";
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnBaoCao
            // 
            btnBaoCao.BackgroundImage = (Image)resources.GetObject("btnBaoCao.BackgroundImage");
            btnBaoCao.BackgroundImageLayout = ImageLayout.None;
            btnBaoCao.Dock = DockStyle.Top;
            btnBaoCao.FlatAppearance.BorderSize = 0;
            btnBaoCao.FlatStyle = FlatStyle.Flat;
            btnBaoCao.Location = new Point(0, 415);
            btnBaoCao.Name = "btnBaoCao";
            btnBaoCao.Padding = new Padding(10, 0, 0, 0);
            btnBaoCao.Size = new Size(220, 45);
            btnBaoCao.TabIndex = 4;
            btnBaoCao.Tag = "parent";
            btnBaoCao.Text = "Báo cáo";
            btnBaoCao.UseVisualStyleBackColor = true;
            btnBaoCao.Click += btnBaoCao_Click;
            // 
            // pnQuanLy
            // 
            pnQuanLy.AutoSize = true;
            pnQuanLy.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnQuanLy.Controls.Add(btnPhieuNhap);
            pnQuanLy.Controls.Add(btnNguyenLieu);
            pnQuanLy.Controls.Add(btnKho);
            pnQuanLy.Controls.Add(btnKhuVuc);
            pnQuanLy.Controls.Add(btnBan);
            pnQuanLy.Controls.Add(btnMon);
            pnQuanLy.Controls.Add(btnNhanVien);
            pnQuanLy.Dock = DockStyle.Top;
            pnQuanLy.Location = new Point(0, 135);
            pnQuanLy.Name = "pnQuanLy";
            pnQuanLy.Padding = new Padding(60, 0, 0, 0);
            pnQuanLy.Size = new Size(220, 280);
            pnQuanLy.TabIndex = 6;
            pnQuanLy.Visible = false;
            // 
            // btnPhieuNhap
            // 
            btnPhieuNhap.BackgroundImage = (Image)resources.GetObject("btnPhieuNhap.BackgroundImage");
            btnPhieuNhap.BackgroundImageLayout = ImageLayout.None;
            btnPhieuNhap.Dock = DockStyle.Top;
            btnPhieuNhap.FlatAppearance.BorderSize = 0;
            btnPhieuNhap.FlatStyle = FlatStyle.Flat;
            btnPhieuNhap.Location = new Point(60, 240);
            btnPhieuNhap.Name = "btnPhieuNhap";
            btnPhieuNhap.Size = new Size(160, 40);
            btnPhieuNhap.TabIndex = 7;
            btnPhieuNhap.Tag = "child";
            btnPhieuNhap.Text = "Phiếu nhập";
            btnPhieuNhap.TextAlign = ContentAlignment.MiddleRight;
            btnPhieuNhap.UseVisualStyleBackColor = true;
            btnPhieuNhap.Click += btnPhieuNhap_Click;
            // 
            // btnNguyenLieu
            // 
            btnNguyenLieu.BackgroundImage = (Image)resources.GetObject("btnNguyenLieu.BackgroundImage");
            btnNguyenLieu.BackgroundImageLayout = ImageLayout.None;
            btnNguyenLieu.Dock = DockStyle.Top;
            btnNguyenLieu.FlatAppearance.BorderSize = 0;
            btnNguyenLieu.FlatStyle = FlatStyle.Flat;
            btnNguyenLieu.Location = new Point(60, 200);
            btnNguyenLieu.Name = "btnNguyenLieu";
            btnNguyenLieu.Size = new Size(160, 40);
            btnNguyenLieu.TabIndex = 5;
            btnNguyenLieu.Tag = "child";
            btnNguyenLieu.Text = "Nguyên liệu";
            btnNguyenLieu.TextAlign = ContentAlignment.MiddleRight;
            btnNguyenLieu.UseVisualStyleBackColor = true;
            btnNguyenLieu.Click += btnNguyenLieu_Click;
            // 
            // btnKho
            // 
            btnKho.BackgroundImage = (Image)resources.GetObject("btnKho.BackgroundImage");
            btnKho.BackgroundImageLayout = ImageLayout.None;
            btnKho.Dock = DockStyle.Top;
            btnKho.FlatAppearance.BorderSize = 0;
            btnKho.FlatStyle = FlatStyle.Flat;
            btnKho.Location = new Point(60, 160);
            btnKho.Name = "btnKho";
            btnKho.Size = new Size(160, 40);
            btnKho.TabIndex = 4;
            btnKho.Tag = "child";
            btnKho.Text = "Kho";
            btnKho.TextAlign = ContentAlignment.MiddleRight;
            btnKho.UseVisualStyleBackColor = true;
            btnKho.Click += btnKho_Click;
            // 
            // btnKhuVuc
            // 
            btnKhuVuc.BackgroundImage = (Image)resources.GetObject("btnKhuVuc.BackgroundImage");
            btnKhuVuc.BackgroundImageLayout = ImageLayout.None;
            btnKhuVuc.Dock = DockStyle.Top;
            btnKhuVuc.FlatAppearance.BorderSize = 0;
            btnKhuVuc.FlatStyle = FlatStyle.Flat;
            btnKhuVuc.Location = new Point(60, 120);
            btnKhuVuc.Name = "btnKhuVuc";
            btnKhuVuc.Size = new Size(160, 40);
            btnKhuVuc.TabIndex = 3;
            btnKhuVuc.Tag = "child";
            btnKhuVuc.Text = "Khu vực";
            btnKhuVuc.TextAlign = ContentAlignment.MiddleRight;
            btnKhuVuc.UseVisualStyleBackColor = true;
            btnKhuVuc.Click += btnKhuVuc_Click;
            // 
            // btnBan
            // 
            btnBan.BackgroundImage = (Image)resources.GetObject("btnBan.BackgroundImage");
            btnBan.BackgroundImageLayout = ImageLayout.None;
            btnBan.Dock = DockStyle.Top;
            btnBan.FlatAppearance.BorderSize = 0;
            btnBan.FlatStyle = FlatStyle.Flat;
            btnBan.Location = new Point(60, 80);
            btnBan.Name = "btnBan";
            btnBan.Size = new Size(160, 40);
            btnBan.TabIndex = 2;
            btnBan.Tag = "child";
            btnBan.Text = "Bàn";
            btnBan.TextAlign = ContentAlignment.MiddleRight;
            btnBan.UseVisualStyleBackColor = true;
            btnBan.Click += btnBan_Click;
            // 
            // btnMon
            // 
            btnMon.BackgroundImage = (Image)resources.GetObject("btnMon.BackgroundImage");
            btnMon.BackgroundImageLayout = ImageLayout.None;
            btnMon.Dock = DockStyle.Top;
            btnMon.FlatAppearance.BorderSize = 0;
            btnMon.FlatStyle = FlatStyle.Flat;
            btnMon.Location = new Point(60, 40);
            btnMon.Name = "btnMon";
            btnMon.Size = new Size(160, 40);
            btnMon.TabIndex = 1;
            btnMon.Tag = "child";
            btnMon.Text = "Món";
            btnMon.TextAlign = ContentAlignment.MiddleRight;
            btnMon.UseVisualStyleBackColor = true;
            btnMon.Click += btnMon_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackgroundImage = (Image)resources.GetObject("btnNhanVien.BackgroundImage");
            btnNhanVien.BackgroundImageLayout = ImageLayout.None;
            btnNhanVien.Dock = DockStyle.Top;
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Location = new Point(60, 0);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(160, 40);
            btnNhanVien.TabIndex = 0;
            btnNhanVien.Tag = "child";
            btnNhanVien.Text = "Nhân viên";
            btnNhanVien.TextAlign = ContentAlignment.MiddleRight;
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnQuanLy
            // 
            btnQuanLy.BackgroundImage = (Image)resources.GetObject("btnQuanLy.BackgroundImage");
            btnQuanLy.BackgroundImageLayout = ImageLayout.None;
            btnQuanLy.Dock = DockStyle.Top;
            btnQuanLy.FlatAppearance.BorderSize = 0;
            btnQuanLy.FlatStyle = FlatStyle.Flat;
            btnQuanLy.Location = new Point(0, 90);
            btnQuanLy.Name = "btnQuanLy";
            btnQuanLy.Padding = new Padding(10, 0, 0, 0);
            btnQuanLy.Size = new Size(220, 45);
            btnQuanLy.TabIndex = 2;
            btnQuanLy.Tag = "parent";
            btnQuanLy.Text = "Quản lý";
            btnQuanLy.UseVisualStyleBackColor = true;
            btnQuanLy.Click += btnQuanLy_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.BackgroundImage = (Image)resources.GetObject("btnHoaDon.BackgroundImage");
            btnHoaDon.BackgroundImageLayout = ImageLayout.None;
            btnHoaDon.Dock = DockStyle.Top;
            btnHoaDon.FlatAppearance.BorderSize = 0;
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.Location = new Point(0, 45);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Padding = new Padding(10, 0, 0, 0);
            btnHoaDon.Size = new Size(220, 45);
            btnHoaDon.TabIndex = 1;
            btnHoaDon.Tag = "parent";
            btnHoaDon.Text = "Hóa đơn";
            btnHoaDon.UseVisualStyleBackColor = true;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnBanHang
            // 
            btnBanHang.BackgroundImage = (Image)resources.GetObject("btnBanHang.BackgroundImage");
            btnBanHang.BackgroundImageLayout = ImageLayout.None;
            btnBanHang.Dock = DockStyle.Top;
            btnBanHang.FlatAppearance.BorderSize = 0;
            btnBanHang.FlatStyle = FlatStyle.Flat;
            btnBanHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnBanHang.Location = new Point(0, 0);
            btnBanHang.Name = "btnBanHang";
            btnBanHang.Padding = new Padding(10, 0, 0, 0);
            btnBanHang.Size = new Size(220, 45);
            btnBanHang.TabIndex = 0;
            btnBanHang.Tag = "parent";
            btnBanHang.Text = "Bán hàng";
            btnBanHang.UseVisualStyleBackColor = true;
            btnBanHang.Click += btnBanHang_Click;
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.White;
            pnMain.Location = new Point(220, 140);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(946, 620);
            pnMain.TabIndex = 2;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1166, 766);
            Controls.Add(pnMain);
            Controls.Add(pnLeft);
            Controls.Add(pnTop);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMain";
            Load += frmMain_Load;
            pnTop.ResumeLayout(false);
            pnTop.PerformLayout();
            pnLeft.ResumeLayout(false);
            pnLeft.PerformLayout();
            pnQuanLy.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnTop;
        private Panel pnLeft;
        private Label label3;
        private Label label2;
        private Panel pnMain;
        private Button btnQuanLy;
        private Button btnHoaDon;
        private Button btnBanHang;
        private Panel pnQuanLy;
        private Button btnNguyenLieu;
        private Button btnKho;
        private Button btnKhuVuc;
        private Button btnBan;
        private Button btnMon;
        private Button btnNhanVien;
        private Button btnBaoCao;
        private Button btnLogout;
        private Button btnMenu;
        private Label lblUser;
        private Label lblTitle;
        private Button btnPhieuNhap;
    }
}
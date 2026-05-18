namespace QuanLyCaPhe.GUI.QuanLy
{
    partial class frmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            panel1 = new Panel();
            cboKhuVuc = new ComboBox();
            cboChucVu = new ComboBox();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtTenNV = new TextBox();
            txtMaNV = new TextBox();
            lable2 = new Label();
            lable = new Label();
            l2 = new Label();
            label6 = new Label();
            l1 = new Label();
            l3 = new Label();
            l4 = new Label();
            label2 = new Label();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnTim = new Button();
            txtSearch = new TextBox();
            panel2 = new Panel();
            dgvNhanVien = new DataGridView();
            colMaNV = new DataGridViewTextBoxColumn();
            colTenNV = new DataGridViewTextBoxColumn();
            colSDT = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            colChucVu = new DataGridViewTextBoxColumn();
            colMaKV = new DataGridViewTextBoxColumn();
            colTenDangNhap = new DataGridViewTextBoxColumn();
            colMatKhau = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cboKhuVuc);
            panel1.Controls.Add(cboChucVu);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(txtTenDangNhap);
            panel1.Controls.Add(txtDiaChi);
            panel1.Controls.Add(txtSDT);
            panel1.Controls.Add(txtTenNV);
            panel1.Controls.Add(txtMaNV);
            panel1.Controls.Add(lable2);
            panel1.Controls.Add(lable);
            panel1.Controls.Add(l2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(l1);
            panel1.Controls.Add(l3);
            panel1.Controls.Add(l4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(925, 145);
            panel1.TabIndex = 1;
            // 
            // cboKhuVuc
            // 
            cboKhuVuc.FormattingEnabled = true;
            cboKhuVuc.Location = new Point(712, 50);
            cboKhuVuc.Name = "cboKhuVuc";
            cboKhuVuc.Size = new Size(151, 28);
            cboKhuVuc.TabIndex = 15;
            // 
            // cboChucVu
            // 
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Location = new Point(712, 12);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(151, 28);
            cboChucVu.TabIndex = 14;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(440, 90);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(125, 27);
            txtMatKhau.TabIndex = 13;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(440, 50);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(125, 27);
            txtTenDangNhap.TabIndex = 12;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(440, 16);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(125, 27);
            txtDiaChi.TabIndex = 11;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(113, 90);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(125, 27);
            txtSDT.TabIndex = 10;
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(113, 50);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(125, 27);
            txtTenNV.TabIndex = 9;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(113, 12);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(125, 27);
            txtMaNV.TabIndex = 8;
            // 
            // lable2
            // 
            lable2.AutoSize = true;
            lable2.Location = new Point(639, 57);
            lable2.Name = "lable2";
            lable2.Size = new Size(68, 20);
            lable2.TabIndex = 7;
            lable2.Text = "Khu vực :";
            // 
            // lable
            // 
            lable.AutoSize = true;
            lable.Location = new Point(639, 19);
            lable.Name = "lable";
            lable.Size = new Size(68, 20);
            lable.TabIndex = 6;
            lable.Text = "Chức vụ :";
            // 
            // l2
            // 
            l2.AutoSize = true;
            l2.Location = new Point(356, 97);
            l2.Name = "l2";
            l2.Size = new Size(77, 20);
            l2.TabIndex = 5;
            l2.Text = "Mật khẩu :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(320, 57);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 4;
            label6.Text = "Tên đăng nhập :";
            // 
            // l1
            // 
            l1.AutoSize = true;
            l1.Location = new Point(371, 23);
            l1.Name = "l1";
            l1.Size = new Size(62, 20);
            l1.TabIndex = 3;
            l1.Text = "Địa chỉ :";
            // 
            // l3
            // 
            l3.AutoSize = true;
            l3.Location = new Point(42, 97);
            l3.Name = "l3";
            l3.Size = new Size(43, 20);
            l3.TabIndex = 2;
            l3.Text = "SĐT :";
            // 
            // l4
            // 
            l4.AutoSize = true;
            l4.Location = new Point(24, 57);
            l4.Name = "l4";
            l4.Size = new Size(63, 20);
            l4.TabIndex = 1;
            l4.Text = "Tên NV :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 19);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã NV :";
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Brown;
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(603, 215);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 46);
            btnLamMoi.TabIndex = 13;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Brown;
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(471, 215);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 46);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Brown;
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(341, 215);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 46);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Brown;
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(210, 215);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 46);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnTim
            // 
            btnTim.BackgroundImage = (Image)resources.GetObject("btnTim.BackgroundImage");
            btnTim.BackgroundImageLayout = ImageLayout.Stretch;
            btnTim.Location = new Point(296, 286);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(32, 29);
            btnTim.TabIndex = 15;
            btnTim.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(25, 287);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm theo Mã NV, Tên NV, SĐT, Chức vụ";
            txtSearch.Size = new Size(265, 27);
            txtSearch.TabIndex = 14;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dgvNhanVien);
            panel2.Location = new Point(1, 320);
            panel2.Name = "panel2";
            panel2.Size = new Size(925, 250);
            panel2.TabIndex = 16;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.BackgroundColor = Color.White;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { colMaNV, colTenNV, colSDT, colDiaChi, colChucVu, colMaKV, colTenDangNhap, colMatKhau });
            dgvNhanVien.Location = new Point(-1, -1);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersVisible = false;
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(925, 250);
            dgvNhanVien.TabIndex = 0;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            // 
            // colMaNV
            // 
            colMaNV.DataPropertyName = "MaNV";
            colMaNV.HeaderText = "Mã NV";
            colMaNV.MinimumWidth = 6;
            colMaNV.Name = "colMaNV";
            colMaNV.ReadOnly = true;
            colMaNV.Width = 125;
            // 
            // colTenNV
            // 
            colTenNV.DataPropertyName = "TenNV";
            colTenNV.HeaderText = "Tên NV";
            colTenNV.MinimumWidth = 6;
            colTenNV.Name = "colTenNV";
            colTenNV.ReadOnly = true;
            colTenNV.Width = 125;
            // 
            // colSDT
            // 
            colSDT.DataPropertyName = "SDT";
            colSDT.HeaderText = "SĐT";
            colSDT.MinimumWidth = 6;
            colSDT.Name = "colSDT";
            colSDT.ReadOnly = true;
            colSDT.Width = 125;
            // 
            // colDiaChi
            // 
            colDiaChi.DataPropertyName = "DiaChi";
            colDiaChi.HeaderText = "Địa chỉ";
            colDiaChi.MinimumWidth = 6;
            colDiaChi.Name = "colDiaChi";
            colDiaChi.ReadOnly = true;
            colDiaChi.Width = 125;
            // 
            // colChucVu
            // 
            colChucVu.DataPropertyName = "ChucVu";
            colChucVu.HeaderText = "Chức vụ";
            colChucVu.MinimumWidth = 6;
            colChucVu.Name = "colChucVu";
            colChucVu.ReadOnly = true;
            colChucVu.Width = 125;
            // 
            // colMaKV
            // 
            colMaKV.DataPropertyName = "MaKV";
            colMaKV.HeaderText = "Khu vực";
            colMaKV.MinimumWidth = 6;
            colMaKV.Name = "colMaKV";
            colMaKV.ReadOnly = true;
            colMaKV.Width = 125;
            // 
            // colTenDangNhap
            // 
            colTenDangNhap.DataPropertyName = "TenDangNhap";
            colTenDangNhap.HeaderText = "Tên đăng nhập";
            colTenDangNhap.MinimumWidth = 6;
            colTenDangNhap.Name = "colTenDangNhap";
            colTenDangNhap.ReadOnly = true;
            colTenDangNhap.Width = 150;
            // 
            // colMatKhau
            // 
            colMatKhau.DataPropertyName = "MatKhau";
            colMatKhau.HeaderText = "Mật khẩu";
            colMatKhau.MinimumWidth = 6;
            colMatKhau.Name = "colMatKhau";
            colMatKhau.ReadOnly = true;
            colMatKhau.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(384, 9);
            label1.Name = "label1";
            label1.Size = new Size(182, 23);
            label1.TabIndex = 17;
            label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 573);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(btnTim);
            Controls.Add(txtSearch);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(panel1);
            Name = "frmNhanVien";
            Text = "frmNhanVien";
            Load += frmNhanVien_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnTim;
        private TextBox txtSearch;
        private Panel panel2;
        private DataGridView dgvNhanVien;
        private Label label1;
        private ComboBox cboKhuVuc;
        private ComboBox cboChucVu;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private TextBox txtDiaChi;
        private TextBox txtSDT;
        private TextBox txtTenNV;
        private TextBox txtMaNV;
        private Label lable2;
        private Label lable;
        private Label l2;
        private Label label6;
        private Label l1;
        private Label l3;
        private Label l4;
        private Label label2;
        private DataGridViewTextBoxColumn colMaNV;
        private DataGridViewTextBoxColumn colTenNV;
        private DataGridViewTextBoxColumn colSDT;
        private DataGridViewTextBoxColumn colDiaChi;
        private DataGridViewTextBoxColumn colChucVu;
        private DataGridViewTextBoxColumn colMaKV;
        private DataGridViewTextBoxColumn colTenDangNhap;
        private DataGridViewTextBoxColumn colMatKhau;
    }
}
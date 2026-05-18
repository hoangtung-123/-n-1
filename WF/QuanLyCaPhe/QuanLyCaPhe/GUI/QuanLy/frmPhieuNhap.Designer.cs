namespace QuanLyCaPhe.GUI.QuanLy
{
    partial class frmPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuNhap));
            PrintPhieuNhap = new System.Drawing.Printing.PrintDocument();
            label3 = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            label2 = new Label();
            dgvCTPN = new DataGridView();
            colMaNL = new DataGridViewTextBoxColumn();
            colTenNL = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colGiaNhap = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            txtGiaNhap = new TextBox();
            cboNguyenLieu = new ComboBox();
            btnSua = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            txtSoLuong = new TextBox();
            l1 = new Label();
            l4 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            btnInPhieu = new Button();
            btnPhieuMoi = new Button();
            btnLuu = new Button();
            cboNhanVien = new ComboBox();
            txtGhiChu = new TextBox();
            dtpNgayTao = new DateTimePicker();
            txtMaPN = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            button1 = new Button();
            txtSearchPN = new TextBox();
            label10 = new Label();
            dgvPhieuNhap = new DataGridView();
            colMaPN = new DataGridViewTextBoxColumn();
            colTenNV = new DataGridViewTextBoxColumn();
            colNgayNhap = new DataGridViewTextBoxColumn();
            colTongTien = new DataGridViewTextBoxColumn();
            lblTongTien = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCTPN).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).BeginInit();
            SuspendLayout();
            // 
            // PrintPhieuNhap
            // 
            PrintPhieuNhap.PrintPage += PrintPhieuNhap_PrintPage;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(164, 20);
            label3.TabIndex = 4;
            label3.Text = "CHI TIẾT PHIẾU NHẬP";
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 2;
            label2.Text = "THÊM NGUYÊN LIỆU";
            // 
            // dgvCTPN
            // 
            dgvCTPN.AllowUserToAddRows = false;
            dgvCTPN.AllowUserToDeleteRows = false;
            dgvCTPN.BackgroundColor = Color.White;
            dgvCTPN.ColumnHeadersHeight = 28;
            dgvCTPN.Columns.AddRange(new DataGridViewColumn[] { colMaNL, colTenNL, colSoLuong, colGiaNhap, colThanhTien });
            dgvCTPN.Location = new Point(0, 96);
            dgvCTPN.MultiSelect = false;
            dgvCTPN.Name = "dgvCTPN";
            dgvCTPN.ReadOnly = true;
            dgvCTPN.RowHeadersVisible = false;
            dgvCTPN.RowHeadersWidth = 51;
            dgvCTPN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCTPN.Size = new Size(448, 145);
            dgvCTPN.TabIndex = 12;
            dgvCTPN.CellClick += dgvCTPN_CellClick;
            // 
            // colMaNL
            // 
            colMaNL.DataPropertyName = "MaNL";
            colMaNL.HeaderText = "Mã NL";
            colMaNL.MinimumWidth = 6;
            colMaNL.Name = "colMaNL";
            colMaNL.ReadOnly = true;
            colMaNL.Width = 89;
            // 
            // colTenNL
            // 
            colTenNL.DataPropertyName = "TenNL";
            colTenNL.HeaderText = "Tên NL";
            colTenNL.MinimumWidth = 6;
            colTenNL.Name = "colTenNL";
            colTenNL.ReadOnly = true;
            colTenNL.Width = 89;
            // 
            // colSoLuong
            // 
            colSoLuong.DataPropertyName = "SoLuong";
            colSoLuong.HeaderText = "Số lượng";
            colSoLuong.MinimumWidth = 6;
            colSoLuong.Name = "colSoLuong";
            colSoLuong.ReadOnly = true;
            colSoLuong.Width = 89;
            // 
            // colGiaNhap
            // 
            colGiaNhap.DataPropertyName = "GiaNhap";
            colGiaNhap.HeaderText = "Giá nhập (VNĐ)";
            colGiaNhap.MinimumWidth = 6;
            colGiaNhap.Name = "colGiaNhap";
            colGiaNhap.ReadOnly = true;
            colGiaNhap.Width = 89;
            // 
            // colThanhTien
            // 
            colThanhTien.DataPropertyName = "ThanhTien";
            colThanhTien.HeaderText = "Thành tiền";
            colThanhTien.MinimumWidth = 6;
            colThanhTien.Name = "colThanhTien";
            colThanhTien.ReadOnly = true;
            colThanhTien.Width = 89;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtGiaNhap);
            panel2.Controls.Add(cboNguyenLieu);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(txtSoLuong);
            panel2.Controls.Add(l1);
            panel2.Controls.Add(l4);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(1, 411);
            panel2.Name = "panel2";
            panel2.Size = new Size(928, 131);
            panel2.TabIndex = 15;
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Location = new Point(689, 30);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(125, 27);
            txtGiaNhap.TabIndex = 45;
            // 
            // cboNguyenLieu
            // 
            cboNguyenLieu.FormattingEnabled = true;
            cboNguyenLieu.Location = new Point(137, 30);
            cboNguyenLieu.Name = "cboNguyenLieu";
            cboNguyenLieu.Size = new Size(151, 28);
            cboNguyenLieu.TabIndex = 44;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Brown;
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(383, 80);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 46);
            btnSua.TabIndex = 42;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Brown;
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(252, 80);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 46);
            btnThem.TabIndex = 41;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Brown;
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(513, 80);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 46);
            btnXoa.TabIndex = 43;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(404, 30);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(125, 27);
            txtSoLuong.TabIndex = 17;
            // 
            // l1
            // 
            l1.AutoSize = true;
            l1.Location = new Point(563, 37);
            l1.Name = "l1";
            l1.Size = new Size(120, 20);
            l1.TabIndex = 15;
            l1.Text = "Giá nhập (VNĐ) :";
            // 
            // l4
            // 
            l4.AutoSize = true;
            l4.Location = new Point(322, 37);
            l4.Name = "l4";
            l4.Size = new Size(76, 20);
            l4.TabIndex = 14;
            l4.Text = "Số lượng :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 38);
            label9.Name = "label9";
            label9.Size = new Size(95, 20);
            label9.TabIndex = 13;
            label9.Text = "Nguyên liệu :";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnInPhieu);
            panel1.Controls.Add(btnPhieuMoi);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(cboNhanVien);
            panel1.Controls.Add(txtGhiChu);
            panel1.Controls.Add(dtpNgayTao);
            panel1.Controls.Add(txtMaPN);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(928, 111);
            panel1.TabIndex = 12;
            // 
            // btnInPhieu
            // 
            btnInPhieu.BackColor = Color.Brown;
            btnInPhieu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnInPhieu.ForeColor = Color.White;
            btnInPhieu.Location = new Point(820, 57);
            btnInPhieu.Name = "btnInPhieu";
            btnInPhieu.Size = new Size(95, 46);
            btnInPhieu.TabIndex = 46;
            btnInPhieu.Text = "In Phiếu";
            btnInPhieu.UseVisualStyleBackColor = false;
            btnInPhieu.Click += btnInPhieu_Click;
            // 
            // btnPhieuMoi
            // 
            btnPhieuMoi.BackColor = Color.Brown;
            btnPhieuMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnPhieuMoi.ForeColor = Color.White;
            btnPhieuMoi.Location = new Point(542, 57);
            btnPhieuMoi.Name = "btnPhieuMoi";
            btnPhieuMoi.Size = new Size(107, 46);
            btnPhieuMoi.TabIndex = 47;
            btnPhieuMoi.Text = "Phiếu mới";
            btnPhieuMoi.UseVisualStyleBackColor = false;
            btnPhieuMoi.Click += btnPhieuMoi_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.Brown;
            btnLuu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(668, 56);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(114, 46);
            btnLuu.TabIndex = 45;
            btnLuu.Text = "Lưu phiếu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(359, 48);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(151, 28);
            cboNhanVien.TabIndex = 45;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(97, 48);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(125, 27);
            txtGhiChu.TabIndex = 17;
            // 
            // dtpNgayTao
            // 
            dtpNgayTao.Location = new Point(359, 5);
            dtpNgayTao.Name = "dtpNgayTao";
            dtpNgayTao.Size = new Size(181, 27);
            dtpNgayTao.TabIndex = 16;
            // 
            // txtMaPN
            // 
            txtMaPN.Location = new Point(97, 3);
            txtMaPN.Name = "txtMaPN";
            txtMaPN.Size = new Size(125, 27);
            txtMaPN.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(12, 56);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 11;
            label6.Text = "Ghi chú :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(271, 10);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 10;
            label5.Text = "Ngày tạo :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(266, 56);
            label7.Name = "label7";
            label7.Size = new Size(82, 20);
            label7.TabIndex = 9;
            label7.Text = "Nhân viên :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(17, 10);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 8;
            label8.Text = "Mã PN :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(359, 0);
            label1.Name = "label1";
            label1.Size = new Size(190, 23);
            label1.TabIndex = 11;
            label1.Text = "QUẢN LÝ PHIẾU NHẬP";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(dgvCTPN);
            panel3.Location = new Point(478, 151);
            panel3.Name = "panel3";
            panel3.Size = new Size(449, 242);
            panel3.TabIndex = 16;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(button1);
            panel4.Controls.Add(txtSearchPN);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(dgvPhieuNhap);
            panel4.Location = new Point(0, 151);
            panel4.Name = "panel4";
            panel4.Size = new Size(473, 242);
            panel4.TabIndex = 46;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(245, 50);
            button1.Name = "button1";
            button1.Size = new Size(32, 29);
            button1.TabIndex = 14;
            button1.UseVisualStyleBackColor = true;
            // 
            // txtSearchPN
            // 
            txtSearchPN.Location = new Point(14, 51);
            txtSearchPN.Multiline = true;
            txtSearchPN.Name = "txtSearchPN";
            txtSearchPN.PlaceholderText = "Tìm theo Mã PN, Mã NV,  Tên NV";
            txtSearchPN.Size = new Size(225, 27);
            txtSearchPN.TabIndex = 13;
            txtSearchPN.TextChanged += txtSearchPN_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Top;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(192, 20);
            label10.TabIndex = 4;
            label10.Text = "DANH SÁCH PHIẾU NHẬP";
            // 
            // dgvPhieuNhap
            // 
            dgvPhieuNhap.AllowUserToAddRows = false;
            dgvPhieuNhap.AllowUserToDeleteRows = false;
            dgvPhieuNhap.BackgroundColor = Color.White;
            dgvPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuNhap.Columns.AddRange(new DataGridViewColumn[] { colMaPN, colTenNV, colNgayNhap, colTongTien });
            dgvPhieuNhap.Location = new Point(-1, 96);
            dgvPhieuNhap.Name = "dgvPhieuNhap";
            dgvPhieuNhap.ReadOnly = true;
            dgvPhieuNhap.RowHeadersVisible = false;
            dgvPhieuNhap.RowHeadersWidth = 51;
            dgvPhieuNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieuNhap.Size = new Size(473, 145);
            dgvPhieuNhap.TabIndex = 12;
            dgvPhieuNhap.CellClick += dgvPhieuNhap_CellClick;
            // 
            // colMaPN
            // 
            colMaPN.DataPropertyName = "MaPN";
            colMaPN.HeaderText = "Mã PN";
            colMaPN.MinimumWidth = 6;
            colMaPN.Name = "colMaPN";
            colMaPN.ReadOnly = true;
            colMaPN.Width = 117;
            // 
            // colTenNV
            // 
            colTenNV.DataPropertyName = "TenNV";
            colTenNV.HeaderText = "Nhân viên";
            colTenNV.MinimumWidth = 6;
            colTenNV.Name = "colTenNV";
            colTenNV.ReadOnly = true;
            colTenNV.Width = 118;
            // 
            // colNgayNhap
            // 
            colNgayNhap.DataPropertyName = "NgayTao";
            colNgayNhap.HeaderText = "Ngày tạo";
            colNgayNhap.MinimumWidth = 6;
            colNgayNhap.Name = "colNgayNhap";
            colNgayNhap.ReadOnly = true;
            colNgayNhap.Width = 117;
            // 
            // colTongTien
            // 
            colTongTien.DataPropertyName = "TongTien";
            colTongTien.HeaderText = "Tổng tiền";
            colTongTien.MinimumWidth = 6;
            colTongTien.Name = "colTongTien";
            colTongTien.ReadOnly = true;
            colTongTien.Width = 117;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongTien.Location = new Point(96, 568);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(97, 23);
            lblTongTien.TabIndex = 14;
            lblTongTien.Text = "Tổng tiền :";
            // 
            // frmPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 600);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(lblTongTien);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "frmPhieuNhap";
            Text = "frmPhieuNhap";
            Load += frmPhieuNhap_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCTPN).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Drawing.Printing.PrintDocument PrintPhieuNhap;
        private Label label3;
        private PrintPreviewDialog printPreviewDialog1;
        private Label label2;
        private DataGridView dgvCTPN;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private ComboBox cboTrangThai;
        private TextBox txtDonGia;
        private TextBox txtTenMon;
        private TextBox txtMaPN;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label8;
        private TextBox txtGia;
        private TextBox txtSoLuong;
        private TextBox txtMaNL;
        private Label l1;
        private Label l4;
        private Label label9;
        private Button btnSua;
        private Button btnThem;
        private Button btnXoa;
        private Panel panel3;
        private Button btnLuu;
        private DateTimePicker dtpNgayTao;
        private ComboBox cboNguyenLieu;
        private TextBox txtGiaNhap;
        private ComboBox cboNhanVien;
        private TextBox txtGhiChu;
        private Panel panel4;
        private Label label10;
        private DataGridView dgvPhieuNhap;
        private Button btnPhieuMoi;
        private Button button1;
        private TextBox txtSearchPN;
        private Label lblTongTien;
        private DataGridViewTextBoxColumn colMaNL;
        private DataGridViewTextBoxColumn colTenNL;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colGiaNhap;
        private DataGridViewTextBoxColumn colThanhTien;
        private Button btnInPhieu;
        private DataGridViewTextBoxColumn colMaPN;
        private DataGridViewTextBoxColumn colTenNV;
        private DataGridViewTextBoxColumn colNgayNhap;
        private DataGridViewTextBoxColumn colTongTien;
    }
}
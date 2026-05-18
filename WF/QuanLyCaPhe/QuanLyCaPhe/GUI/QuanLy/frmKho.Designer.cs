namespace QuanLyCaPhe.GUI.QuanLy
{
    partial class frmKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKho));
            dgvKho = new DataGridView();
            colMaKho = new DataGridViewTextBoxColumn();
            colTenKho = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            colNgayTao = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            lblMon = new Label();
            btnTim = new Button();
            txtSearch = new TextBox();
            cboTrangThai = new ComboBox();
            btnSua = new Button();
            btnThem = new Button();
            panel1 = new Panel();
            txtTenKho = new TextBox();
            dtpNgayTao = new DateTimePicker();
            txtMaKho = new TextBox();
            l1 = new Label();
            l3 = new Label();
            l4 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnLamMoi = new Button();
            btnXoa = new Button();
            dgvChiTietKho = new DataGridView();
            colMaNL = new DataGridViewTextBoxColumn();
            colTenNL = new DataGridViewTextBoxColumn();
            colSLTon = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKho).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietKho).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKho
            // 
            dgvKho.AllowUserToAddRows = false;
            dgvKho.AllowUserToDeleteRows = false;
            dgvKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKho.BackgroundColor = Color.White;
            dgvKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKho.Columns.AddRange(new DataGridViewColumn[] { colMaKho, colTenKho, colTrangThai, colNgayTao });
            dgvKho.Location = new Point(0, 97);
            dgvKho.Name = "dgvKho";
            dgvKho.ReadOnly = true;
            dgvKho.RowHeadersVisible = false;
            dgvKho.RowHeadersWidth = 51;
            dgvKho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKho.Size = new Size(523, 271);
            dgvKho.TabIndex = 0;
            dgvKho.CellClick += dgvKho_CellClick;
            // 
            // colMaKho
            // 
            colMaKho.DataPropertyName = "MaKho";
            colMaKho.HeaderText = "Mã kho";
            colMaKho.MinimumWidth = 6;
            colMaKho.Name = "colMaKho";
            colMaKho.ReadOnly = true;
            // 
            // colTenKho
            // 
            colTenKho.DataPropertyName = "TenKho";
            colTenKho.HeaderText = "Tên kho";
            colTenKho.MinimumWidth = 6;
            colTenKho.Name = "colTenKho";
            colTenKho.ReadOnly = true;
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            // 
            // colNgayTao
            // 
            colNgayTao.DataPropertyName = "NgayTao";
            colNgayTao.HeaderText = "Ngày tạo";
            colNgayTao.MinimumWidth = 6;
            colNgayTao.Name = "colNgayTao";
            colNgayTao.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblMon);
            panel2.Controls.Add(dgvKho);
            panel2.Controls.Add(btnTim);
            panel2.Controls.Add(txtSearch);
            panel2.Location = new Point(2, 201);
            panel2.Name = "panel2";
            panel2.Size = new Size(525, 369);
            panel2.TabIndex = 43;
            // 
            // lblMon
            // 
            lblMon.AutoSize = true;
            lblMon.Dock = DockStyle.Top;
            lblMon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMon.Location = new Point(0, 0);
            lblMon.Name = "lblMon";
            lblMon.Size = new Size(133, 20);
            lblMon.TabIndex = 43;
            lblMon.Text = "DANH SÁCH KHO";
            // 
            // btnTim
            // 
            btnTim.BackgroundImage = (Image)resources.GetObject("btnTim.BackgroundImage");
            btnTim.BackgroundImageLayout = ImageLayout.Stretch;
            btnTim.Location = new Point(212, 50);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(32, 29);
            btnTim.TabIndex = 42;
            btnTim.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 52);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm theo Mã kho, Tên kho";
            txtSearch.Size = new Size(194, 27);
            txtSearch.TabIndex = 41;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(601, 12);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(151, 28);
            cboTrangThai.TabIndex = 13;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Brown;
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(341, 149);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 46);
            btnSua.TabIndex = 38;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Brown;
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(210, 149);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 46);
            btnThem.TabIndex = 37;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTenKho);
            panel1.Controls.Add(dtpNgayTao);
            panel1.Controls.Add(cboTrangThai);
            panel1.Controls.Add(txtMaKho);
            panel1.Controls.Add(l1);
            panel1.Controls.Add(l3);
            panel1.Controls.Add(l4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(2, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(925, 95);
            panel1.TabIndex = 36;
            // 
            // txtTenKho
            // 
            txtTenKho.Location = new Point(236, 51);
            txtTenKho.Name = "txtTenKho";
            txtTenKho.Size = new Size(125, 27);
            txtTenKho.TabIndex = 15;
            // 
            // dtpNgayTao
            // 
            dtpNgayTao.Location = new Point(601, 53);
            dtpNgayTao.Name = "dtpNgayTao";
            dtpNgayTao.Size = new Size(151, 27);
            dtpNgayTao.TabIndex = 14;
            // 
            // txtMaKho
            // 
            txtMaKho.Location = new Point(236, 13);
            txtMaKho.Name = "txtMaKho";
            txtMaKho.Size = new Size(125, 27);
            txtMaKho.TabIndex = 8;
            // 
            // l1
            // 
            l1.AutoSize = true;
            l1.Location = new Point(513, 20);
            l1.Name = "l1";
            l1.Size = new Size(82, 20);
            l1.TabIndex = 3;
            l1.Text = "Trạng thái :";
            // 
            // l3
            // 
            l3.AutoSize = true;
            l3.Location = new Point(518, 58);
            l3.Name = "l3";
            l3.Size = new Size(77, 20);
            l3.TabIndex = 2;
            l3.Text = "Ngày tạo :";
            // 
            // l4
            // 
            l4.AutoSize = true;
            l4.Location = new Point(162, 58);
            l4.Name = "l4";
            l4.Size = new Size(67, 20);
            l4.TabIndex = 1;
            l4.Text = "Tên kho :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 20);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã kho :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(385, 5);
            label1.Name = "label1";
            label1.Size = new Size(125, 23);
            label1.TabIndex = 44;
            label1.Text = "QUẢN LÝ KHO\r\n";
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Brown;
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(603, 149);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 46);
            btnLamMoi.TabIndex = 40;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Brown;
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(471, 149);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 46);
            btnXoa.TabIndex = 39;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // dgvChiTietKho
            // 
            dgvChiTietKho.AllowUserToAddRows = false;
            dgvChiTietKho.AllowUserToDeleteRows = false;
            dgvChiTietKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietKho.BackgroundColor = Color.White;
            dgvChiTietKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietKho.Columns.AddRange(new DataGridViewColumn[] { colMaNL, colTenNL, colSLTon });
            dgvChiTietKho.Location = new Point(0, 98);
            dgvChiTietKho.Name = "dgvChiTietKho";
            dgvChiTietKho.ReadOnly = true;
            dgvChiTietKho.RowHeadersVisible = false;
            dgvChiTietKho.RowHeadersWidth = 51;
            dgvChiTietKho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTietKho.Size = new Size(394, 270);
            dgvChiTietKho.TabIndex = 1;
            // 
            // colMaNL
            // 
            colMaNL.DataPropertyName = "MaNL";
            colMaNL.HeaderText = "Mã NL";
            colMaNL.MinimumWidth = 6;
            colMaNL.Name = "colMaNL";
            colMaNL.ReadOnly = true;
            // 
            // colTenNL
            // 
            colTenNL.DataPropertyName = "TenNL";
            colTenNL.HeaderText = "Tên NL";
            colTenNL.MinimumWidth = 6;
            colTenNL.Name = "colTenNL";
            colTenNL.ReadOnly = true;
            // 
            // colSLTon
            // 
            colSLTon.DataPropertyName = "SoLuongTon";
            colSLTon.HeaderText = "SL Tồn";
            colSLTon.MinimumWidth = 6;
            colSLTon.Name = "colSLTon";
            colSLTon.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(dgvChiTietKho);
            panel3.Location = new Point(532, 201);
            panel3.Name = "panel3";
            panel3.Size = new Size(395, 369);
            panel3.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 2;
            label3.Text = "CHI TIẾT TỒN KHO";
            // 
            // frmKho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 573);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Name = "frmKho";
            Text = "frmKho";
            Load += frmKho_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKho).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietKho).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvKho;
        private Panel panel2;
        private ComboBox cboTrangThai;
        private Button btnSua;
        private Button btnThem;
        private Panel panel1;
        private ComboBox cboKhuVuc;
        private TextBox txtLoaiBan;
        private TextBox txtMaKho;
        private Label l1;
        private Label l3;
        private Label l4;
        private Label label2;
        private Label label1;
        private Button btnTim;
        private TextBox txtSearch;
        private Button btnLamMoi;
        private Button btnXoa;
        private DataGridView dgvChiTietKho;
        private Panel panel3;
        private Label lblMon;
        private DateTimePicker dtpNgayTao;
        private Label label3;
        private DataGridViewTextBoxColumn colMaKho;
        private DataGridViewTextBoxColumn colTenKho;
        private DataGridViewTextBoxColumn colTrangThai;
        private DataGridViewTextBoxColumn colNgayTao;
        private DataGridViewTextBoxColumn colMaNL;
        private DataGridViewTextBoxColumn colTenNL;
        private DataGridViewTextBoxColumn colSLTon;
        private TextBox txtTenKho;
    }
}
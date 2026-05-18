namespace QuanLyCaPhe.GUI.QuanLy
{
    partial class frmBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBan));
            cboKhuVuc = new ComboBox();
            txtLoaiBan = new TextBox();
            txtMaBan = new TextBox();
            l1 = new Label();
            label1 = new Label();
            btnTim = new Button();
            txtSearch = new TextBox();
            btnLamMoi = new Button();
            btnXoa = new Button();
            l3 = new Label();
            l4 = new Label();
            label2 = new Label();
            btnSua = new Button();
            btnThem = new Button();
            panel1 = new Panel();
            cboTrangThai = new ComboBox();
            panel2 = new Panel();
            dgvBan = new DataGridView();
            colMaBan = new DataGridViewTextBoxColumn();
            colLoaiBan = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            colMaKV = new DataGridViewTextBoxColumn();
            colTenKV = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBan).BeginInit();
            SuspendLayout();
            // 
            // cboKhuVuc
            // 
            cboKhuVuc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhuVuc.FormattingEnabled = true;
            cboKhuVuc.Location = new Point(576, 55);
            cboKhuVuc.Name = "cboKhuVuc";
            cboKhuVuc.Size = new Size(151, 28);
            cboKhuVuc.TabIndex = 12;
            // 
            // txtLoaiBan
            // 
            txtLoaiBan.Location = new Point(220, 56);
            txtLoaiBan.Name = "txtLoaiBan";
            txtLoaiBan.Size = new Size(125, 27);
            txtLoaiBan.TabIndex = 9;
            // 
            // txtMaBan
            // 
            txtMaBan.Location = new Point(220, 18);
            txtMaBan.Name = "txtMaBan";
            txtMaBan.Size = new Size(125, 27);
            txtMaBan.TabIndex = 8;
            // 
            // l1
            // 
            l1.AutoSize = true;
            l1.Location = new Point(488, 25);
            l1.Name = "l1";
            l1.Size = new Size(82, 20);
            l1.TabIndex = 3;
            l1.Text = "Trạng thái :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(385, 5);
            label1.Name = "label1";
            label1.Size = new Size(124, 23);
            label1.TabIndex = 35;
            label1.Text = "QUẢN LÝ BÀN\r\n";
            // 
            // btnTim
            // 
            btnTim.BackgroundImage = (Image)resources.GetObject("btnTim.BackgroundImage");
            btnTim.BackgroundImageLayout = ImageLayout.Stretch;
            btnTim.Location = new Point(238, 254);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(32, 29);
            btnTim.TabIndex = 33;
            btnTim.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(27, 254);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm theo Mã bàn, Loại bàn, Mã KV";
            txtSearch.Size = new Size(205, 27);
            txtSearch.TabIndex = 32;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Brown;
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(578, 179);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 46);
            btnLamMoi.TabIndex = 31;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Brown;
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(446, 179);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 46);
            btnXoa.TabIndex = 30;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // l3
            // 
            l3.AutoSize = true;
            l3.Location = new Point(502, 59);
            l3.Name = "l3";
            l3.Size = new Size(68, 20);
            l3.TabIndex = 2;
            l3.Text = "Khu vực :";
            // 
            // l4
            // 
            l4.AutoSize = true;
            l4.Location = new Point(141, 63);
            l4.Name = "l4";
            l4.Size = new Size(73, 20);
            l4.TabIndex = 1;
            l4.Text = "Loại bàn :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 25);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã bàn :";
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Brown;
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(316, 179);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 46);
            btnSua.TabIndex = 29;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Brown;
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(185, 179);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 46);
            btnThem.TabIndex = 28;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(cboTrangThai);
            panel1.Controls.Add(cboKhuVuc);
            panel1.Controls.Add(txtLoaiBan);
            panel1.Controls.Add(txtMaBan);
            panel1.Controls.Add(l1);
            panel1.Controls.Add(l3);
            panel1.Controls.Add(l4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(2, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(925, 111);
            panel1.TabIndex = 27;
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(576, 17);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(151, 28);
            cboTrangThai.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dgvBan);
            panel2.Location = new Point(2, 287);
            panel2.Name = "panel2";
            panel2.Size = new Size(925, 285);
            panel2.TabIndex = 34;
            // 
            // dgvBan
            // 
            dgvBan.AllowUserToAddRows = false;
            dgvBan.AllowUserToDeleteRows = false;
            dgvBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBan.BackgroundColor = Color.White;
            dgvBan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBan.Columns.AddRange(new DataGridViewColumn[] { colMaBan, colLoaiBan, colTrangThai, colMaKV, colTenKV });
            dgvBan.Location = new Point(-1, -1);
            dgvBan.Name = "dgvBan";
            dgvBan.ReadOnly = true;
            dgvBan.RowHeadersVisible = false;
            dgvBan.RowHeadersWidth = 51;
            dgvBan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBan.Size = new Size(925, 285);
            dgvBan.TabIndex = 0;
            dgvBan.CellClick += dgvBan_CellClick;
            dgvBan.CellContentClick += dgvBan_CellContentClick;
            // 
            // colMaBan
            // 
            colMaBan.DataPropertyName = "MaBan";
            colMaBan.HeaderText = "Mã bàn";
            colMaBan.MinimumWidth = 6;
            colMaBan.Name = "colMaBan";
            colMaBan.ReadOnly = true;
            // 
            // colLoaiBan
            // 
            colLoaiBan.DataPropertyName = "LoaiBan";
            colLoaiBan.HeaderText = "Loại bàn";
            colLoaiBan.MinimumWidth = 6;
            colLoaiBan.Name = "colLoaiBan";
            colLoaiBan.ReadOnly = true;
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            // 
            // colMaKV
            // 
            colMaKV.DataPropertyName = "MaKV";
            colMaKV.HeaderText = "Mã KV";
            colMaKV.MinimumWidth = 6;
            colMaKV.Name = "colMaKV";
            colMaKV.ReadOnly = true;
            // 
            // colTenKV
            // 
            colTenKV.DataPropertyName = "TenKV";
            colTenKV.HeaderText = "Tên KV";
            colTenKV.MinimumWidth = 6;
            colTenKV.Name = "colTenKV";
            colTenKV.ReadOnly = true;
            // 
            // frmBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 573);
            Controls.Add(label1);
            Controls.Add(btnTim);
            Controls.Add(txtSearch);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "frmBan";
            Text = "frmBan";
            Load += frmBan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboKhuVuc;
        private TextBox txtLoaiBan;
        private TextBox txtMaBan;
        private Label l1;
        private Label label1;
        private Button btnTim;
        private TextBox txtSearch;
        private Button btnLamMoi;
        private Button btnXoa;
        private Label l3;
        private Label l4;
        private Label label2;
        private Button btnSua;
        private Button btnThem;
        private Panel panel1;
        private ComboBox cboTrangThai;
        private Panel panel2;
        private DataGridView dgvBan;
        private DataGridViewTextBoxColumn colMaBan;
        private DataGridViewTextBoxColumn colLoaiBan;
        private DataGridViewTextBoxColumn colTrangThai;
        private DataGridViewTextBoxColumn colMaKV;
        private DataGridViewTextBoxColumn colTenKV;
    }
}
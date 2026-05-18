namespace QuanLyCaPhe.GUI.BanHang
{
    partial class frmBanHang
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanHang));
            dgvMon = new DataGridView();
            colMaMon = new DataGridViewTextBoxColumn();
            colTenMon = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            pnMon = new Panel();
            btn = new Button();
            btnTim = new Button();
            txtSearch = new TextBox();
            lblMon = new Label();
            pnHoaDon = new Panel();
            lblTongTien = new Label();
            btnThanhToan = new Button();
            btnXoa = new Button();
            btnGiam = new Button();
            btnTang = new Button();
            dgvCTHD = new DataGridView();
            colMaMonHD = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colGiaHD = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();
            lblHoaDon = new Label();
            lblBan = new Label();
            pnBan = new Panel();
            panel3 = new Panel();
            flowSanVuon = new FlowLayoutPanel();
            label3 = new Label();
            panel2 = new Panel();
            flowTang2 = new FlowLayoutPanel();
            label2 = new Label();
            panel1 = new Panel();
            flowTang1 = new FlowLayoutPanel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMon).BeginInit();
            pnMon.SuspendLayout();
            pnHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTHD).BeginInit();
            pnBan.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMon
            // 
            dgvMon.AllowUserToAddRows = false;
            dgvMon.AllowUserToDeleteRows = false;
            dgvMon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMon.BackgroundColor = Color.White;
            dgvMon.BorderStyle = BorderStyle.None;
            dgvMon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMon.Columns.AddRange(new DataGridViewColumn[] { colMaMon, colTenMon, colDonGia, colTrangThai });
            dgvMon.Dock = DockStyle.Bottom;
            dgvMon.Location = new Point(0, 71);
            dgvMon.MultiSelect = false;
            dgvMon.Name = "dgvMon";
            dgvMon.ReadOnly = true;
            dgvMon.RowHeadersVisible = false;
            dgvMon.RowHeadersWidth = 51;
            dgvMon.Size = new Size(381, 255);
            dgvMon.TabIndex = 2;
            dgvMon.CellDoubleClick += dgvMon_CellDoubleClick;
            // 
            // colMaMon
            // 
            colMaMon.DataPropertyName = "MaMon";
            colMaMon.HeaderText = "Mã món";
            colMaMon.MinimumWidth = 6;
            colMaMon.Name = "colMaMon";
            colMaMon.ReadOnly = true;
            // 
            // colTenMon
            // 
            colTenMon.DataPropertyName = "TenMon";
            colTenMon.HeaderText = "Tên món";
            colTenMon.MinimumWidth = 6;
            colTenMon.Name = "colTenMon";
            colTenMon.ReadOnly = true;
            // 
            // colDonGia
            // 
            colDonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle1.NullValue = null;
            colDonGia.DefaultCellStyle = dataGridViewCellStyle1;
            colDonGia.HeaderText = "Đơn giá (VNĐ)";
            colDonGia.MinimumWidth = 6;
            colDonGia.Name = "colDonGia";
            colDonGia.ReadOnly = true;
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            // 
            // pnMon
            // 
            pnMon.BorderStyle = BorderStyle.FixedSingle;
            pnMon.Controls.Add(btn);
            pnMon.Controls.Add(btnTim);
            pnMon.Controls.Add(dgvMon);
            pnMon.Controls.Add(txtSearch);
            pnMon.Controls.Add(lblMon);
            pnMon.Location = new Point(4, 284);
            pnMon.Name = "pnMon";
            pnMon.Size = new Size(383, 328);
            pnMon.TabIndex = 1;
            // 
            // btn
            // 
            btn.BackColor = Color.BurlyWood;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn.ForeColor = SystemColors.WindowText;
            btn.Location = new Point(775, 253);
            btn.Name = "btn";
            btn.Size = new Size(140, 41);
            btn.TabIndex = 2;
            btn.Text = "Thanh toán";
            btn.UseVisualStyleBackColor = false;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.Transparent;
            btnTim.BackgroundImage = (Image)resources.GetObject("btnTim.BackgroundImage");
            btnTim.BackgroundImageLayout = ImageLayout.Stretch;
            btnTim.Location = new Point(162, 39);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(39, 27);
            btnTim.TabIndex = 3;
            btnTim.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 39);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm theo Tên món";
            txtSearch.Size = new Size(144, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblMon
            // 
            lblMon.AutoSize = true;
            lblMon.Dock = DockStyle.Top;
            lblMon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMon.Location = new Point(0, 0);
            lblMon.Name = "lblMon";
            lblMon.Size = new Size(138, 20);
            lblMon.TabIndex = 0;
            lblMon.Text = "DANH SÁCH MÓN";
            // 
            // pnHoaDon
            // 
            pnHoaDon.BorderStyle = BorderStyle.FixedSingle;
            pnHoaDon.Controls.Add(lblTongTien);
            pnHoaDon.Controls.Add(btnThanhToan);
            pnHoaDon.Controls.Add(btnXoa);
            pnHoaDon.Controls.Add(btnGiam);
            pnHoaDon.Controls.Add(btnTang);
            pnHoaDon.Controls.Add(dgvCTHD);
            pnHoaDon.Controls.Add(lblHoaDon);
            pnHoaDon.Location = new Point(390, 284);
            pnHoaDon.Name = "pnHoaDon";
            pnHoaDon.Size = new Size(534, 328);
            pnHoaDon.TabIndex = 2;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongTien.Location = new Point(26, 274);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(97, 23);
            lblTongTien.TabIndex = 5;
            lblTongTien.Text = "Tổng tiền :";
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.Brown;
            btnThanhToan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(384, 266);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(124, 53);
            btnThanhToan.TabIndex = 6;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click_1;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Brown;
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(221, 206);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(123, 48);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa món";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnGiam
            // 
            btnGiam.BackColor = Color.Brown;
            btnGiam.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGiam.ForeColor = Color.White;
            btnGiam.Location = new Point(119, 206);
            btnGiam.Name = "btnGiam";
            btnGiam.Size = new Size(43, 48);
            btnGiam.TabIndex = 3;
            btnGiam.Text = "-";
            btnGiam.UseVisualStyleBackColor = false;
            btnGiam.Click += btnGiam_Click;
            // 
            // btnTang
            // 
            btnTang.BackColor = Color.Brown;
            btnTang.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTang.ForeColor = Color.White;
            btnTang.Location = new Point(31, 206);
            btnTang.Name = "btnTang";
            btnTang.Size = new Size(43, 48);
            btnTang.TabIndex = 2;
            btnTang.Text = "+";
            btnTang.UseVisualStyleBackColor = false;
            btnTang.Click += btnTang_Click;
            // 
            // dgvCTHD
            // 
            dgvCTHD.AllowUserToAddRows = false;
            dgvCTHD.AllowUserToDeleteRows = false;
            dgvCTHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCTHD.BackgroundColor = Color.White;
            dgvCTHD.BorderStyle = BorderStyle.None;
            dgvCTHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCTHD.Columns.AddRange(new DataGridViewColumn[] { colMaMonHD, colSoLuong, colGiaHD, colThanhTien });
            dgvCTHD.Dock = DockStyle.Top;
            dgvCTHD.Location = new Point(0, 20);
            dgvCTHD.Name = "dgvCTHD";
            dgvCTHD.ReadOnly = true;
            dgvCTHD.RowHeadersVisible = false;
            dgvCTHD.RowHeadersWidth = 51;
            dgvCTHD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCTHD.Size = new Size(532, 170);
            dgvCTHD.TabIndex = 1;
            // 
            // colMaMonHD
            // 
            colMaMonHD.DataPropertyName = "MaMon";
            colMaMonHD.HeaderText = "Mã món";
            colMaMonHD.MinimumWidth = 6;
            colMaMonHD.Name = "colMaMonHD";
            colMaMonHD.ReadOnly = true;
            // 
            // colSoLuong
            // 
            colSoLuong.DataPropertyName = "SoLuong";
            colSoLuong.HeaderText = "Số lượng";
            colSoLuong.MinimumWidth = 6;
            colSoLuong.Name = "colSoLuong";
            colSoLuong.ReadOnly = true;
            // 
            // colGiaHD
            // 
            colGiaHD.DataPropertyName = "DonGia";
            colGiaHD.HeaderText = "Đơn giá (VNĐ)";
            colGiaHD.MinimumWidth = 6;
            colGiaHD.Name = "colGiaHD";
            colGiaHD.ReadOnly = true;
            // 
            // colThanhTien
            // 
            colThanhTien.DataPropertyName = "ThanhTien";
            colThanhTien.HeaderText = "Thành tiền";
            colThanhTien.MinimumWidth = 6;
            colThanhTien.Name = "colThanhTien";
            colThanhTien.ReadOnly = true;
            // 
            // lblHoaDon
            // 
            lblHoaDon.AutoSize = true;
            lblHoaDon.Dock = DockStyle.Top;
            lblHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHoaDon.Location = new Point(0, 0);
            lblHoaDon.Name = "lblHoaDon";
            lblHoaDon.Size = new Size(81, 20);
            lblHoaDon.TabIndex = 0;
            lblHoaDon.Text = "HÓA ĐƠN";
            // 
            // lblBan
            // 
            lblBan.AutoSize = true;
            lblBan.Dock = DockStyle.Top;
            lblBan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBan.Location = new Point(0, 0);
            lblBan.Name = "lblBan";
            lblBan.Size = new Size(134, 20);
            lblBan.TabIndex = 1;
            lblBan.Text = "DANH SÁCH BÀN";
            // 
            // pnBan
            // 
            pnBan.Controls.Add(panel3);
            pnBan.Controls.Add(panel2);
            pnBan.Controls.Add(panel1);
            pnBan.Controls.Add(lblBan);
            pnBan.Location = new Point(0, 1);
            pnBan.Name = "pnBan";
            pnBan.Size = new Size(927, 262);
            pnBan.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(flowSanVuon);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(4, 146);
            panel3.Name = "panel3";
            panel3.Size = new Size(915, 105);
            panel3.TabIndex = 4;
            // 
            // flowSanVuon
            // 
            flowSanVuon.AutoScroll = true;
            flowSanVuon.Location = new Point(3, 23);
            flowSanVuon.Name = "flowSanVuon";
            flowSanVuon.Size = new Size(906, 74);
            flowSanVuon.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 23);
            label3.TabIndex = 0;
            label3.Text = "Sân vườn";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(flowTang2);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(471, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(448, 102);
            panel2.TabIndex = 3;
            // 
            // flowTang2
            // 
            flowTang2.AutoScroll = true;
            flowTang2.Location = new Point(5, 23);
            flowTang2.Name = "flowTang2";
            flowTang2.Size = new Size(437, 74);
            flowTang2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 23);
            label2.TabIndex = 0;
            label2.Text = "Tầng 2";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(flowTang1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(462, 102);
            panel1.TabIndex = 2;
            // 
            // flowTang1
            // 
            flowTang1.AutoScroll = true;
            flowTang1.Location = new Point(3, 23);
            flowTang1.Name = "flowTang1";
            flowTang1.Size = new Size(454, 74);
            flowTang1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 23);
            label1.TabIndex = 0;
            label1.Text = "Tầng 1";
            // 
            // frmBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 615);
            Controls.Add(pnHoaDon);
            Controls.Add(pnMon);
            Controls.Add(pnBan);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmBanHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBanHang";
            Load += frmBanHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMon).EndInit();
            pnMon.ResumeLayout(false);
            pnMon.PerformLayout();
            pnHoaDon.ResumeLayout(false);
            pnHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTHD).EndInit();
            pnBan.ResumeLayout(false);
            pnBan.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnMon;
        private DataGridView dgvMon;
        private TextBox txtSearch;
        private Label lblMon;
        private Button btnTim;
        private Button btn;
        private DataGridViewTextBoxColumn colMaMon;
        private DataGridViewTextBoxColumn colTenMon;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewTextBoxColumn colTrangThai;
        private Panel pnHoaDon;
        private DataGridView dgvCTHD;
        private Label lblHoaDon;
        private Button btnXoa;
        private Button btnGiam;
        private Button btnTang;
        private DataGridViewTextBoxColumn colTenMonHD;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colGiaHD;
        private DataGridViewTextBoxColumn colThanhTien;
        private Label lblTongTien;
        private Button btnThanhToan;
        private DataGridViewTextBoxColumn colMaMonHD;
        private Label lblBan;
        private Panel pnBan;
        private Panel panel3;
        private FlowLayoutPanel flowSanVuon;
        private Label label3;
        private Panel panel2;
        private FlowLayoutPanel flowTang2;
        private Label label2;
        private Panel panel1;
        private FlowLayoutPanel flowTang1;
        private Label label1;
    }
}
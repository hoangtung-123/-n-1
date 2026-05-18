namespace QuanLyCaPhe.GUI.HoaDon
{
    partial class frmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            label1 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            button4 = new Button();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnLoc = new Button();
            txtSearch = new TextBox();
            dtTo = new DateTimePicker();
            dtFrom = new DateTimePicker();
            panel2 = new Panel();
            label2 = new Label();
            dgvChiTiet = new DataGridView();
            colMon = new DataGridViewTextBoxColumn();
            colSL = new DataGridViewTextBoxColumn();
            colGia = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();
            dgvHoaDon = new DataGridView();
            colMaHD = new DataGridViewTextBoxColumn();
            colBan = new DataGridViewTextBoxColumn();
            colNV = new DataGridViewTextBoxColumn();
            colNgayTao = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            colTongTien = new DataGridViewTextBoxColumn();
            label3 = new Label();
            lblTongTien = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            btnIn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(379, 6);
            label1.Name = "label1";
            label1.Size = new Size(170, 23);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ HÓA ĐƠN";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(btnLamMoi);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnLoc);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(dtTo);
            panel1.Controls.Add(dtFrom);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(928, 127);
            panel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(26, 47);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 9;
            label5.Text = "Đến ngày :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(36, 10);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 8;
            label4.Text = "Từ ngày :";
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(246, 92);
            button4.Name = "button4";
            button4.Size = new Size(38, 29);
            button4.TabIndex = 7;
            button4.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Brown;
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(683, 72);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 38);
            btnLamMoi.TabIndex = 6;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Brown;
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(531, 72);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 38);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLoc
            // 
            btnLoc.BackColor = Color.Brown;
            btnLoc.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLoc.ForeColor = Color.White;
            btnLoc.Location = new Point(385, 72);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(94, 38);
            btnLoc.TabIndex = 4;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.Click += btnLoc_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(7, 93);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm theo Mã HD, Mã bàn, Mã NV, Trạng thái";
            txtSearch.Size = new Size(233, 27);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dtTo
            // 
            dtTo.Location = new Point(117, 42);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(123, 27);
            dtTo.TabIndex = 1;
            // 
            // dtFrom
            // 
            dtFrom.Location = new Point(117, 3);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(123, 27);
            dtFrom.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dgvChiTiet);
            panel2.Controls.Add(dgvHoaDon);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 204);
            panel2.Name = "panel2";
            panel2.Size = new Size(927, 346);
            panel2.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(173, 20);
            label2.TabIndex = 2;
            label2.Text = "DANH SÁCH HÓA ĐƠN";
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.AllowUserToAddRows = false;
            dgvChiTiet.AllowUserToDeleteRows = false;
            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTiet.BackgroundColor = Color.White;
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Columns.AddRange(new DataGridViewColumn[] { colMon, colSL, colGia, colThanhTien });
            dgvChiTiet.Location = new Point(0, 199);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.ReadOnly = true;
            dgvChiTiet.RowHeadersVisible = false;
            dgvChiTiet.RowHeadersWidth = 51;
            dgvChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTiet.Size = new Size(925, 146);
            dgvChiTiet.TabIndex = 12;
            // 
            // colMon
            // 
            colMon.DataPropertyName = "TenMon";
            colMon.HeaderText = "Tên món";
            colMon.MinimumWidth = 6;
            colMon.Name = "colMon";
            colMon.ReadOnly = true;
            // 
            // colSL
            // 
            colSL.DataPropertyName = "SoLuong";
            colSL.HeaderText = "Số lượng";
            colSL.MinimumWidth = 6;
            colSL.Name = "colSL";
            colSL.ReadOnly = true;
            // 
            // colGia
            // 
            colGia.DataPropertyName = "DonGia";
            colGia.HeaderText = "Đơn giá";
            colGia.MinimumWidth = 6;
            colGia.Name = "colGia";
            colGia.ReadOnly = true;
            // 
            // colThanhTien
            // 
            colThanhTien.DataPropertyName = "ThanhTien";
            colThanhTien.HeaderText = "Thành tiền";
            colThanhTien.MinimumWidth = 6;
            colThanhTien.Name = "colThanhTien";
            colThanhTien.ReadOnly = true;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AllowUserToDeleteRows = false;
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.BackgroundColor = Color.White;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Columns.AddRange(new DataGridViewColumn[] { colMaHD, colBan, colNV, colNgayTao, colTrangThai, colTongTien });
            dgvHoaDon.Location = new Point(0, 23);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.ReadOnly = true;
            dgvHoaDon.RowHeadersVisible = false;
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.Size = new Size(926, 133);
            dgvHoaDon.TabIndex = 11;
            dgvHoaDon.CellClick += dgvHoaDon_CellClick;
            dgvHoaDon.CellFormatting += dgvHoaDon_CellFormatting;
            // 
            // colMaHD
            // 
            colMaHD.DataPropertyName = "MaHD";
            colMaHD.HeaderText = "Mã HD";
            colMaHD.MinimumWidth = 6;
            colMaHD.Name = "colMaHD";
            colMaHD.ReadOnly = true;
            // 
            // colBan
            // 
            colBan.DataPropertyName = "MaBan";
            colBan.HeaderText = "Mã bàn";
            colBan.MinimumWidth = 6;
            colBan.Name = "colBan";
            colBan.ReadOnly = true;
            // 
            // colNV
            // 
            colNV.DataPropertyName = "MaNV";
            colNV.HeaderText = "Mã NV";
            colNV.MinimumWidth = 6;
            colNV.Name = "colNV";
            colNV.ReadOnly = true;
            // 
            // colNgayTao
            // 
            colNgayTao.DataPropertyName = "NgayTao";
            colNgayTao.HeaderText = "Ngày tạo";
            colNgayTao.MinimumWidth = 6;
            colNgayTao.Name = "colNgayTao";
            colNgayTao.ReadOnly = true;
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            // 
            // colTongTien
            // 
            colTongTien.DataPropertyName = "TongTien";
            colTongTien.HeaderText = "Tổng tiền";
            colTongTien.MinimumWidth = 6;
            colTongTien.Name = "colTongTien";
            colTongTien.ReadOnly = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(-1, 174);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 4;
            label3.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongTien.Location = new Point(117, 563);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(97, 23);
            lblTongTien.TabIndex = 7;
            lblTongTien.Text = "Tổng tiền :";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
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
            // btnIn
            // 
            btnIn.BackColor = Color.Brown;
            btnIn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnIn.ForeColor = Color.White;
            btnIn.Location = new Point(822, 556);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(94, 40);
            btnIn.TabIndex = 10;
            btnIn.Text = "In";
            btnIn.UseVisualStyleBackColor = false;
            btnIn.Click += btnIn_Click;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 598);
            Controls.Add(panel2);
            Controls.Add(btnIn);
            Controls.Add(lblTongTien);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "frmHoaDon";
            Text = "frmHoaDon";
            Load += frmHoaDon_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button button4;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnLoc;
        private TextBox txtSearch;
        private DateTimePicker dtTo;
        private DateTimePicker dtFrom;
        private Label label2;
        private Label label3;
        private Label lblTongTien;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button btnIn;
        private DataGridView dgvHoaDon;
        private DataGridView dgvChiTiet;
        private DataGridViewTextBoxColumn colMon;
        private DataGridViewTextBoxColumn colSL;
        private DataGridViewTextBoxColumn colGia;
        private DataGridViewTextBoxColumn colThanhTien;
        private DataGridViewTextBoxColumn colMaHD;
        private DataGridViewTextBoxColumn colBan;
        private DataGridViewTextBoxColumn colNV;
        private DataGridViewTextBoxColumn colNgayTao;
        private DataGridViewTextBoxColumn colTrangThai;
        private DataGridViewTextBoxColumn colTongTien;
        private Panel panel2;
        private Label label5;
        private Label label4;
    }
}
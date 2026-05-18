namespace QuanLyCaPhe.GUI.BanHang
{
    partial class frmThanhToan
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
            lblBan = new Label();
            dgvThanhToan = new DataGridView();
            colMaMon = new DataGridViewTextBoxColumn();
            colTenMon = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();
            pnThanhToan = new Panel();
            lblTien = new Label();
            lblTienThua = new Label();
            btnHuy = new Button();
            btnXacNhan = new Button();
            txtTienKhach = new TextBox();
            lblTienKhach = new Label();
            lblTongTitle = new Label();
            lblTongTien = new Label();
            lblTitle = new Label();
            pnThongTin = new Panel();
            lblThoiGian = new Label();
            lblTime = new Label();
            lblNhanVien = new Label();
            lblMon = new Label();
            PrintDocument = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)dgvThanhToan).BeginInit();
            pnThanhToan.SuspendLayout();
            pnThongTin.SuspendLayout();
            SuspendLayout();
            // 
            // lblBan
            // 
            lblBan.AutoSize = true;
            lblBan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBan.Location = new Point(9, 10);
            lblBan.Name = "lblBan";
            lblBan.Size = new Size(41, 20);
            lblBan.TabIndex = 0;
            lblBan.Text = "Bàn :";
            // 
            // dgvThanhToan
            // 
            dgvThanhToan.AllowUserToAddRows = false;
            dgvThanhToan.AllowUserToDeleteRows = false;
            dgvThanhToan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThanhToan.BackgroundColor = Color.White;
            dgvThanhToan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThanhToan.Columns.AddRange(new DataGridViewColumn[] { colMaMon, colTenMon, colSoLuong, colDonGia, colThanhTien });
            dgvThanhToan.Location = new Point(3, 199);
            dgvThanhToan.Name = "dgvThanhToan";
            dgvThanhToan.ReadOnly = true;
            dgvThanhToan.RowHeadersVisible = false;
            dgvThanhToan.RowHeadersWidth = 51;
            dgvThanhToan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThanhToan.Size = new Size(640, 160);
            dgvThanhToan.TabIndex = 1;
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
            // colSoLuong
            // 
            colSoLuong.DataPropertyName = "SoLuong";
            colSoLuong.HeaderText = "Số lượng";
            colSoLuong.MinimumWidth = 6;
            colSoLuong.Name = "colSoLuong";
            colSoLuong.ReadOnly = true;
            // 
            // colDonGia
            // 
            colDonGia.DataPropertyName = "DonGia";
            colDonGia.HeaderText = "Đơn giá";
            colDonGia.MinimumWidth = 6;
            colDonGia.Name = "colDonGia";
            colDonGia.ReadOnly = true;
            // 
            // colThanhTien
            // 
            colThanhTien.DataPropertyName = "ThanhTien";
            colThanhTien.HeaderText = "Thành tiền";
            colThanhTien.MinimumWidth = 6;
            colThanhTien.Name = "colThanhTien";
            colThanhTien.ReadOnly = true;
            // 
            // pnThanhToan
            // 
            pnThanhToan.BorderStyle = BorderStyle.FixedSingle;
            pnThanhToan.Controls.Add(lblTien);
            pnThanhToan.Controls.Add(lblTienThua);
            pnThanhToan.Controls.Add(btnHuy);
            pnThanhToan.Controls.Add(btnXacNhan);
            pnThanhToan.Controls.Add(txtTienKhach);
            pnThanhToan.Controls.Add(lblTienKhach);
            pnThanhToan.Controls.Add(lblTongTitle);
            pnThanhToan.Controls.Add(lblTongTien);
            pnThanhToan.Dock = DockStyle.Bottom;
            pnThanhToan.Location = new Point(0, 365);
            pnThanhToan.Name = "pnThanhToan";
            pnThanhToan.Size = new Size(646, 233);
            pnThanhToan.TabIndex = 2;
            // 
            // lblTien
            // 
            lblTien.AutoSize = true;
            lblTien.Location = new Point(282, 137);
            lblTien.Name = "lblTien";
            lblTien.Size = new Size(117, 20);
            lblTien.TabIndex = 8;
            lblTien.Text = "Tiền thừa/thiếu :";
            // 
            // lblTienThua
            // 
            lblTienThua.AutoSize = true;
            lblTienThua.Location = new Point(405, 137);
            lblTienThua.Name = "lblTienThua";
            lblTienThua.Size = new Size(52, 20);
            lblTienThua.TabIndex = 7;
            lblTienThua.Text = "0 VNĐ";
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Brown;
            btnHuy.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(493, 170);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(122, 50);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click_1;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.Brown;
            btnXacNhan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXacNhan.ForeColor = Color.White;
            btnXacNhan.Location = new Point(355, 170);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(122, 50);
            btnXacNhan.TabIndex = 5;
            btnXacNhan.Text = "Thanh toán";
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // txtTienKhach
            // 
            txtTienKhach.Location = new Point(404, 74);
            txtTienKhach.Name = "txtTienKhach";
            txtTienKhach.Size = new Size(125, 27);
            txtTienKhach.TabIndex = 4;
            txtTienKhach.TextChanged += txtTienKhach_TextChanged;
            txtTienKhach.KeyPress += txtTienKhach_KeyPress;
            // 
            // lblTienKhach
            // 
            lblTienKhach.AutoSize = true;
            lblTienKhach.Location = new Point(282, 81);
            lblTienKhach.Name = "lblTienKhach";
            lblTienKhach.Size = new Size(116, 20);
            lblTienKhach.TabIndex = 3;
            lblTienKhach.Text = "Tiền khách đưa :";
            // 
            // lblTongTitle
            // 
            lblTongTitle.AutoSize = true;
            lblTongTitle.Location = new Point(282, 27);
            lblTongTitle.Name = "lblTongTitle";
            lblTongTitle.Size = new Size(79, 20);
            lblTongTitle.TabIndex = 2;
            lblTongTitle.Text = "Tổng tiền :";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(404, 27);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(72, 20);
            lblTongTien.TabIndex = 0;
            lblTongTien.Text = "Tổng tiền";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTitle.Location = new Point(216, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(210, 23);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "THANH TOÁN HÓA ĐƠN";
            // 
            // pnThongTin
            // 
            pnThongTin.BorderStyle = BorderStyle.FixedSingle;
            pnThongTin.Controls.Add(lblThoiGian);
            pnThongTin.Controls.Add(lblTime);
            pnThongTin.Controls.Add(lblNhanVien);
            pnThongTin.Controls.Add(lblBan);
            pnThongTin.Location = new Point(3, 40);
            pnThongTin.Name = "pnThongTin";
            pnThongTin.Size = new Size(640, 125);
            pnThongTin.TabIndex = 4;
            // 
            // lblThoiGian
            // 
            lblThoiGian.AutoSize = true;
            lblThoiGian.Location = new Point(9, 45);
            lblThoiGian.Name = "lblThoiGian";
            lblThoiGian.Size = new Size(78, 20);
            lblThoiGian.TabIndex = 4;
            lblThoiGian.Text = "Thời gian :";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(105, 45);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(50, 20);
            lblTime.TabIndex = 3;
            lblTime.Text = "label4";
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Location = new Point(433, 10);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(50, 20);
            lblNhanVien.TabIndex = 1;
            lblNhanVien.Text = "label3";
            // 
            // lblMon
            // 
            lblMon.AutoSize = true;
            lblMon.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblMon.Location = new Point(237, 168);
            lblMon.Name = "lblMon";
            lblMon.Size = new Size(159, 23);
            lblMon.TabIndex = 5;
            lblMon.Text = "DANH SÁCH MÓN";
            // 
            // PrintDocument
            // 
            PrintDocument.PrintPage += PrintDocument_PrintPage;
            // 
            // frmThanhToan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 598);
            Controls.Add(lblMon);
            Controls.Add(pnThongTin);
            Controls.Add(dgvThanhToan);
            Controls.Add(lblTitle);
            Controls.Add(pnThanhToan);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmThanhToan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmThanhToan";
            Load += frmThanhToan_Load;
            ((System.ComponentModel.ISupportInitialize)dgvThanhToan).EndInit();
            pnThanhToan.ResumeLayout(false);
            pnThanhToan.PerformLayout();
            pnThongTin.ResumeLayout(false);
            pnThongTin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBan;
        private DataGridView dgvThanhToan;
        private DataGridViewTextBoxColumn colMaMon;
        private DataGridViewTextBoxColumn colTenMon;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewTextBoxColumn colThanhTien;
        private Panel pnThanhToan;
        private Label lblTongTien;
        private Label lblTitle;
        private Panel pnThongTin;
        private Label lblTime;
        private Label lblNhanVien;
        private Label lblMon;
        private Button btnHuy;
        private Button btnXacNhan;
        private TextBox txtTienKhach;
        private Label lblTienKhach;
        private Label lblTongTitle;
        private Label lblTienThua;
        private Label lblThoiGian;
        private Label lblTien;
        private System.Drawing.Printing.PrintDocument PrintDocument;
    }
}
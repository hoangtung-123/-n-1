using System.Windows.Forms.DataVisualization.Charting;
namespace QuanLyCaPhe.GUI.BaoCao
{
    partial class frmBaoCao
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
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            ChartArea chartArea2 = new ChartArea();
            Legend legend2 = new Legend();
            Series series2 = new Series();
            label1 = new Label();
            lblTongDoanhThu = new Label();
            lblTongHoaDon = new Label();
            lblTongPhieuNhap = new Label();
            lblTongTonKho = new Label();
            panel1 = new Panel();
            btnFilterNam = new Button();
            btnFilterThang = new Button();
            btnFilterNgay = new Button();
            label3 = new Label();
            chartDoanhThu = new Chart();
            panel2 = new Panel();
            btnXuatHoaDon = new Button();
            btnXuatPhieuNhap = new Button();
            btnLamMoi = new Button();
            btnThongKe = new Button();
            label7 = new Label();
            label6 = new Label();
            dtTo = new DateTimePicker();
            dtFrom = new DateTimePicker();
            dgvBaoCao = new DataGridView();
            colMaHD = new DataGridViewTextBoxColumn();
            colTenNV = new DataGridViewTextBoxColumn();
            colMaBan = new DataGridViewTextBoxColumn();
            colNgayTao = new DataGridViewTextBoxColumn();
            colTongTien = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            label2 = new Label();
            chartTopMon = new Chart();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDoanhThu).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartTopMon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(353, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 23);
            label1.TabIndex = 12;
            label1.Text = "BÁO CÁO - THỐNG KÊ";
            // 
            // lblTongDoanhThu
            // 
            lblTongDoanhThu.BackColor = Color.RosyBrown;
            lblTongDoanhThu.BorderStyle = BorderStyle.FixedSingle;
            lblTongDoanhThu.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongDoanhThu.ForeColor = Color.White;
            lblTongDoanhThu.Location = new Point(11, 44);
            lblTongDoanhThu.Name = "lblTongDoanhThu";
            lblTongDoanhThu.Size = new Size(203, 64);
            lblTongDoanhThu.TabIndex = 13;
            lblTongDoanhThu.Text = "label2";
            lblTongDoanhThu.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTongHoaDon
            // 
            lblTongHoaDon.BackColor = Color.DarkOliveGreen;
            lblTongHoaDon.BorderStyle = BorderStyle.FixedSingle;
            lblTongHoaDon.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongHoaDon.ForeColor = Color.White;
            lblTongHoaDon.Location = new Point(246, 44);
            lblTongHoaDon.Name = "lblTongHoaDon";
            lblTongHoaDon.Size = new Size(203, 64);
            lblTongHoaDon.TabIndex = 14;
            lblTongHoaDon.Text = "label3";
            lblTongHoaDon.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTongPhieuNhap
            // 
            lblTongPhieuNhap.BackColor = Color.Tomato;
            lblTongPhieuNhap.BorderStyle = BorderStyle.FixedSingle;
            lblTongPhieuNhap.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongPhieuNhap.ForeColor = Color.White;
            lblTongPhieuNhap.Location = new Point(477, 44);
            lblTongPhieuNhap.Name = "lblTongPhieuNhap";
            lblTongPhieuNhap.Size = new Size(200, 64);
            lblTongPhieuNhap.TabIndex = 15;
            lblTongPhieuNhap.Text = "label4";
            lblTongPhieuNhap.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTongTonKho
            // 
            lblTongTonKho.BackColor = Color.Sienna;
            lblTongTonKho.BorderStyle = BorderStyle.FixedSingle;
            lblTongTonKho.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongTonKho.ForeColor = Color.White;
            lblTongTonKho.Location = new Point(712, 44);
            lblTongTonKho.Name = "lblTongTonKho";
            lblTongTonKho.Size = new Size(203, 64);
            lblTongTonKho.TabIndex = 16;
            lblTongTonKho.Text = "label5";
            lblTongTonKho.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnFilterNam);
            panel1.Controls.Add(btnFilterThang);
            panel1.Controls.Add(btnFilterNgay);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(chartDoanhThu);
            panel1.Location = new Point(-1, 127);
            panel1.Name = "panel1";
            panel1.Size = new Size(544, 222);
            panel1.TabIndex = 17;
            // 
            // btnFilterNam
            // 
            btnFilterNam.BackColor = SystemColors.ActiveCaption;
            btnFilterNam.ForeColor = Color.White;
            btnFilterNam.Location = new Point(16, 122);
            btnFilterNam.Name = "btnFilterNam";
            btnFilterNam.Size = new Size(94, 38);
            btnFilterNam.TabIndex = 16;
            btnFilterNam.Text = "Năm";
            btnFilterNam.UseVisualStyleBackColor = false;
            btnFilterNam.Click += btnFilterNam_Click;
            // 
            // btnFilterThang
            // 
            btnFilterThang.BackColor = SystemColors.ActiveCaption;
            btnFilterThang.ForeColor = Color.White;
            btnFilterThang.Location = new Point(16, 78);
            btnFilterThang.Name = "btnFilterThang";
            btnFilterThang.Size = new Size(94, 38);
            btnFilterThang.TabIndex = 15;
            btnFilterThang.Text = "Tháng";
            btnFilterThang.UseVisualStyleBackColor = false;
            btnFilterThang.Click += btnFilterThang_Click;
            // 
            // btnFilterNgay
            // 
            btnFilterNgay.BackColor = SystemColors.ActiveCaption;
            btnFilterNgay.ForeColor = Color.White;
            btnFilterNgay.Location = new Point(16, 34);
            btnFilterNgay.Name = "btnFilterNgay";
            btnFilterNgay.Size = new Size(94, 38);
            btnFilterNgay.TabIndex = 14;
            btnFilterNgay.Text = "Ngày";
            btnFilterNgay.UseVisualStyleBackColor = false;
            btnFilterNgay.Click += btnFilterNgay_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 13;
            label3.Text = "TỔNG DOANH THU";
            // 
            // chartDoanhThu
            // 
            chartDoanhThu.Anchor = AnchorStyles.None;
            chartArea1.Name = "ChartArea1";
            chartDoanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDoanhThu.Legends.Add(legend1);
            chartDoanhThu.Location = new Point(130, 24);
            chartDoanhThu.Name = "chartDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDoanhThu.Series.Add(series1);
            chartDoanhThu.Size = new Size(413, 193);
            chartDoanhThu.TabIndex = 0;
            chartDoanhThu.Text = "chartDoanhThu";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnXuatHoaDon);
            panel2.Controls.Add(btnXuatPhieuNhap);
            panel2.Controls.Add(btnLamMoi);
            panel2.Controls.Add(btnThongKe);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(dtTo);
            panel2.Controls.Add(dtFrom);
            panel2.Location = new Point(0, 356);
            panel2.Name = "panel2";
            panel2.Size = new Size(927, 100);
            panel2.TabIndex = 18;
            // 
            // btnXuatHoaDon
            // 
            btnXuatHoaDon.BackColor = Color.LightCoral;
            btnXuatHoaDon.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXuatHoaDon.ForeColor = Color.White;
            btnXuatHoaDon.Location = new Point(690, 3);
            btnXuatHoaDon.Name = "btnXuatHoaDon";
            btnXuatHoaDon.Size = new Size(154, 43);
            btnXuatHoaDon.TabIndex = 17;
            btnXuatHoaDon.Text = "Xuất hóa đơn";
            btnXuatHoaDon.UseVisualStyleBackColor = false;
            btnXuatHoaDon.Click += btnXuatHoaDon_Click;
            // 
            // btnXuatPhieuNhap
            // 
            btnXuatPhieuNhap.BackColor = Color.LightCoral;
            btnXuatPhieuNhap.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnXuatPhieuNhap.ForeColor = Color.White;
            btnXuatPhieuNhap.Location = new Point(690, 47);
            btnXuatPhieuNhap.Name = "btnXuatPhieuNhap";
            btnXuatPhieuNhap.Size = new Size(154, 43);
            btnXuatPhieuNhap.TabIndex = 16;
            btnXuatPhieuNhap.Text = "Xuất phiếu nhập";
            btnXuatPhieuNhap.UseVisualStyleBackColor = false;
            btnXuatPhieuNhap.Click += btnXuatPhieuNhap_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Brown;
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(487, 26);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 46);
            btnLamMoi.TabIndex = 15;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.Brown;
            btnThongKe.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnThongKe.ForeColor = Color.White;
            btnThongKe.Location = new Point(364, 26);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(94, 46);
            btnThongKe.TabIndex = 14;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 59);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 3;
            label7.Text = "Đến ngày :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 26);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 2;
            label6.Text = "Từ ngày :";
            // 
            // dtTo
            // 
            dtTo.CustomFormat = "dd/MM/yyyy";
            dtTo.Location = new Point(131, 52);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(139, 27);
            dtTo.TabIndex = 1;
            // 
            // dtFrom
            // 
            dtFrom.CustomFormat = "dd/MM/yyyy";
            dtFrom.Location = new Point(131, 19);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(139, 27);
            dtFrom.TabIndex = 0;
            // 
            // dgvBaoCao
            // 
            dgvBaoCao.AllowUserToAddRows = false;
            dgvBaoCao.AllowUserToDeleteRows = false;
            dgvBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBaoCao.BackgroundColor = Color.White;
            dgvBaoCao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBaoCao.Columns.AddRange(new DataGridViewColumn[] { colMaHD, colTenNV, colMaBan, colNgayTao, colTongTien });
            dgvBaoCao.Location = new Point(0, 462);
            dgvBaoCao.Name = "dgvBaoCao";
            dgvBaoCao.ReadOnly = true;
            dgvBaoCao.RowHeadersVisible = false;
            dgvBaoCao.RowHeadersWidth = 51;
            dgvBaoCao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBaoCao.Size = new Size(927, 130);
            dgvBaoCao.TabIndex = 19;
            // 
            // colMaHD
            // 
            colMaHD.DataPropertyName = "MaHD";
            colMaHD.HeaderText = "Mã HD";
            colMaHD.MinimumWidth = 6;
            colMaHD.Name = "colMaHD";
            colMaHD.ReadOnly = true;
            // 
            // colTenNV
            // 
            colTenNV.DataPropertyName = "TenNV";
            colTenNV.HeaderText = "Tên NV";
            colTenNV.MinimumWidth = 6;
            colTenNV.Name = "colTenNV";
            colTenNV.ReadOnly = true;
            // 
            // colMaBan
            // 
            colMaBan.DataPropertyName = "MaBan";
            colMaBan.HeaderText = "Mã bàn";
            colMaBan.MinimumWidth = 6;
            colMaBan.Name = "colMaBan";
            colMaBan.ReadOnly = true;
            // 
            // colNgayTao
            // 
            colNgayTao.DataPropertyName = "NgayTao";
            colNgayTao.HeaderText = "Ngày tạo";
            colNgayTao.MinimumWidth = 6;
            colNgayTao.Name = "colNgayTao";
            colNgayTao.ReadOnly = true;
            // 
            // colTongTien
            // 
            colTongTien.DataPropertyName = "TongTien";
            colTongTien.HeaderText = "Tổng tiền";
            colTongTien.MinimumWidth = 6;
            colTongTien.Name = "colTongTien";
            colTongTien.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(chartTopMon);
            panel3.Location = new Point(549, 128);
            panel3.Name = "panel3";
            panel3.Size = new Size(377, 222);
            panel3.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(159, 20);
            label2.TabIndex = 13;
            label2.Text = "TOP MÓN BÁN CHẠY";
            // 
            // chartTopMon
            // 
            chartTopMon.Anchor = AnchorStyles.None;
            chartArea2.Name = "ChartArea1";
            chartTopMon.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartTopMon.Legends.Add(legend2);
            chartTopMon.Location = new Point(-1, 23);
            chartTopMon.Name = "chartTopMon";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartTopMon.Series.Add(series2);
            chartTopMon.Size = new Size(377, 198);
            chartTopMon.TabIndex = 0;
            chartTopMon.Text = "chartDoanhThu";
            // 
            // frmBaoCao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 593);
            Controls.Add(panel3);
            Controls.Add(dgvBaoCao);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblTongTonKho);
            Controls.Add(lblTongPhieuNhap);
            Controls.Add(lblTongHoaDon);
            Controls.Add(lblTongDoanhThu);
            Controls.Add(label1);
            Name = "frmBaoCao";
            Text = "frmBaoCao";
            Load += frmBaoCao_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartDoanhThu).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartTopMon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTongDoanhThu;
        private Label lblTongHoaDon;
        private Label lblTongPhieuNhap;
        private Label lblTongTonKho;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvBaoCao;
        private Chart chartDoanhThu;
        private Panel panel3;
        private Chart chartTopMon;
        private Label label7;
        private Label label6;
        private DateTimePicker dtTo;
        private DateTimePicker dtFrom;
        private Button btnLamMoi;
        private Button btnThongKe;
        private DataGridViewTextBoxColumn colMaHD;
        private DataGridViewTextBoxColumn colTenNV;
        private DataGridViewTextBoxColumn colMaBan;
        private DataGridViewTextBoxColumn colNgayTao;
        private DataGridViewTextBoxColumn colTongTien;
        private Label label3;
        private Label label2;
        private Button btnFilterNam;
        private Button btnFilterThang;
        private Button btnFilterNgay;
        private Button btnXuatHoaDon;
        private Button btnXuatPhieuNhap;
    }
}
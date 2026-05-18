using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCaPhe.BUS;
using QuanLyCaPhe.Utils;

namespace QuanLyCaPhe.GUI.BanHang
{
    public partial class frmThanhToan : Form
    {
        private readonly string maBan;
        private readonly HoaDonBUS hdBUS = new HoaDonBUS();
        private readonly ChiTietHoaDonBUS ctBUS = new ChiTietHoaDonBUS();

        private decimal tongTien = 0;
        private DataTable dtHoaDonCache;

        public frmThanhToan(string maBan)
        {
            InitializeComponent();
            this.maBan = maBan;
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            lblBan.Text = "Bàn: " + maBan;
            lblNhanVien.Text = Session.TenNV + " (" + Session.ChucVu + ")";
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            LoadHoaDon();
        }
        private void LoadHoaDon()
        {
            dgvThanhToan.AutoGenerateColumns = false;
            dtHoaDonCache = ctBUS.GetByBan(maBan);     // Cache dữ liệu
            dgvThanhToan.DataSource = dtHoaDonCache;

            if (dgvThanhToan.Columns["colDonGia"] != null)
                dgvThanhToan.Columns["colDonGia"].DefaultCellStyle.Format = "#,##0";
            if (dgvThanhToan.Columns["colThanhTien"] != null)
                dgvThanhToan.Columns["colThanhTien"].DefaultCellStyle.Format = "#,##0";

            tongTien = 0;
            foreach (DataRow row in dtHoaDonCache.Rows)
            {
                tongTien += Convert.ToDecimal(row["ThanhTien"]);
            }
            lblTongTien.Text = tongTien.ToString("#,##0") + " VND";
        }

        private void txtTienKhach_TextChanged(object sender, EventArgs e)
        {
            if (txtTienKhach.Text == "")
            {
                lblTienThua.Text = "0 VNĐ";
                return;
            }

            bool check = decimal.TryParse(txtTienKhach.Text, out decimal tienKhach);

            if (!check)
                return;

            if (tienKhach > 100000000)
            {
                MessageBox.Show("Số tiền quá lớn");

                txtTienKhach.Text = "100000000";
                txtTienKhach.SelectionStart = txtTienKhach.Text.Length;

                return;
            }

            decimal tienThua = tienKhach - tongTien;

            lblTienThua.Text = tienThua.ToString("#,##0") + " VNĐ";
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string maHD = hdBUS.GetHoaDonChuaThanhToan(maBan);
            if (string.IsNullOrEmpty(maHD))
            {
                MessageBox.Show("Không tìm thấy hóa đơn!", "Lỗi");
                return;
            }

            if (!decimal.TryParse(txtTienKhach.Text, out decimal tienKhach))
            {
                MessageBox.Show("Tiền khách không hợp lệ!", "Lỗi");
                return;
            }

            if (tienKhach < tongTien)
            {
                MessageBox.Show("Khách đưa chưa đủ tiền!", "Cảnh báo");
                return;
            }

            if (hdBUS.ThanhToan(maHD))
            {
                MessageBox.Show("Thanh toán thành công!\nĐang mở xem trước hóa đơn...", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                InHoaDon();
                this.Close();
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại!", "Lỗi");
            }
        }

        private void InHoaDon()
        {
            try
            {
                PrintDocument printDoc = new PrintDocument();
                printDoc.PrintPage += PrintDocument_PrintPage;

                PrintPreviewDialog preview = new PrintPreviewDialog
                {
                    Document = printDoc,
                    WindowState = FormWindowState.Maximized,
                    Text = "Xem trước hóa đơn - Coffee Hoang Tung"
                };

                preview.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi in hóa đơn:\n" + ex.Message, "Lỗi in",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float y = 20;
            float pageWidth = ev.PageBounds.Width;

            Font titleFont = new Font("Arial", 14, FontStyle.Bold);
            Font headerFont = new Font("Arial", 11, FontStyle.Bold);
            Font normalFont = new Font("Consolas", 10);
            Font smallFont = new Font("Consolas", 9);

            // ==================== TIÊU ĐỀ (CĂN GIỮA) ====================
            string title = "COFFEE HOANG TUNG";
            SizeF titleSize = ev.Graphics.MeasureString(title, titleFont);
            ev.Graphics.DrawString(title, titleFont, Brushes.Black, 100, y);
            y += 30;

            string subtitle = "HÓA ĐƠN THANH TOÁN";
            SizeF subSize = ev.Graphics.MeasureString(subtitle, headerFont);
            ev.Graphics.DrawString(subtitle, headerFont, Brushes.Black, 100, y);
            y += 35;

            // ==================== THÔNG TIN CHUNG ====================
            ev.Graphics.DrawString($"Bàn: {maBan}", normalFont, Brushes.Black, 40, y);
            ev.Graphics.DrawString($"Nhân viên: {Session.TenNV}", normalFont, Brushes.Black, 280, y);
            y += 22;

            ev.Graphics.DrawString($"Thời gian: {DateTime.Now:dd/MM/yyyy HH:mm}", normalFont, Brushes.Black, 40, y);
            y += 35;

            // ==================== HEADER BẢNG ====================
            float colMa = 40;
            float colTen = 120;
            float colSL = 200;
            float colGia = 295;
            float colTT = 370;

            ev.Graphics.DrawString("Mã món", headerFont, Brushes.Black, colMa, y);
            ev.Graphics.DrawString("Tên món", headerFont, Brushes.Black, colTen, y);
            ev.Graphics.DrawString("Số lượng", headerFont, Brushes.Black, colSL, y);
            ev.Graphics.DrawString("Đơn giá", headerFont, Brushes.Black, colGia, y);
            ev.Graphics.DrawString("Thành tiền", headerFont, Brushes.Black, colTT, y);
            y += 20;

            // Đường kẻ ngang
            ev.Graphics.DrawLine(Pens.Black, 35, y, 480, y);
            y += 8;

            // ==================== DANH SÁCH MÓN ====================
            if (dtHoaDonCache != null)
            {
                foreach (DataRow row in dtHoaDonCache.Rows)
                {
                    string maMon = row["MaMon"].ToString();
                    string tenMon = row["TenMon"].ToString();
                    string sl = row["SoLuong"].ToString();
                    decimal dg = Convert.ToDecimal(row["DonGia"]);
                    decimal tt = Convert.ToDecimal(row["ThanhTien"]);

                    ev.Graphics.DrawString(maMon, normalFont, Brushes.Black, colMa, y);
                    ev.Graphics.DrawString(tenMon, normalFont, Brushes.Black, colTen, y);
                    ev.Graphics.DrawString(sl, normalFont, Brushes.Black, colSL + 10, y);
                    ev.Graphics.DrawString(dg.ToString("#,##0"), normalFont, Brushes.Black, colGia, y);
                    ev.Graphics.DrawString(tt.ToString("#,##0"), normalFont, Brushes.Black, colTT, y);

                    y += 24;
                }
            }

            // Đường kẻ dưới bảng
            ev.Graphics.DrawLine(Pens.Black, 35, y, 480, y);
            y += 25;

            // ==================== TỔNG TIỀN ====================
            ev.Graphics.DrawString($"TỔNG CỘNG: {tongTien.ToString("#,##0")} VND",
                headerFont, Brushes.Black, 40, y);

            y += 45;

            // Lời cảm ơn
            string thankYou = "Cảm ơn quý khách! Hẹn gặp lại ❤️";
            SizeF thankSize = ev.Graphics.MeasureString(thankYou, smallFont);
            ev.Graphics.DrawString(thankYou, smallFont, Brushes.Black, 100, y);
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTienKhach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                e.Handled = true;
        }
    }
}

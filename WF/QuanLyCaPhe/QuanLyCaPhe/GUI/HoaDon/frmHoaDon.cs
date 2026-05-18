using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCaPhe.BUS;
using QuanLyCaPhe.Utils;

namespace QuanLyCaPhe.GUI.HoaDon
{
    public partial class frmHoaDon : Form
    {
        private readonly HoaDonBUS hdBUS = new HoaDonBUS();
        private readonly ChiTietHoaDonBUS ctBUS = new ChiTietHoaDonBUS();

        private string maHDDangChon = "";
        private string maBanDangChon = "";
        private string maHDIn = "";

        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dtFrom.Format = DateTimePickerFormat.Custom;
            dtFrom.CustomFormat = "dd/MM/yyyy";

            dtTo.Format = DateTimePickerFormat.Custom;
            dtTo.CustomFormat = "dd/MM/yyyy";

            LoadHoaDon();
        }

        private void LoadHoaDon()
        {
            dgvHoaDon.AutoGenerateColumns = false;
            dgvHoaDon.DataSource = hdBUS.GetAll();
            dgvHoaDon.MultiSelect = false;

            if (dgvHoaDon.Columns["colNgayTao"] != null)
                dgvHoaDon.Columns["colNgayTao"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

            if (dgvHoaDon.Columns["colTongTien"] != null)
                dgvHoaDon.Columns["colTongTien"].DefaultCellStyle.Format = "#,##0";
        }

        private void LoadChiTiet()
        {
            if (string.IsNullOrEmpty(maHDDangChon))
                return;

            dgvChiTiet.AutoGenerateColumns = false;
            dgvChiTiet.DataSource = ctBUS.GetByMaHD(maHDDangChon);

            if (dgvChiTiet.Columns["colGia"] != null)
                dgvChiTiet.Columns["colGia"].DefaultCellStyle.Format = "#,##0";

            if (dgvChiTiet.Columns["colThanhTien"] != null)
                dgvChiTiet.Columns["colThanhTien"].DefaultCellStyle.Format = "#,##0";

            TinhTongTien();
        }

        private void TinhTongTien()
        {
            decimal tong = 0;

            foreach (DataGridViewRow row in dgvChiTiet.Rows)
            {
                if (row.Cells["colThanhTien"].Value != null)
                {
                    tong += Convert.ToDecimal(row.Cells["colThanhTien"].Value);
                }
            }

            lblTongTien.Text = "Tổng tiền: " + tong.ToString("#,##0") + " VNĐ";
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            maHDDangChon = dgvHoaDon.Rows[e.RowIndex].Cells["colMaHD"].Value?.ToString();
            maHDIn = maHDDangChon;
            maBanDangChon = dgvHoaDon.Rows[e.RowIndex].Cells["colBan"].Value?.ToString();

            LoadChiTiet();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = hdBUS.GetAll();
            string keyword = txtSearch.Text.Trim();

            DataView dv = dt.DefaultView;
            dv.RowFilter = $"MaHD LIKE '%{keyword}%' " +
                          $"OR MaBan LIKE '%{keyword}%' " +
                          $"OR MaNV LIKE '%{keyword}%' " +
                          $"OR TrangThai LIKE '%{keyword}%'";

            dgvHoaDon.DataSource = dv;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadHoaDon();
            dgvChiTiet.DataSource = null;
            lblTongTien.Text = "Tổng tiền: 0 VNĐ";

            maHDDangChon = "";
            maBanDangChon = "";
            maHDIn = "";
        }

        private void dgvHoaDon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvHoaDon.Columns[e.ColumnIndex].Name == "colTrangThai" && e.Value != null)
            {
                string trangThai = e.Value.ToString();
                e.CellStyle.ForeColor = trangThai == "Đã thanh toán" ? Color.Green : Color.Red;
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (dtFrom.Value > dtTo.Value)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtFrom.Focus();
                return;
            }

            DataTable dt = hdBUS.LocTheoNgay(dtFrom.Value, dtTo.Value);
            dgvHoaDon.DataSource = dt;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có hóa đơn trong khoảng thời gian này.", "Thông báo");
                dgvChiTiet.DataSource = null;
                lblTongTien.Text = "Tổng tiền: 0 VNĐ";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow == null) return;

            if (Session.ChucVu != "Quản lý")
            {
                MessageBox.Show("Chỉ Quản lý mới được xóa hóa đơn!", "Phân quyền");
                return;
            }

            string trangThai = dgvHoaDon.CurrentRow.Cells["colTrangThai"].Value?.ToString();
            if (trangThai == "Đã thanh toán")
            {
                MessageBox.Show("Không thể xóa hóa đơn đã thanh toán!", "Cảnh báo");
                return;
            }

            string maHD = dgvHoaDon.CurrentRow.Cells["colMaHD"].Value?.ToString();

            if (MessageBox.Show("Bạn có chắc muốn xóa hóa đơn này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                hdBUS.Xoa(maHD);
                LoadHoaDon();
                dgvChiTiet.DataSource = null;
                lblTongTien.Text = "Tổng tiền: 0 VNĐ";
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maHDIn))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần in!", "Thông báo");
                return;
            }

            if (dgvChiTiet.Rows.Count == 0)
            {
                MessageBox.Show("Hóa đơn không có dữ liệu!", "Thông báo");
                return;
            }

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs ev)
        {
            float y = 30;
            float pageWidth = ev.PageBounds.Width;

            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font bigHeaderFont = new Font("Arial", 14, FontStyle.Bold);
            Font headerFont = new Font("Arial", 11, FontStyle.Bold);
            Font normalFont = new Font("Consolas", 10);

            // ==================== TIÊU ĐỀ ====================
            ev.Graphics.DrawString("COFFEE HOANG TUNG", titleFont, Brushes.Black,
                (pageWidth - 260) / 2, y);
            y += 30;

            ev.Graphics.DrawString("HÓA ĐƠN THANH TOÁN", bigHeaderFont, Brushes.Black,
                (pageWidth - 240) / 2, y);
            y += 45;

            // ==================== THÔNG TIN HÓA ĐƠN ====================
            ev.Graphics.DrawString($"Mã hóa đơn: {maHDIn}", normalFont, Brushes.Black, 50, y);
            ev.Graphics.DrawString($"Bàn: {maBanDangChon}", normalFont, Brushes.Black, 350, y);
            y += 25;

            ev.Graphics.DrawString($"Ngày in: {DateTime.Now:dd/MM/yyyy HH:mm}", normalFont, Brushes.Black, 50, y);
            y += 40;

            // ==================== BẢNG CHI TIẾT ====================
            float left = 50;
            float colSTT = left;
            float colTen = left + 200;
            float colSL = left + 400;
            float colGia = left + 600;
            float colTT = left + 800;

            ev.Graphics.DrawString("STT", headerFont, Brushes.Black, colSTT, y);
            ev.Graphics.DrawString("Tên món", headerFont, Brushes.Black, colTen, y);
            ev.Graphics.DrawString("Số lượng", headerFont, Brushes.Black, colSL, y);
            ev.Graphics.DrawString("Đơn giá", headerFont, Brushes.Black, colGia, y);
            ev.Graphics.DrawString("Thành tiền", headerFont, Brushes.Black, colTT, y);
            y += 24;

            ev.Graphics.DrawLine(Pens.Black, left, y, pageWidth - 50, y);
            y += 10;

            int stt = 1;
            decimal tongTien = 0;

            foreach (DataGridViewRow row in dgvChiTiet.Rows)
            {
                if (row.IsNewRow) continue;

                string tenMon = row.Cells["colMon"].Value?.ToString() ?? "";
                string sl = row.Cells["colSL"].Value?.ToString() ?? "";
                decimal gia = Convert.ToDecimal(row.Cells["colGia"].Value);
                decimal thanhTien = Convert.ToDecimal(row.Cells["colThanhTien"].Value);

                ev.Graphics.DrawString(stt.ToString(), normalFont, Brushes.Black, colSTT + 5, y);
                ev.Graphics.DrawString(tenMon, normalFont, Brushes.Black, colTen, y);
                ev.Graphics.DrawString(sl, normalFont, Brushes.Black, colSL, y);
                ev.Graphics.DrawString(gia.ToString("#,##0"), normalFont, Brushes.Black, colGia, y);
                ev.Graphics.DrawString(thanhTien.ToString("#,##0"), normalFont, Brushes.Black, colTT, y);

                tongTien += thanhTien;
                stt++;
                y += 24;
            }

            ev.Graphics.DrawLine(Pens.Black, left, y, pageWidth - 50, y);
            y += 30;

            // Tổng tiền
            ev.Graphics.DrawString($"TỔNG TIỀN: {tongTien:#,##0} VND",
                headerFont, Brushes.Black, pageWidth - 280, y);

            y += 50;

            ev.Graphics.DrawString("Cảm ơn quý khách! Hẹn gặp lại ❤️",
                new Font("Arial", 10, FontStyle.Italic), Brushes.Black,
                (pageWidth - 220) / 2, y);

            y += 30;
            ev.Graphics.DrawString("Người thanh toán: __________________", normalFont, Brushes.Black, 50, y);
        }
    }
}

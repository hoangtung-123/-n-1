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
using QuanLyCaPhe.DTO;
using System.Drawing.Printing;

namespace QuanLyCaPhe.GUI.QuanLy
{
    public partial class frmPhieuNhap : Form
    {
        private readonly PhieuNhapBUS pnBUS = new PhieuNhapBUS();
        private readonly ChiTietPhieuNhapBUS ctpnBUS = new ChiTietPhieuNhapBUS();
        private readonly NguyenLieuBUS nlBUS = new NguyenLieuBUS();
        private readonly NhanVienBUS nvBUS = new NhanVienBUS();

        private DataTable dtChiTiet = new DataTable();
        private string maPNDangChon = "";
        private bool hasUnsavedChanges = false;

        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
            LoadNguyenLieu();
            LoadPhieuNhap();
            InitChiTietPhieuNhap();
            GenerateMaPN();

            dtpNgayTao.Format = DateTimePickerFormat.Custom;
            dtpNgayTao.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpNgayTao.Enabled = false;
        }

        private void InitChiTietPhieuNhap()
        {
            dtChiTiet.Columns.Clear();
            dtChiTiet.Columns.Add("MaNL", typeof(string));
            dtChiTiet.Columns.Add("TenNL", typeof(string));
            dtChiTiet.Columns.Add("SoLuong", typeof(int));
            dtChiTiet.Columns.Add("GiaNhap", typeof(decimal));
            dtChiTiet.Columns.Add("ThanhTien", typeof(decimal));

            dgvCTPN.DataSource = dtChiTiet;

            if (dgvCTPN.Columns["colGiaNhap"] != null)
                dgvCTPN.Columns["colGiaNhap"].DefaultCellStyle.Format = "#,##0";

            if (dgvCTPN.Columns["colThanhTien"] != null)
                dgvCTPN.Columns["colThanhTien"].DefaultCellStyle.Format = "#,##0";
        }

        private void LoadNhanVien()
        {
            cboNhanVien.DataSource = nvBUS.GetAll();
            cboNhanVien.DisplayMember = "TenNV";
            cboNhanVien.ValueMember = "MaNV";
            cboNhanVien.SelectedIndex = -1;
        }

        private void LoadNguyenLieu()
        {
            cboNguyenLieu.DataSource = nlBUS.GetAll();
            cboNguyenLieu.DisplayMember = "TenNL";
            cboNguyenLieu.ValueMember = "MaNL";
            cboNguyenLieu.SelectedIndex = -1;
        }

        private void LoadPhieuNhap()
        {
            dgvPhieuNhap.AutoGenerateColumns = false;
            dgvPhieuNhap.DataSource = pnBUS.GetAll();
        }

        private void GenerateMaPN()
        {
            txtMaPN.Text = pnBUS.GenerateMaPN();
        }

        private void ClearForm()
        {
            txtMaPN.Clear();
            txtGhiChu.Clear();
            cboNhanVien.SelectedIndex = -1;
            dtpNgayTao.Value = DateTime.Now;
            InitChiTietPhieuNhap();
            lblTongTien.Text = "Tổng tiền : 0 VNĐ";

            maPNDangChon = "";
            hasUnsavedChanges = false;
        }

        private void ClearChiTiet()
        {
            cboNguyenLieu.SelectedIndex = -1;
            txtSoLuong.Clear();
            txtGiaNhap.Clear();
        }

        private void TinhTongTien()
        {
            decimal tong = 0;
            foreach (DataRow row in dtChiTiet.Rows)
            {
                if (row["ThanhTien"] != DBNull.Value)
                    tong += Convert.ToDecimal(row["ThanhTien"]);
            }
            lblTongTien.Text = $"Tổng tiền : {tong:#,##0} VNĐ";
        }

        private bool ValidatePhieu()
        {
            if (!ValidateHelper.ValidateCode(txtMaPN.Text, "Mã phiếu nhập", @"^PN\d{2,}$", txtMaPN))
                return false;

            if (cboNhanVien.SelectedIndex == -1)
            {
                MessageHelper.ShowWarning("Vui lòng chọn nhân viên nhập kho!", "Lỗi validate");
                cboNhanVien.Focus();
                return false;
            }
            return true;
        }

        private bool ValidateChiTiet()
        {
            if (cboNguyenLieu.SelectedIndex == -1)
            {
                MessageHelper.ShowWarning("Vui lòng chọn nguyên liệu!", "Lỗi validate");
                cboNguyenLieu.Focus();
                return false;
            }

            if (!int.TryParse(txtSoLuong.Text.Trim(), out int sl) || sl <= 0)
            {
                MessageHelper.ShowWarning("Số lượng phải lớn hơn 0!", "Lỗi validate");
                txtSoLuong.Focus();
                return false;
            }

            if (!ValidateHelper.ValidatePrice(txtGiaNhap.Text, "Giá nhập", txtGiaNhap))
                return false;

            return true;
        }

        // ====================== BUTTONS ======================
        private void btnPhieuMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            GenerateMaPN();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateChiTiet()) return;

            string maNL = cboNguyenLieu.SelectedValue?.ToString();
            string tenNL = cboNguyenLieu.Text;
            int soLuong = Convert.ToInt32(txtSoLuong.Text);
            decimal giaNhap = Convert.ToDecimal(txtGiaNhap.Text);
            decimal thanhTien = soLuong * giaNhap;

            // Kiểm tra trùng
            foreach (DataRow row in dtChiTiet.Rows)
            {
                if (row["MaNL"].ToString() == maNL)
                {
                    row["SoLuong"] = Convert.ToInt32(row["SoLuong"]) + soLuong;
                    row["GiaNhap"] = giaNhap;
                    row["ThanhTien"] = Convert.ToDecimal(row["SoLuong"]) * giaNhap;
                    TinhTongTien();
                    ClearChiTiet();
                    hasUnsavedChanges = true;
                    return;
                }
            }

            // Thêm mới
            dtChiTiet.Rows.Add(maNL, tenNL, soLuong, giaNhap, thanhTien);
            TinhTongTien();
            ClearChiTiet();
            hasUnsavedChanges = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvCTPN.CurrentRow == null)
            {
                MessageHelper.ShowWarning("Vui lòng chọn dòng cần sửa!", "Thông báo");
                return;
            }

            if (!ValidateChiTiet()) return;

            int index = dgvCTPN.CurrentRow.Index;
            string maNL = cboNguyenLieu.SelectedValue?.ToString();

            // Kiểm tra trùng
            for (int i = 0; i < dtChiTiet.Rows.Count; i++)
            {
                if (i != index && dtChiTiet.Rows[i]["MaNL"].ToString() == maNL)
                {
                    MessageHelper.ShowWarning("Nguyên liệu này đã tồn tại trong phiếu!", "Cảnh báo");
                    return;
                }
            }

            // Cập nhật
            dtChiTiet.Rows[index]["MaNL"] = maNL;
            dtChiTiet.Rows[index]["TenNL"] = cboNguyenLieu.Text;
            dtChiTiet.Rows[index]["SoLuong"] = Convert.ToInt32(txtSoLuong.Text);
            dtChiTiet.Rows[index]["GiaNhap"] = Convert.ToDecimal(txtGiaNhap.Text);
            dtChiTiet.Rows[index]["ThanhTien"] = Convert.ToDecimal(txtSoLuong.Text) * Convert.ToDecimal(txtGiaNhap.Text);

            dgvCTPN.Refresh();
            TinhTongTien();
            ClearChiTiet();
            hasUnsavedChanges = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvCTPN.CurrentRow == null)
            {
                MessageHelper.ShowWarning("Vui lòng chọn dòng cần xóa!", "Thông báo");
                return;
            }

            if (!MessageHelper.ShowConfirmWarning("Xóa nguyên liệu này khỏi phiếu?", "Xác nhận"))
                return;

            int index = dgvCTPN.CurrentRow.Index;
            dtChiTiet.Rows.RemoveAt(index);

            TinhTongTien();
            ClearChiTiet();
            hasUnsavedChanges = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dtChiTiet.Rows.Count == 0)
            {
                MessageHelper.ShowWarning("Phiếu nhập chưa có nguyên liệu nào!", "Cảnh báo");
                return;
            }

            if (!ValidatePhieu()) return;

            if (!MessageHelper.ShowConfirm("Lưu phiếu nhập này?", "Xác nhận lưu"))
                return;

            decimal tongTien = 0;
            foreach (DataRow row in dtChiTiet.Rows)
                tongTien += Convert.ToDecimal(row["ThanhTien"]);

            PhieuNhap pn = new PhieuNhap
            {
                MaPN = txtMaPN.Text.Trim(),
                MaNV = cboNhanVien.SelectedValue?.ToString(),
                NgayTao = dtpNgayTao.Value,
                GhiChu = txtGhiChu.Text.Trim(),
                TongTien = tongTien
            };

            bool kq = (!string.IsNullOrEmpty(maPNDangChon) && maPNDangChon == pn.MaPN)
                ? pnBUS.Update(pn)
                : pnBUS.Insert(pn);

            if (!kq)
            {
                MessageHelper.ShowError("Lưu phiếu nhập thất bại!");
                return;
            }

            // Xóa chi tiết cũ và thêm mới
            ctpnBUS.DeleteByMaPN(pn.MaPN);

            foreach (DataRow row in dtChiTiet.Rows)
            {
                ChiTietPhieuNhap ct = new ChiTietPhieuNhap
                {
                    MaCTPN = ctpnBUS.GenerateMaCTPN(),
                    MaPN = pn.MaPN,
                    MaNL = row["MaNL"].ToString(),
                    SoLuong = Convert.ToInt32(row["SoLuong"]),
                    GiaNhap = Convert.ToDecimal(row["GiaNhap"])
                };
                ctpnBUS.Insert(ct);
            }

            MessageHelper.ShowSuccess("Lưu phiếu nhập thành công!");
            LoadPhieuNhap();
            maPNDangChon = pn.MaPN;
            hasUnsavedChanges = false;
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string maPN = dgvPhieuNhap.Rows[e.RowIndex].Cells["colMaPN"].Value?.ToString();
            if (string.IsNullOrEmpty(maPN)) return;

            maPNDangChon = maPN;

            DataTable dt = ctpnBUS.GetByMaPN(maPN);
            dtChiTiet.Clear();

            foreach (DataRow row in dt.Rows)
            {
                dtChiTiet.Rows.Add(
                    row["MaNL"],
                    row["TenNL"],
                    row["SoLuong"],
                    row["GiaNhap"],
                    row["ThanhTien"]);
            }

            dgvCTPN.DataSource = dtChiTiet;
            TinhTongTien();
        }

        private void dgvCTPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvCTPN.Rows[e.RowIndex];
            cboNguyenLieu.SelectedValue = row.Cells["colMaNL"].Value;
            txtSoLuong.Text = row.Cells["colSoLuong"].Value?.ToString();
            txtGiaNhap.Text = row.Cells["colGiaNhap"].Value?.ToString();
        }

        private void txtSearchPN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = pnBUS.GetAll();
                string keyword = txtSearchPN.Text.Trim().Replace("'", "''");
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"MaPN LIKE '%{keyword}%' OR TenNV LIKE '%{keyword}%'";
                dgvPhieuNhap.DataSource = dv;
            }
            catch { }
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maPNDangChon))
            {
                MessageBox.Show("Vui lòng chọn một phiếu nhập trước khi in!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtChiTiet == null || dtChiTiet.Rows.Count == 0)
            {
                MessageBox.Show("Phiếu nhập này chưa có chi tiết nguyên liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                PrintDocument printDoc = new PrintDocument();
                printDoc.PrintPage += PrintPhieuNhap_PrintPage;

                PrintPreviewDialog preview = new PrintPreviewDialog
                {
                    Document = printDoc,
                    WindowState = FormWindowState.Maximized,
                    Text = $"Phiếu Nhập - {maPNDangChon}"
                };

                preview.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi in phiếu:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintPhieuNhap_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs ev)
        {
            float y = 30;
            float pageWidth = ev.PageBounds.Width;

            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font bigHeaderFont = new Font("Arial", 14, FontStyle.Bold);
            Font headerFont = new Font("Arial", 11, FontStyle.Bold);
            Font normalFont = new Font("Consolas", 10);

            // Tiêu đề
            ev.Graphics.DrawString("COFFEE HOANG TUNG", titleFont, Brushes.Black,
                (pageWidth - 260) / 2, y);
            y += 30;

            ev.Graphics.DrawString("PHIẾU NHẬP KHO", bigHeaderFont, Brushes.Black,
                (pageWidth - 180) / 2, y);
            y += 45;

            // Thông tin phiếu
            string tenNV = cboNhanVien.Text;
            if (string.IsNullOrEmpty(tenNV) && dgvPhieuNhap.CurrentRow != null)
            {
                tenNV = dgvPhieuNhap.CurrentRow.Cells["colTenNV"]?.Value?.ToString() ?? "Không xác định";
            }

            ev.Graphics.DrawString($"Mã phiếu: {maPNDangChon}", normalFont, Brushes.Black, 50, y);
            ev.Graphics.DrawString($"Nhân viên: {tenNV}", normalFont, Brushes.Black, 350, y);
            y += 25;

            ev.Graphics.DrawString($"Ngày nhập: {dtpNgayTao.Value:dd/MM/yyyy HH:mm}", normalFont, Brushes.Black, 50, y);
            y += 40;

            // Bảng
            float left = 50;
            float colSTT = left;
            float colMa = left + 100;
            float colTen = left + 200;
            float colSL = left + 400;
            float colGia = left + 500;
            float colTT = left + 600;

            ev.Graphics.DrawString("STT", headerFont, Brushes.Black, colSTT, y);
            ev.Graphics.DrawString("Mã NL", headerFont, Brushes.Black, colMa, y);
            ev.Graphics.DrawString("Tên nguyên liệu", headerFont, Brushes.Black, colTen, y);
            ev.Graphics.DrawString("Số lượng", headerFont, Brushes.Black, colSL, y);
            ev.Graphics.DrawString("Đơn giá", headerFont, Brushes.Black, colGia, y);
            ev.Graphics.DrawString("Thành tiền", headerFont, Brushes.Black, colTT, y);
            y += 24;

            ev.Graphics.DrawLine(Pens.Black, left, y, pageWidth - 50, y);
            y += 10;

            int stt = 1;
            decimal tongTien = 0;

            foreach (DataRow row in dtChiTiet.Rows)
            {
                ev.Graphics.DrawString(stt.ToString(), normalFont, Brushes.Black, colSTT + 5, y);
                ev.Graphics.DrawString(row["MaNL"].ToString(), normalFont, Brushes.Black, colMa, y);
                ev.Graphics.DrawString(row["TenNL"].ToString(), normalFont, Brushes.Black, colTen, y);
                ev.Graphics.DrawString(row["SoLuong"].ToString(), normalFont, Brushes.Black, colSL, y);
                ev.Graphics.DrawString(Convert.ToDecimal(row["GiaNhap"]).ToString("#,##0"), normalFont, Brushes.Black, colGia, y);
                ev.Graphics.DrawString(Convert.ToDecimal(row["ThanhTien"]).ToString("#,##0"), normalFont, Brushes.Black, colTT, y);

                tongTien += Convert.ToDecimal(row["ThanhTien"]);
                stt++;
                y += 24;
            }

            ev.Graphics.DrawLine(Pens.Black, left, y, pageWidth - 50, y);
            y += 30;

            ev.Graphics.DrawString($"TỔNG TIỀN: {tongTien:#,##0} VND", headerFont, Brushes.Black, pageWidth - 280, y);

            y += 50;
            ev.Graphics.DrawString("Người lập phiếu: __________________", normalFont, Brushes.Black, 50, y);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCaPhe.BUS;
using QuanLyCaPhe.DTO;
using QuanLyCaPhe.Utils;

namespace QuanLyCaPhe.GUI.QuanLy
{
    public partial class frmKho : Form
    {
        private readonly KhoBUS khoBUS = new KhoBUS();
        private string maKhoDangChon = "";
        public frmKho()
        {
            InitializeComponent();
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            LoadTrangThai();
            LoadKho();

            dtpNgayTao.Format = DateTimePickerFormat.Custom;
            dtpNgayTao.CustomFormat = "dd/MM/yyyy";
        }

        private void LoadTrangThai()
        {
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.AddRange(new[] { "Hoạt động", "Tạm ngưng" });
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadKho()
        {
            dgvKho.AutoGenerateColumns = false;
            dgvKho.DataSource = khoBUS.GetAll();

            // Tô màu theo trạng thái
            foreach (DataGridViewRow row in dgvKho.Rows)
            {
                string trangThai = row.Cells["colTrangThai"]?.Value?.ToString();
                if (trangThai == "Hoạt động")
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                else if (trangThai == "Tạm ngưng")
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
            }
        }

        private void dgvKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvKho.Rows[e.RowIndex];
            maKhoDangChon = row.Cells["colMaKho"].Value?.ToString() ?? "";

            txtMaKho.Text = maKhoDangChon;
            txtTenKho.Text = row.Cells["colTenKho"].Value?.ToString() ?? "";
            cboTrangThai.Text = row.Cells["colTrangThai"].Value?.ToString() ?? "";

            // ==================== XỬ LÝ NGAYTAO DATETIME ====================
            if (row.Cells["colNgayTao"].Value != DBNull.Value && row.Cells["colNgayTao"].Value != null)
            {
                DateTime ngayTao = Convert.ToDateTime(row.Cells["colNgayTao"].Value);
                dtpNgayTao.Value = ngayTao;
            }
            else
            {
                dtpNgayTao.Value = DateTime.Now;
            }

            txtMaKho.Enabled = false;
            dtpNgayTao.Enabled = false;     // Không cho sửa

            LoadChiTietKho(maKhoDangChon);
        }

        private void LoadChiTietKho(string maKho)
        {
            if (string.IsNullOrEmpty(maKho))
            {
                dgvChiTietKho.DataSource = null;
                return;
            }

            dgvChiTietKho.AutoGenerateColumns = false;
            dgvChiTietKho.DataSource = khoBUS.GetChiTietKho(maKho);

            // Format cột số lượng tồn
            if (dgvChiTietKho.Columns["colSoLuongTon"] != null)
            {
                dgvChiTietKho.Columns["colSoLuongTon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvChiTietKho.Columns["colSoLuongTon"].Width = 100;
            }
        }

        private Kho GetData()
        {
            return new Kho
            {
                MaKho = txtMaKho.Text.Trim().ToUpper(),
                TenKho = txtTenKho.Text.Trim(),
                TrangThai = cboTrangThai.Text
            };
        }

        private void ClearData()
        {
            txtMaKho.Clear();
            txtTenKho.Clear();
            cboTrangThai.SelectedIndex = -1;
            dtpNgayTao.Value = DateTime.Now;

            txtMaKho.Enabled = true;
            dtpNgayTao.Enabled = false;
            maKhoDangChon = "";
            dgvChiTietKho.DataSource = null;

            txtMaKho.Focus();
        }

        private bool ValidateInput()
        {
            if (!ValidateHelper.ValidateCode(txtMaKho.Text, "Mã kho", @"^K\d{2,}$", txtMaKho))
                return false;

            if (!ValidateHelper.Require(txtTenKho.Text, "Tên kho", txtTenKho))
                return false;

            if (cboTrangThai.SelectedIndex == -1)
            {
                MessageHelper.ShowWarning("Vui lòng chọn trạng thái kho", "Lỗi validate");
                cboTrangThai.Focus();
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            if (khoBUS.Exists(txtMaKho.Text.Trim().ToUpper()))
            {
                MessageHelper.ShowWarning("Mã kho đã tồn tại!", "Thông báo");
                return;
            }

            if (khoBUS.Insert(GetData()))
            {
                MessageHelper.ShowSuccess("Thêm kho thành công!");
                LoadKho();
                ClearData();
            }
            else
            {
                MessageHelper.ShowError("Thêm kho thất bại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKho.Text))
            {
                MessageHelper.ShowWarning("Vui lòng chọn kho cần sửa!", "Thông báo");
                return;
            }

            if (!ValidateInput()) return;

            if (khoBUS.Update(GetData()))
            {
                MessageHelper.ShowSuccess("Sửa kho thành công!");
                LoadKho();
                ClearData();
            }
            else
            {
                MessageHelper.ShowError("Sửa kho thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKho.Text))
            {
                MessageHelper.ShowWarning("Vui lòng chọn kho cần xóa!", "Thông báo");
                return;
            }

            if (khoBUS.IsUsed(txtMaKho.Text))
            {
                MessageHelper.ShowWarning("Không thể xóa kho này vì đang chứa nguyên liệu!", "Cảnh báo");
                return;
            }

            if (!MessageHelper.ShowConfirmWarning($"Xóa kho {txtMaKho.Text}?", "Xác nhận xóa"))
                return;

            if (khoBUS.Delete(txtMaKho.Text))
            {
                MessageHelper.ShowSuccess("Xóa kho thành công!");
                LoadKho();
                ClearData();
            }
            else
            {
                MessageHelper.ShowError("Xóa kho thất bại!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearData();
            LoadKho();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = khoBUS.GetAll();
                string keyword = txtSearch.Text.Trim();

                if (string.IsNullOrEmpty(keyword))
                {
                    dgvKho.DataSource = dt;
                    return;
                }

                DataView dv = dt.DefaultView;
                dv.RowFilter = $"TenKho LIKE '%{keyword}%' OR MaKho LIKE '%{keyword}%'";
                dgvKho.DataSource = dv;
            }
            catch { }
        }
    }
}

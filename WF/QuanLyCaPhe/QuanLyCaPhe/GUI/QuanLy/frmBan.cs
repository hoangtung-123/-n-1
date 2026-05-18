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
    public partial class frmBan : Form
    {
        private readonly BanBUS banBUS = new BanBUS();
        private readonly KhuVucBUS kvBUS = new KhuVucBUS();
        public frmBan()
        {
            InitializeComponent();
        }

        private void frmBan_Load(object sender, EventArgs e)
        {
            LoadKhuVuc();
            LoadBan();
            LoadTrangThai();
        }

        private void LoadBan()
        {
            dgvBan.AutoGenerateColumns = false;
            DataTable dt = banBUS.GetAll();
            dgvBan.DataSource = dt;
        }

        private void LoadKhuVuc()
        {
            cboKhuVuc.DataSource = kvBUS.GetAll();
            cboKhuVuc.DisplayMember = "TenKV";
            cboKhuVuc.ValueMember = "MaKV";
            cboKhuVuc.SelectedIndex = -1;
        }

        private void LoadTrangThai()
        {
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.AddRange(new string[] { "Trống", "Đầy", "Đã đặt" });
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void dgvBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvBan.Rows[e.RowIndex];
            txtMaBan.Text = row.Cells["colMaBan"].Value?.ToString() ?? "";
            txtLoaiBan.Text = row.Cells["colLoaiBan"].Value?.ToString() ?? "";
            cboTrangThai.Text = row.Cells["colTrangThai"].Value?.ToString() ?? "";

            string maKV = row.Cells["colMaKV"].Value?.ToString();
            if (!string.IsNullOrEmpty(maKV))
                cboKhuVuc.SelectedValue = maKV;

            txtMaBan.Enabled = false;
        }

        private Ban GetData()
        {
            return new Ban
            {
                MaBan = txtMaBan.Text.Trim(),
                LoaiBan = txtLoaiBan.Text.Trim(),
                TrangThai = cboTrangThai.Text,
                MaKV = cboKhuVuc.SelectedValue?.ToString()
            };
        }

        private void ClearData()
        {
            txtMaBan.Clear();
            txtLoaiBan.Clear();
            cboTrangThai.SelectedIndex = -1;
            cboKhuVuc.SelectedIndex = -1;
            txtMaBan.Enabled = true;
            txtMaBan.Focus();
        }

        private bool ValidateInput()
        {
            if (!ValidateHelper.ValidateCode(txtMaBan.Text, "Mã bàn", @"^B\d{2,}$", txtMaBan))
                return false;

            if (!ValidateHelper.Require(txtLoaiBan.Text, "Loại bàn", txtLoaiBan))
                return false;

            if (txtLoaiBan.Text.Trim().Length < 3)
            {
                MessageHelper.ShowWarning("Loại bàn phải có ít nhất 3 ký tự", "Lỗi validate");
                txtLoaiBan.Focus();
                return false;
            }

            if (cboTrangThai.SelectedIndex == -1)
            {
                MessageHelper.ShowWarning("Vui lòng chọn trạng thái bàn", "Lỗi validate");
                cboTrangThai.Focus();
                return false;
            }

            if (cboKhuVuc.SelectedIndex == -1)
            {
                MessageHelper.ShowWarning("Vui lòng chọn khu vực", "Lỗi validate");
                cboKhuVuc.Focus();
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            if (banBUS.Exists(txtMaBan.Text.Trim().ToUpper()))
            {
                MessageHelper.ShowWarning("Mã bàn đã tồn tại!", "Thông báo");
                return;
            }

            if (banBUS.Insert(GetData()))
            {
                MessageHelper.ShowSuccess("Thêm bàn thành công!");
                LoadBan();
                ClearData();
            }
            else
            {
                MessageHelper.ShowError("Thêm bàn thất bại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaBan.Text))
            {
                MessageHelper.ShowWarning("Vui lòng chọn bàn cần sửa!", "Thông báo");
                return;
            }

            if (!ValidateInput()) return;

            if (banBUS.Update(GetData()))
            {
                MessageHelper.ShowSuccess("Sửa bàn thành công!");
                LoadBan();
                ClearData();
            }
            else
            {
                MessageHelper.ShowError("Sửa bàn thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaBan.Text))
            {
                MessageHelper.ShowWarning("Vui lòng chọn bàn cần xóa!", "Thông báo");
                return;
            }

            if (banBUS.IsUsed(txtMaBan.Text))
            {
                MessageHelper.ShowWarning("Không thể xóa bàn này vì đã có hóa đơn!", "Cảnh báo");
                return;
            }

            if (!MessageHelper.ShowConfirmWarning($"Xóa bàn {txtMaBan.Text}?", "Xác nhận xóa"))
                return;

            if (banBUS.Delete(txtMaBan.Text))
            {
                MessageHelper.ShowSuccess("Xóa bàn thành công!");
                LoadBan();
                ClearData();
            }
            else
            {
                MessageHelper.ShowError("Xóa bàn thất bại!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearData();
            LoadBan();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Lấy lại dữ liệu gốc từ BUS
                DataTable dt = banBUS.GetAll();

                string keyword = txtSearch.Text.Trim();

                if (string.IsNullOrEmpty(keyword))
                {
                    dgvBan.DataSource = dt;
                    return;
                }

                DataView dv = dt.DefaultView;

                dv.RowFilter = string.Format(
                    "MaBan LIKE '%{0}%' OR " +
                    "LoaiBan LIKE '%{0}%' OR " +
                    "TrangThai LIKE '%{0}%' OR " +
                    "TenKV LIKE '%{0}%'",
                    keyword.Replace("'", "''"));   // Tránh lỗi SQL Injection khi filter

                dgvBan.DataSource = dv;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi search: " + ex.Message);
            }
        }

        private void dgvBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

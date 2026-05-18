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
using QuanLyCaPhe.DTO;
using QuanLyCaPhe.Utils;

namespace QuanLyCaPhe.GUI.QuanLy
{
    public partial class frmKhuVuc : Form
    {
        private readonly KhuVucBUS kvBUS = new KhuVucBUS();
        private readonly NhanVienBUS nvBUS = new NhanVienBUS();
        public frmKhuVuc()
        {
            InitializeComponent();
        }

        private void frmKhuVuc_Load(object sender, EventArgs e)
        {
            LoadComboQuanLy();
            LoadDanhSachKhuVuc();
        }

        private void LoadDanhSachKhuVuc()
        {
            try
            {
                dgvKhuVuc.AutoGenerateColumns = false;
                dgvKhuVuc.DataSource = kvBUS.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách khu vực: " + ex.Message);
            }
        }

        private void LoadComboQuanLy()
        {
            try
            {
                DataTable dt = nvBUS.GetQuanLy();

                cboQuanLy.DataSource = dt;
                cboQuanLy.DisplayMember = "TenNV";
                cboQuanLy.ValueMember = "MaNV";
                cboQuanLy.SelectedIndex = -1;                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách quản lý: " + ex.Message);
            }
        }

        private void dgvKhuVuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvKhuVuc.Rows[e.RowIndex];

            txtMaKV.Text = row.Cells["colMaKV"].Value?.ToString() ?? "";
            txtTenKV.Text = row.Cells["colTenKV"].Value?.ToString() ?? "";
            txtDiaChi.Text = row.Cells["colDiaChi"].Value?.ToString() ?? "";

            // Load quản lý hiện tại vào ComboBox
            string maQuanLyHienTai = row.Cells["colMaQuanLy"].Value?.ToString();

            if (!string.IsNullOrEmpty(maQuanLyHienTai))
            {
                cboQuanLy.SelectedValue = maQuanLyHienTai;
            }
            else
            {
                cboQuanLy.SelectedIndex = -1;
            }

            txtMaKV.Enabled = false;   // Không cho sửa mã khi đang edit
        }

        private KhuVuc GetData()
        {
            return new KhuVuc
            {
                MaKV = txtMaKV.Text.Trim(),
                TenKV = txtTenKV.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim(),
                MaQuanLy = cboQuanLy.SelectedValue?.ToString()
            };
        }

        private void ClearData()
        {
            txtMaKV.Clear();
            txtTenKV.Clear();
            txtDiaChi.Clear();
            cboQuanLy.SelectedIndex = -1;
            txtMaKV.Enabled = true;
            txtMaKV.Focus();
        }

        private bool ValidateInput()
        {
            if (!ValidateHelper.ValidateCode(txtMaKV.Text, "Mã khu vực", @"^KV\d{2,}$", txtMaKV))
                return false;

            if (!ValidateHelper.Require(txtTenKV.Text, "Tên khu vực", txtTenKV))
                return false;

            if (txtTenKV.Text.Trim().Length < 3)
            {
                MessageHelper.ShowWarning("Tên khu vực phải có ít nhất 3 ký tự", "Lỗi validate");
                txtTenKV.Focus();
                return false;
            }

            if (!ValidateHelper.Require(txtDiaChi.Text, "Địa chỉ", txtDiaChi))
                return false;

            if (cboQuanLy.SelectedIndex == -1)
            {
                MessageHelper.ShowWarning("Vui lòng chọn quản lý cho khu vực", "Lỗi validate");
                cboQuanLy.Focus();
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            if (kvBUS.Exists(txtMaKV.Text.Trim().ToUpper()))
            {
                MessageHelper.ShowWarning("Mã khu vực đã tồn tại!", "Thông báo");
                return;
            }

            if (kvBUS.Insert(GetData()))
            {
                MessageHelper.ShowSuccess("Thêm khu vực thành công!");
                LoadDanhSachKhuVuc();
                ClearData();
            }
            else
            {
                MessageHelper.ShowError("Thêm khu vực thất bại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKV.Text))
            {
                MessageHelper.ShowWarning("Vui lòng chọn khu vực cần sửa", "Thông báo");
                return;
            }

            if (!ValidateInput()) return;

            if (kvBUS.Update(GetData()))
            {
                MessageHelper.ShowSuccess("Sửa khu vực thành công!");
                LoadDanhSachKhuVuc();
                ClearData();
            }
            else
            {
                MessageHelper.ShowError("Sửa khu vực thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKV.Text))
            {
                MessageHelper.ShowWarning("Vui lòng chọn khu vực cần xóa", "Thông báo");
                return;
            }

            if (kvBUS.IsUsed(txtMaKV.Text))
            {
                MessageHelper.ShowWarning("Không thể xóa khu vực này vì đang có nhân viên hoặc bàn!", "Cảnh báo");
                return;
            }

            if (!MessageHelper.ShowConfirmWarning($"Xóa khu vực {txtMaKV.Text}?", "Xác nhận xóa"))
                return;

            if (kvBUS.Delete(txtMaKV.Text))
            {
                MessageHelper.ShowSuccess("Xóa khu vực thành công!");
                LoadDanhSachKhuVuc();
                ClearData();
            }
            else
            {
                MessageHelper.ShowError("Xóa khu vực thất bại!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearData();
            LoadDanhSachKhuVuc();
        }                  

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = kvBUS.GetAll();

                string keyword = txtSearch.Text.Trim();

                if (string.IsNullOrEmpty(keyword))
                {
                    dgvKhuVuc.DataSource = dt;
                    return;
                }

                DataView dv = dt.DefaultView;
                dv.RowFilter = $"TenKV LIKE '%{keyword}%' OR MaKV LIKE '%{keyword}%' OR DiaChi LIKE '%{keyword}%'";

                dgvKhuVuc.DataSource = dv;
            }
            catch
            {
                // Im lặng hoặc thông báo nếu cần
            }
        }
    }
}

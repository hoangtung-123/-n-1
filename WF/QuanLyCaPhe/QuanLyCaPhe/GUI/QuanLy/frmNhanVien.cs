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
using QuanLyCaPhe.Utils;
using QuanLyCaPhe.DTO;
using QuanLyCaPhe.DAL;


namespace QuanLyCaPhe.GUI.QuanLy
{
    public partial class frmNhanVien : Form
    {
        private readonly NhanVienBUS nvBUS = new NhanVienBUS();
        private readonly KhuVucBUS kvBUS = new KhuVucBUS();

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadKhuVuc();
            LoadNhanVien();

            // Khởi tạo ComboBox Chức vụ
            cboChucVu.Items.Add("Quản lý");
            cboChucVu.Items.Add("Nhân viên");
            cboChucVu.DropDownStyle = ComboBoxStyle.DropDownList;

            txtMatKhau.PasswordChar = '*';
        }

        private void LoadNhanVien()
        {
            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.DataSource = nvBUS.GetAll();
        }

        private void LoadKhuVuc()
        {
            cboKhuVuc.DataSource = kvBUS.GetAll();
            cboKhuVuc.DisplayMember = "TenKV";
            cboKhuVuc.ValueMember = "MaKV";
            cboKhuVuc.SelectedIndex = -1;
            cboKhuVuc.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

            txtMaNV.Text = row.Cells["colMaNV"].Value?.ToString() ?? "";
            txtTenNV.Text = row.Cells["colTenNV"].Value?.ToString() ?? "";
            txtSDT.Text = row.Cells["colSDT"].Value?.ToString() ?? "";
            txtDiaChi.Text = row.Cells["colDiaChi"].Value?.ToString() ?? "";
            cboChucVu.Text = row.Cells["colChucVu"].Value?.ToString() ?? "";

            // Load Khu vực
            string maKV = row.Cells["colMaKV"].Value?.ToString();
            if (!string.IsNullOrEmpty(maKV))
                cboKhuVuc.SelectedValue = maKV;
            else
                cboKhuVuc.SelectedIndex = -1;

            txtTenDangNhap.Text = row.Cells["colTenDangNhap"].Value?.ToString() ?? "";
            txtMatKhau.Text = row.Cells["colMatKhau"].Value?.ToString() ?? "";

            txtMaNV.Enabled = false;
        }

        private NhanVien GetData()
        {
            return new NhanVien
            {
                MaNV = txtMaNV.Text.Trim(),
                TenNV = txtTenNV.Text.Trim(),
                SDT = txtSDT.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim(),
                ChucVu = cboChucVu.Text,
                MaKV = cboKhuVuc.SelectedValue?.ToString(),
                TenDangNhap = txtTenDangNhap.Text.Trim(),
                MatKhau = txtMatKhau.Text.Trim()
            };
        }

        private void ClearData()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();

            cboChucVu.SelectedIndex = -1;
            cboKhuVuc.SelectedIndex = -1;

            txtMaNV.Enabled = true;
            txtMaNV.Focus();
        }

        private bool ValidateInput()
        {
            // Mã nhân viên
            if (!ValidateHelper.ValidateCode(txtMaNV.Text, "Mã nhân viên", @"^NV\d{2,}$", txtMaNV))
                return false;

            // Tên nhân viên
            if (!ValidateHelper.Require(txtTenNV.Text, "Tên nhân viên", txtTenNV))
                return false;
            if (txtTenNV.Text.Trim().Length < 2 || txtTenNV.Text.Trim().Length > 100)
            {
                MessageHelper.ShowWarning("Tên nhân viên phải từ 2 đến 100 ký tự", "Lỗi validate");
                txtTenNV.Focus();
                return false;
            }

            // Số điện thoại
            if (!ValidateHelper.ValidatePhone(txtSDT.Text, txtSDT))
                return false;

            // Địa chỉ
            if (!ValidateHelper.Require(txtDiaChi.Text, "Địa chỉ", txtDiaChi))
                return false;
            if (txtDiaChi.Text.Trim().Length > 200)
            {
                MessageHelper.ShowWarning("Địa chỉ tối đa 200 ký tự", "Lỗi validate");
                txtDiaChi.Focus();
                return false;
            }

            // Tên đăng nhập
            if (!ValidateHelper.ValidateUsername(txtTenDangNhap.Text, txtTenDangNhap))
                return false;

            // Mật khẩu
            if (!ValidateHelper.ValidatePassword(txtMatKhau.Text, txtMatKhau))
                return false;

            // Chức vụ & Khu vực
            if (cboChucVu.SelectedIndex == -1)
            {
                MessageHelper.ShowWarning("Vui lòng chọn chức vụ", "Lỗi validate");
                cboChucVu.Focus();
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

            if (nvBUS.Exists(txtMaNV.Text))
            {
                MessageHelper.ShowWarning("Mã NV đã tồn tại", "Thông báo");
                return;
            }
            if (nvBUS.ExistsUsername(txtTenDangNhap.Text))
            {
                MessageHelper.ShowWarning("Tên đăng nhập đã tồn tại", "Thông báo");
                return;
            }
            if (nvBUS.ExistsSDT(txtSDT.Text))
            {
                MessageHelper.ShowWarning("SĐT đã tồn tại", "Thông báo");
                return;
            }

            if (nvBUS.Insert(GetData()))
            {
                MessageHelper.ShowSuccess("Thêm nhân viên thành công!");
                LoadNhanVien();
                ClearData();
            }
            else
            {
                MessageHelper.ShowError("Thêm nhân viên thất bại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageHelper.ShowWarning("Vui lòng chọn nhân viên cần sửa", "Thông báo");
                return;
            }

            if (!ValidateInput()) return;

            if (nvBUS.ExistsSDTUpdate(txtSDT.Text.Trim(), txtMaNV.Text.Trim()))
            {
                MessageHelper.ShowWarning("SĐT đã tồn tại", "Thông báo");
                return;
            }
            if (nvBUS.ExistsUsernameUpdate(txtTenDangNhap.Text.Trim(), txtMaNV.Text.Trim()))
            {
                MessageHelper.ShowWarning("Tên đăng nhập đã tồn tại", "Thông báo");
                return;
            }

            if (nvBUS.Update(GetData()))
            {
                MessageHelper.ShowSuccess("Sửa nhân viên thành công!");
                LoadNhanVien();
                ClearData();
            }
            else
            {
                MessageHelper.ShowError("Sửa nhân viên thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageHelper.ShowWarning("Vui lòng chọn nhân viên cần xóa", "Thông báo");
                return;
            }

            if (txtMaNV.Text == Session.MaNV)
            {
                MessageHelper.ShowWarning("Không thể xóa tài khoản đang đăng nhập", "Cảnh báo");
                return;
            }

            if (!MessageHelper.ShowConfirmWarning("Xóa nhân viên này?", "Xác nhận xóa"))
                return;

            if (nvBUS.IsUsed(txtMaNV.Text))
            {
                MessageHelper.ShowWarning("Nhân viên đã phát sinh dữ liệu, không thể xóa", "Cảnh báo");
                return;
            }

            if (nvBUS.Delete(txtMaNV.Text))
            {
                MessageHelper.ShowSuccess("Xóa nhân viên thành công!");
                LoadNhanVien();
                ClearData();
            }
            else
            {
                MessageHelper.ShowError("Xóa nhân viên thất bại!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearData();
            LoadNhanVien();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = nvBUS.GetAll();
                string keyword = txtSearch.Text.Trim().Replace("'", "''");

                DataView dv = dt.DefaultView;
                dv.RowFilter = $"MaNV LIKE '%{keyword}%' " +
                              $"OR TenNV LIKE '%{keyword}%' " +
                              $"OR SDT LIKE '%{keyword}%' " +
                              $"OR ChucVu LIKE '%{keyword}%'";
                dgvNhanVien.DataSource = dv;
            }
            catch { }
        }
    }
}

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
    public partial class frmNguyenLieu : Form
    {
        private readonly NguyenLieuBUS nlBUS = new NguyenLieuBUS();
        public frmNguyenLieu()
        {
            InitializeComponent();
        }

        private void frmNguyenLieu_Load(object sender, EventArgs e)
        {
            LoadNguyenLieu();
        }

        private void LoadNguyenLieu()
        {
            dgvNguyenLieu.AutoGenerateColumns = false;
            DataTable dt = nlBUS.GetAll();
            dgvNguyenLieu.DataSource = dt;

            if (dgvNguyenLieu.Columns["colGia"] != null)
            {
                dgvNguyenLieu.Columns["colGia"].DefaultCellStyle.Format = "#,##0";           
            }
        }

        private void dgvNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvNguyenLieu.Rows[e.RowIndex];

            txtMaNL.Text = row.Cells["colMaNL"].Value?.ToString() ?? "";
            txtTenNL.Text = row.Cells["colTenNL"].Value?.ToString() ?? "";
            txtGia.Text = row.Cells["colGia"].Value?.ToString() ?? "";

            txtMaNL.Enabled = false;
        }

        private NguyenLieu GetData()
        {
            return new NguyenLieu
            {
                MaNL = txtMaNL.Text.Trim().ToUpper(),
                TenNL = txtTenNL.Text.Trim(),
                Gia = decimal.TryParse(txtGia.Text.Trim(), out decimal gia) ? gia : 0
            };
        }

        private void ClearData()
        {
            txtMaNL.Clear();
            txtTenNL.Clear();
            txtGia.Clear();
            txtMaNL.Enabled = true;
            txtMaNL.Focus();
        }

        private bool ValidateInput()
        {
            // Mã nguyên liệu
            if (!ValidateHelper.ValidateCode(txtMaNL.Text, "Mã nguyên liệu", @"^NL\d{2,}$", txtMaNL))
                return false;

            // Tên nguyên liệu
            if (!ValidateHelper.Require(txtTenNL.Text, "Tên nguyên liệu", txtTenNL))
                return false;

            if (txtTenNL.Text.Trim().Length < 3 || txtTenNL.Text.Trim().Length > 100)
            {
                MessageHelper.ShowWarning("Tên nguyên liệu phải từ 3 đến 100 ký tự", "Lỗi validate");
                txtTenNL.Focus();
                return false;
            }

            // Giá
            if (!ValidateHelper.ValidatePrice(txtGia.Text, "Giá nguyên liệu", txtGia))
                return false;

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            if (nlBUS.Exists(txtMaNL.Text.Trim().ToUpper()))
            {
                MessageHelper.ShowWarning("Mã nguyên liệu đã tồn tại!", "Thông báo");
                return;
            }

            if (nlBUS.Insert(GetData()))
            {
                MessageHelper.ShowSuccess("Thêm nguyên liệu thành công!");
                LoadNguyenLieu();
                ClearData();
            }
            else
            {
                MessageHelper.ShowError("Thêm nguyên liệu thất bại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNL.Text))
            {
                MessageHelper.ShowWarning("Vui lòng chọn nguyên liệu cần sửa", "Thông báo");
                return;
            }

            if (!ValidateInput()) return;

            if (nlBUS.Update(GetData()))
            {
                MessageHelper.ShowSuccess("Sửa nguyên liệu thành công!");
                LoadNguyenLieu();
                ClearData();
            }
            else
            {
                MessageHelper.ShowError("Sửa nguyên liệu thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNL.Text))
            {
                MessageHelper.ShowWarning("Vui lòng chọn nguyên liệu cần xóa", "Thông báo");
                return;
            }

            if (nlBUS.IsUsed(txtMaNL.Text))
            {
                MessageHelper.ShowWarning("Không thể xóa nguyên liệu này vì đang được sử dụng trong kho hoặc phiếu nhập!", "Cảnh báo");
                return;
            }

            if (!MessageHelper.ShowConfirmWarning($"Xóa nguyên liệu {txtMaNL.Text}?", "Xác nhận xóa"))
                return;

            if (nlBUS.Delete(txtMaNL.Text))
            {
                MessageHelper.ShowSuccess("Xóa nguyên liệu thành công!");
                LoadNguyenLieu();
                ClearData();
            }
            else
            {
                MessageHelper.ShowError("Xóa nguyên liệu thất bại!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearData();
            LoadNguyenLieu();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = nlBUS.GetAll();
                string keyword = txtSearch.Text.Trim();

                if (string.IsNullOrEmpty(keyword))
                {
                    dgvNguyenLieu.DataSource = dt;
                    return;
                }

                DataView dv = dt.DefaultView;
                dv.RowFilter = $"TenNL LIKE '%{keyword}%' OR MaNL LIKE '%{keyword}%'";
                dgvNguyenLieu.DataSource = dv;
            }
            catch { }
        }
    }
}

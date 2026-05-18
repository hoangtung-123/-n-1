using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCaPhe.DTO;
using QuanLyCaPhe.BUS;
using System.Text.RegularExpressions;
using QuanLyCaPhe.Utils;

namespace QuanLyCaPhe.GUI.QuanLy
{
    public partial class frmMon : Form
    {
        private readonly MonBUS monBUS = new MonBUS();

        public frmMon()
        {
            InitializeComponent();
        }

        private void frmMon_Load(object sender, EventArgs e)
        {
            LoadMon();
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dgvMon.AutoGenerateColumns = false;
            if (dgvMon.Columns["colDonGia"] != null)
            {
                dgvMon.Columns["colDonGia"].DefaultCellStyle.Format = "#,##0";
                dgvMon.Columns["colDonGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void LoadMon()
        {
            dgvMon.DataSource = monBUS.GetAll();
        }

        private void dgvMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvMon.Rows[e.RowIndex];

            txtMaMon.Text = row.Cells["colMaMon"].Value?.ToString() ?? "";
            txtTenMon.Text = row.Cells["colTenMon"].Value?.ToString() ?? "";
            txtDonGia.Text = row.Cells["colDonGia"].Value?.ToString() ?? "";
            cboTrangThai.Text = row.Cells["colTrangThai"].Value?.ToString() ?? "";

            txtMaMon.Enabled = false;
        }

        private Mon GetData()
        {
            return new Mon
            {
                MaMon = txtMaMon.Text.Trim(),
                TenMon = txtTenMon.Text.Trim(),
                DonGia = decimal.Parse(txtDonGia.Text.Trim()),
                TrangThai = cboTrangThai.Text
            };
        }

        private void ClearData()
        {
            txtMaMon.Clear();
            txtTenMon.Clear();
            txtDonGia.Clear();
            cboTrangThai.SelectedIndex = -1;

            txtMaMon.Enabled = true;
            txtMaMon.Focus();
        }

        private bool ValidateInput()
        {
            // Mã món
            if (!ValidateHelper.ValidateCode(txtMaMon.Text, "Mã món", @"^M\d{2,}$", txtMaMon))
                return false;

            // Tên món
            if (!ValidateHelper.Require(txtTenMon.Text, "Tên món", txtTenMon))
                return false;
            if (txtTenMon.Text.Trim().Length < 2 || txtTenMon.Text.Trim().Length > 100)
            {
                MessageHelper.ShowWarning("Tên món phải từ 2 đến 100 ký tự", "Lỗi validate");
                txtTenMon.Focus();
                return false;
            }

            // Đơn giá
            if (!ValidateHelper.ValidatePrice(txtDonGia.Text, "Đơn giá", txtDonGia))
                return false;

            // Trạng thái
            if (string.IsNullOrWhiteSpace(cboTrangThai.Text))
            {
                MessageHelper.ShowWarning("Vui lòng chọn trạng thái món", "Lỗi validate");
                cboTrangThai.Focus();
                return false;
            }

            return true;
        }

        // ====================== BUTTON EVENTS ======================
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            if (monBUS.Exists(txtMaMon.Text.Trim()))
            {
                MessageHelper.ShowWarning("Mã món đã tồn tại", "Thông báo");
                return;
            }

            if (monBUS.Insert(GetData()))
            {
                MessageHelper.ShowSuccess("Thêm món thành công!");
                LoadMon();
                ClearData();
            }
            else
            {
                MessageHelper.ShowError("Thêm món thất bại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaMon.Text))
            {
                MessageHelper.ShowWarning("Vui lòng chọn món cần sửa", "Thông báo");
                return;
            }

            if (!ValidateInput()) return;

            if (monBUS.Update(GetData()))
            {
                MessageHelper.ShowSuccess("Sửa món thành công!");
                LoadMon();
                ClearData();
            }
            else
            {
                MessageHelper.ShowError("Sửa món thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaMon.Text))
            {
                MessageHelper.ShowWarning("Vui lòng chọn món cần ngừng bán", "Thông báo");
                return;
            }

            if (!MessageHelper.ShowConfirm("Chuyển món này sang trạng thái 'Hết món'?", "Xác nhận"))
                return;

            Mon mon = GetData();
            mon.TrangThai = "Hết món";

            if (monBUS.Update(mon))
            {
                MessageHelper.ShowSuccess("Đã chuyển sang trạng thái Hết món!");
                LoadMon();
                ClearData();
            }
            else
            {
                MessageHelper.ShowError("Thao tác thất bại!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearData();
            LoadMon();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = monBUS.GetAll();
                string keyword = txtSearch.Text.Trim().Replace("'", "''");

                DataView dv = dt.DefaultView;
                dv.RowFilter = $"TenMon LIKE '%{keyword}%'";
                dgvMon.DataSource = dv;
            }
            catch { }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

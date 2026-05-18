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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QuanLyCaPhe.GUI.BanHang
{
    public partial class frmBanHang : Form
    {
        private readonly BanBUS banBUS = new BanBUS();
        private readonly MonBUS monBUS = new MonBUS();
        private readonly HoaDonBUS hdBUS = new HoaDonBUS();
        private readonly ChiTietHoaDonBUS ctBUS = new ChiTietHoaDonBUS();

        private string maBanDangChon = "";
        private Button currentBan = null;

        public frmBanHang()
        {
            InitializeComponent();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            LoadBan();
            LoadMon();
            LoadHoaDon();
        }
        private void LoadBan()
        {
            flowTang1.Controls.Clear();
            flowTang2.Controls.Clear();
            flowSanVuon.Controls.Clear();

            DataTable dt = banBUS.GetAll();

            foreach (DataRow row in dt.Rows)
            {
                Button btn = new Button
                {
                    Width = 100,
                    Height = 63,
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 0 },
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Cursor = Cursors.Hand
                };

                string maBan = row["MaBan"].ToString();
                string trangThai = row["TrangThai"].ToString();
                string maKV = row["MaKV"].ToString();

                btn.Text = maBan + Environment.NewLine + trangThai;
                btn.Tag = maBan;

                // Màu theo trạng thái
                switch (trangThai)
                {
                    case "Trống":
                        btn.BackColor = Color.LightGreen;
                        btn.ForeColor = Color.Black;
                        break;
                    case "Đã đặt":
                        btn.BackColor = Color.Orange;
                        btn.ForeColor = Color.White;
                        break;
                    case "Đầy":
                        btn.BackColor = Color.IndianRed;
                        btn.ForeColor = Color.White;
                        break;
                    default:
                        btn.BackColor = Color.Gray;
                        btn.ForeColor = Color.White;
                        break;
                }

                btn.Click += BtnBan_Click;

                // Phân khu vực
                if (maKV == "KV01")
                    flowTang1.Controls.Add(btn);
                else if (maKV == "KV02")
                    flowTang2.Controls.Add(btn);
                else
                    flowSanVuon.Controls.Add(btn);
            }
        }

        private void BtnBan_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            maBanDangChon = btn.Tag.ToString();

            // Reset màu bàn cũ
            if (currentBan != null)
            {
                string oldTrangThai = GetTrangThaiFromButton(currentBan);
                SetButtonColor(currentBan, oldTrangThai);
            }

            // Highlight bàn đang chọn
            btn.BackColor = Color.DarkOrange;
            btn.ForeColor = Color.White;
            currentBan = btn;

            LoadHoaDon();
        }

        private string GetTrangThaiFromButton(Button btn)
        {
            if (btn.Text.Contains(Environment.NewLine))
            {
                return btn.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None)[1];
            }
            return "Trống";
        }

        private void SetButtonColor(Button btn, string trangThai)
        {
            switch (trangThai)
            {
                case "Trống":
                    btn.BackColor = Color.LightGreen;
                    btn.ForeColor = Color.Black;
                    break;
                case "Đã đặt":
                    btn.BackColor = Color.Orange;
                    btn.ForeColor = Color.White;
                    break;
                case "Đầy":
                    btn.BackColor = Color.IndianRed;
                    btn.ForeColor = Color.White;
                    break;
                default:
                    btn.BackColor = Color.Gray;
                    btn.ForeColor = Color.White;
                    break;
            }
        }
        private void LoadMon()
        {
            dgvMon.AutoGenerateColumns = false;
            dgvMon.DataSource = monBUS.GetAll();
            dgvMon.AllowUserToAddRows = false;
            dgvMon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (dgvMon.Columns["colDonGia"] != null)
                dgvMon.Columns["colDonGia"].DefaultCellStyle.Format = "#,##0";

            // Tô màu món hết hàng
            foreach (DataGridViewRow row in dgvMon.Rows)
            {
                string trangThai = row.Cells["colTrangThai"]?.Value?.ToString()?.Trim();

                if (trangThai == "Hết món" || trangThai == "Hết hàng")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                    row.DefaultCellStyle.ForeColor = Color.DarkRed;
                    row.DefaultCellStyle.Font = new Font(dgvMon.Font, FontStyle.Strikeout);
                    row.ReadOnly = true;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                    row.ReadOnly = false;
                }
            }
        }

        private void LoadHoaDon()
        {
            if (string.IsNullOrEmpty(maBanDangChon))
                return;

            DataTable dt = ctBUS.GetByBan(maBanDangChon);

            dgvCTHD.AutoGenerateColumns = false;
            dgvCTHD.DataSource = dt;

            if (dgvCTHD.Columns["colGiaHD"] != null)
                dgvCTHD.Columns["colGiaHD"].DefaultCellStyle.Format = "#,##0";

            if (dgvCTHD.Columns["colThanhTien"] != null)
                dgvCTHD.Columns["colThanhTien"].DefaultCellStyle.Format = "#,##0";

            TinhTongTien();

            //btnThanhToan.Enabled = (dt.Rows.Count > 0);
        }

        private void TinhTongTien()
        {
            decimal tong = 0;

            foreach (DataGridViewRow row in dgvCTHD.Rows)
            {
                if (row.Cells["colThanhTien"].Value != null)
                    tong += Convert.ToDecimal(row.Cells["colThanhTien"].Value);
            }

            lblTongTien.Text = "Tổng tiền: " + tong.ToString("#,##0") + " VNĐ";
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = monBUS.GetAll();
            string keyword = txtSearch.Text.Trim().ToLower();

            DataView dv = dt.DefaultView;
            dv.RowFilter = $"TenMon LIKE '%{keyword}%'";

            dgvMon.DataSource = dv;
        }

        private void dgvMon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (string.IsNullOrEmpty(maBanDangChon))
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi thêm món!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvMon.Rows[e.RowIndex];
            string maMon = row.Cells["colMaMon"].Value?.ToString();
            string tenMon = row.Cells["colTenMon"].Value?.ToString();
            string trangThai = row.Cells["colTrangThai"].Value?.ToString();

            if (string.IsNullOrEmpty(maMon)) return;

            if (trangThai == "Hết món" || trangThai == "Hết hàng")
            {
                MessageBox.Show($"Món '{tenMon}' hiện đang hết hàng!", "Không thể thêm",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = ctBUS.ThemMon(maBanDangChon, maMon);
            if (success)
            {
                LoadHoaDon();
                LoadBan();
            }
            else
            {
                MessageBox.Show("Không thể thêm món. Vui lòng thử lại!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            if (dgvCTHD.CurrentRow == null) return;
            string maMon = dgvCTHD.CurrentRow.Cells["colMaMonHD"].Value?.ToString();
            if (string.IsNullOrEmpty(maMon)) return;

            ctBUS.TangSL(maBanDangChon, maMon);
            LoadHoaDon();
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            if (dgvCTHD.CurrentRow == null) return;
            string maMon = dgvCTHD.CurrentRow.Cells["colMaMonHD"].Value?.ToString();
            if (string.IsNullOrEmpty(maMon)) return;

            ctBUS.GiamSL(maBanDangChon, maMon);
            LoadHoaDon();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvCTHD.CurrentRow == null) return;

            string maMon = dgvCTHD.CurrentRow.Cells["colMaMonHD"].Value?.ToString();
            if (string.IsNullOrEmpty(maMon)) return;

            ctBUS.XoaMon(maBanDangChon, maMon);
            LoadHoaDon();
        }

        private void btnThanhToan_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maBanDangChon))
            {
                MessageBox.Show("Vui lòng chọn bàn!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = ctBUS.GetByBan(maBanDangChon);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Hóa đơn chưa có món nào. Vui lòng thêm món trước khi thanh toán!",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmThanhToan f = new frmThanhToan(maBanDangChon);
            f.ShowDialog();

            LoadBan();
            LoadHoaDon();
        }
    }
}

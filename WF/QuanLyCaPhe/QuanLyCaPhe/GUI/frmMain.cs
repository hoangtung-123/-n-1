using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCaPhe.GUI;
using QuanLyCaPhe.Utils;
using QuanLyCaPhe.GUI.QuanLy;
using QuanLyCaPhe.GUI.BanHang;
using QuanLyCaPhe.GUI.HoaDon;
using QuanLyCaPhe.GUI.BaoCao;

namespace QuanLyCaPhe.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            pnQuanLy.Visible = !pnQuanLy.Visible;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnLeft.Width == 220)
            {
                pnLeft.Width = 0;
            }
            else
            {
                pnLeft.Width = 220;
            }
        }

        private void LoadForm(Form f)
        {
            pnMain.Controls.Clear();

            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;

            pnMain.Controls.Add(f);

            f.Show();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            ActivateButton(btnBanHang);

            LoadForm(new frmBanHang());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(btnNhanVien);

            LoadForm(new frmNhanVien());
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            ActivateButton(btnBaoCao);

            LoadForm(new frmBaoCao());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            ActivateButton(btnHoaDon);

            LoadForm(new frmHoaDon());
        }

        private void btnMon_Click(object sender, EventArgs e)
        {
            ActivateButton(btnMon);

            LoadForm(new frmMon());
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            ActivateButton(btnBan);

            LoadForm(new frmBan());
        }

        private void btnKhuVuc_Click(object sender, EventArgs e)
        {
            ActivateButton(btnKhuVuc);

            LoadForm(new frmKhuVuc());
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            ActivateButton(btnKho);

            LoadForm(new frmKho());
        }

        private void btnNguyenLieu_Click(object sender, EventArgs e)
        {
            ActivateButton(btnNguyenLieu);

            LoadForm(new frmNguyenLieu());
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            ActivateButton(btnPhieuNhap);

            LoadForm(new frmPhieuNhap());
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.MaNV = null;
            Session.TenNV = null;
            Session.ChucVu = null;

            frmLogin f = new frmLogin();

            this.Hide();

            f.Show();
        }

        private void PhanQuyen()
        {
            lblUser.Text = $"{Session.TenNV} ({Session.ChucVu})";

            if (Session.ChucVu == "Nhân viên")
            {
                btnQuanLy.Visible = false;
                pnQuanLy.Visible = false;

                btnBaoCao.Visible = false;
            }
        }

        Button currentBtn;

        private void ActivateButton(Button btn)
        {
            // reset nút cũ
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.RosyBrown;
                currentBtn.ForeColor = Color.White;
            }

            // active nút mới

            btn.ForeColor = Color.Brown;

            currentBtn = btn;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            PhanQuyen();

            ActivateButton(btnBanHang);
        }
    }
}

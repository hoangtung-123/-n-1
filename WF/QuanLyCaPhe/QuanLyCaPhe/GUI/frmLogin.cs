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

namespace QuanLyCaPhe.GUI
{
    public partial class frmLogin : Form
    {
        LoginBUS bus = new LoginBUS();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();

            // VALIDATE
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu");
                return;
            }

            var nv = bus.Login(user, pass);

            if (nv != null)
            {
                // LƯU SESSION
                Session.MaNV = nv.MaNV;
                Session.TenNV = nv.TenNV;
                Session.ChucVu = nv.ChucVu;

                MessageBox.Show("Đăng nhập thành công");

                frmMain f = new frmMain();
                f.Show();

                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = chkShowPass.Checked ? '\0' : '*';
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}

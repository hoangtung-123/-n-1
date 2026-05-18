using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using QuanLyCaPhe.Utils;

namespace QuanLyCaPhe.Utils
{
    /// <summary>
    /// Helper class chứa các hàm validate dùng chung cho toàn dự án
    /// </summary>
    public static class ValidateHelper
    {
        /// <summary>
        /// Kiểm tra chuỗi không được rỗng
        /// </summary>
        public static bool Require(string value, string fieldName, Control control = null)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                MessageBox.Show($"{fieldName} không được để trống!", "Lỗi validate",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                control?.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Validate Mã theo định dạng (NV01, M01, B01, K01, PN01...)
        /// </summary>
        public static bool ValidateCode(string code, string fieldName, string pattern, Control control = null)
        {
            if (!Require(code, fieldName, control))
                return false;

            if (!Regex.IsMatch(code.Trim(), pattern))
            {
                MessageBox.Show($"{fieldName} phải đúng định dạng!\nVí dụ: {GetExample(pattern)}",
                    "Lỗi validate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control?.Focus();
                return false;
            }
            return true;
        }

        private static string GetExample(string pattern)
        {
            if (pattern.Contains("NV")) return "NV01";
            if (pattern.Contains("M")) return "M01";
            if (pattern.Contains("B")) return "B01";
            if (pattern.Contains("K")) return "K01";
            if (pattern.Contains("PN")) return "PN01";
            return "ABC123";
        }

        /// <summary>
        /// Validate số điện thoại Việt Nam (10 số, bắt đầu bằng 0)
        /// </summary>
        public static bool ValidatePhone(string phone, Control control = null)
        {
            if (!Require(phone, "Số điện thoại", control))
                return false;

            if (!Regex.IsMatch(phone.Trim(), @"^0\d{9}$"))
            {
                MessageBox.Show("SĐT phải gồm 10 số và bắt đầu bằng số 0!",
                    "Lỗi validate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control?.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Validate tên đăng nhập
        /// </summary>
        public static bool ValidateUsername(string username, Control control = null)
        {
            if (!Require(username, "Tên đăng nhập", control))
                return false;

            if (!Regex.IsMatch(username.Trim(), @"^[a-zA-Z0-9_]+$"))
            {
                MessageBox.Show("Tên đăng nhập chỉ được chứa chữ, số và dấu gạch dưới (_)",
                    "Lỗi validate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control?.Focus();
                return false;
            }

            if (username.Trim().Length < 4 || username.Trim().Length > 50)
            {
                MessageBox.Show("Tên đăng nhập phải từ 4 đến 50 ký tự",
                    "Lỗi validate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control?.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Validate mật khẩu
        /// </summary>
        public static bool ValidatePassword(string password, Control control = null)
        {
            if (!Require(password, "Mật khẩu", control))
                return false;

            if (password.Length < 4 || password.Length > 100)
            {
                MessageBox.Show("Mật khẩu phải từ 4 đến 100 ký tự",
                    "Lỗi validate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control?.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Validate giá tiền > 0
        /// </summary>
        public static bool ValidatePrice(string priceStr, string fieldName = "Đơn giá", Control control = null)
        {
            if (!Require(priceStr, fieldName, control))
                return false;

            if (!decimal.TryParse(priceStr, out decimal price) || price <= 0)
            {
                MessageBox.Show($"{fieldName} phải là số lớn hơn 0",
                    "Lỗi validate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control?.Focus();
                return false;
            }
            return true;
        }
    }
}
//Cách sử dụng trong form (ví dụ):
//C#private bool ValidateInput()
//{
//    if (!ValidateHelper.Require(txtMaMon.Text, "Mã món", txtMaMon)) 
//        return false;

//if (!ValidateHelper.ValidateCode(txtMaMon.Text, "Mã món", @"^M\d{2,}$", txtMaMon))
//    return false;

//if (!ValidateHelper.ValidatePrice(txtDonGia.Text, "Đơn giá", txtDonGia))
//    return false;

//// ...
//return true;
//}
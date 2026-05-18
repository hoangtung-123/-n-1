using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaPhe.Utils
{
    /// <summary>
    /// Helper class quản lý hiển thị MessageBox thống nhất toàn dự án
    /// </summary>
    public static class MessageHelper
    {
        /// <summary>
        /// Thông báo thành công
        /// </summary>
        public static void ShowSuccess(string message, string title = "Thành công")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Thông báo lỗi
        /// </summary>
        public static void ShowError(string message, string title = "Lỗi")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Thông báo cảnh báo
        /// </summary>
        public static void ShowWarning(string message, string title = "Cảnh báo")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Hỏi xác nhận (Yes/No)
        /// </summary>
        public static bool ShowConfirm(string message, string title = "Xác nhận")
        {
            DialogResult result = MessageBox.Show(message, title,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        /// <summary>
        /// Hỏi xác nhận với nút Yes/No + Warning icon
        /// </summary>
        public static bool ShowConfirmWarning(string message, string title = "Xác nhận")
        {
            DialogResult result = MessageBox.Show(message, title,
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return result == DialogResult.Yes;
        }

        /// <summary>
        /// Thông báo thông tin
        /// </summary>
        public static void ShowInfo(string message, string title = "Thông tin")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
//Cách sử dụng (Rất tiện lợi):
//C#// Thay vì viết dài dòng:
//MessageHelper.ShowSuccess("Thêm nhân viên thành công!");

//// Thay vì:
//MessageHelper.ShowError("Mã món đã tồn tại!");

//// Xác nhận:
//if (MessageHelper.ShowConfirm("Bạn có chắc muốn xóa?", "Xác nhận xóa"))
//{
//    // thực hiện xóa
//}
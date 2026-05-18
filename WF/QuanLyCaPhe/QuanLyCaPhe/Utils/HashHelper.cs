using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using QuanLyCaPhe.Utils;

namespace QuanLyCaPhe.Utils
{
    public static class HashHelper
    {
        private const int SaltSize = 16;        // 128 bit
        private const int HashSize = 32;        // 256 bit
        private const int Iterations = 10000;   // Số lần lặp (càng cao càng an toàn)

        /// <summary>
        /// Mã hóa mật khẩu thành chuỗi Hash + Salt
        /// </summary>
        public static string HashPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Mật khẩu không được để trống");

            using (var rng = RandomNumberGenerator.Create())
            {
                // Tạo Salt
                byte[] salt = new byte[SaltSize];
                rng.GetBytes(salt);

                // Hash password với PBKDF2
                using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256))
                {
                    byte[] hash = pbkdf2.GetBytes(HashSize);

                    // Kết hợp Salt + Hash
                    byte[] hashBytes = new byte[SaltSize + HashSize];
                    Array.Copy(salt, 0, hashBytes, 0, SaltSize);
                    Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

                    // Chuyển thành chuỗi Base64 để lưu vào DB
                    return Convert.ToBase64String(hashBytes);
                }
            }
        }

        /// <summary>
        /// Kiểm tra mật khẩu có đúng không
        /// </summary>
        public static bool VerifyPassword(string password, string hashedPassword)
        {
            if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(hashedPassword))
                return false;

            try
            {
                byte[] hashBytes = Convert.FromBase64String(hashedPassword);

                // Lấy Salt từ bytes
                byte[] salt = new byte[SaltSize];
                Array.Copy(hashBytes, 0, salt, 0, SaltSize);

                // Hash lại password với Salt cũ
                using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256))
                {
                    byte[] hash = pbkdf2.GetBytes(HashSize);

                    // So sánh hash
                    for (int i = 0; i < HashSize; i++)
                    {
                        if (hashBytes[SaltSize + i] != hash[i])
                            return false;
                    }

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// (Tùy chọn) Hash đơn giản SHA256 - Không khuyến khích dùng cho mật khẩu
        /// </summary>
        public static string Sha256Hash(string input)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
                return Convert.ToBase64String(bytes);
            }
        }
    }
}
//Cách sử dụng trong code:
//C#// Khi thêm / sửa nhân viên
//string hashedPassword = HashHelper.HashPassword(txtMatKhau.Text);
//nv.MatKhau = hashedPassword;

//// Khi đăng nhập
//bool isCorrect = HashHelper.VerifyPassword(inputPassword, storedHashedPassword);
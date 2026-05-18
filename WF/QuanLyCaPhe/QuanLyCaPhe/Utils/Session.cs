using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaPhe.Utils
{
    public static class Session
    {
        public static string MaNV { get; set; } = string.Empty;
        public static string TenNV { get; set; } = string.Empty;
        public static string ChucVu { get; set; } = string.Empty;

        public static void Clear()
        {
            MaNV = string.Empty;
            TenNV = string.Empty;
            ChucVu = string.Empty;
        }

        public static bool IsLoggedIn()
        {
            return !string.IsNullOrEmpty(MaNV);
        }

        public static bool IsAdmin()
        {
            return ChucVu?.Trim().Equals("Quản lý", StringComparison.OrdinalIgnoreCase) == true;
        }
    }
}

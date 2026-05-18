using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaPhe.DTO
{
    public class KhuVuc
    {
        public string MaKV { get; set; } = "";
        public string TenKV { get; set; } = "";
        public string DiaChi { get; set; } = "";
        public string MaQuanLy { get; set; } = "";

        // Thuộc tính bổ sung để hiển thị
        public string TenQuanLy { get; set; } = "";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaPhe.DTO
{
    public class NguyenLieu
    {
        public string MaNL { get; set; }
        public string TenNL { get; set; }
        public decimal Gia { get; set; }   // Giá nhập / giá tham khảo
        public int SoLuongTon { get; set; }
    }
}

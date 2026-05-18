using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCaPhe.DAL;

namespace QuanLyCaPhe.BUS
{
    public class BaoCaoBUS
    {
        BaoCaoDAL dal = new BaoCaoDAL();

        public decimal TongDoanhThu(DateTime from, DateTime to)
        {
            return dal.TongDoanhThu(from, to);
        }

        public int TongHoaDon(DateTime from, DateTime to)
        {
            return dal.TongHoaDon(from, to);
        }

        public int TongPhieuNhap(DateTime from, DateTime to) 
        { 
            return dal.TongPhieuNhap(from, to); 
        }
        public int TongTonKho() 
        { 
            return dal.TongTonKho(); 
        }

        public DataTable TopMonBan()
        {
            return dal.TopMonBan();
        }

        public DataTable BaoCaoHoaDon(DateTime from, DateTime to)
        {
            return dal.BaoCaoHoaDon(from, to);
        }

        public DataTable BaoCaoPhieuNhap(DateTime from, DateTime to)
        {
            return dal.BaoCaoPhieuNhap(from, to);
        }

        public DataTable DoanhThuTheoNgay(DateTime from, DateTime to)
        {
            return dal.DoanhThuTheoNgay(from, to);
        }

        public DataTable DoanhThuTheoThang(DateTime from, DateTime to)
        {
            return dal.DoanhThuTheoThang(from, to);
        }

        public DataTable DoanhThuTheoNam(DateTime from, DateTime to)
        {
            return dal.DoanhThuTheoNam(from, to);
        }
    }
}

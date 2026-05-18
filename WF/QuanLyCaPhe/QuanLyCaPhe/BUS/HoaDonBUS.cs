using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCaPhe.DAL;

namespace QuanLyCaPhe.BUS
{
    public class HoaDonBUS
    {
        HoaDonDAL dal = new HoaDonDAL();

        public DataTable GetAll()
        {
            return dal.GetAll();
        }

        public string TaoHoaDon(string maBan,string maNV)
        {
            return dal.TaoHoaDon(maBan,maNV);       
        }

        public string GetHoaDonChuaThanhToan(string maBan)
        {
            return dal.GetHoaDonChuaThanhToan(maBan);
        }

        public bool ThanhToan(string maHD)
        {
            try
            {
                dal.ThanhToan(maHD);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable LocTheoNgay(DateTime from, DateTime to)
        {
            return dal.LocTheoNgay(from, to);
        }

        public void Xoa(string maHD)
        {
            dal.Xoa(maHD);
        }   
    }
}

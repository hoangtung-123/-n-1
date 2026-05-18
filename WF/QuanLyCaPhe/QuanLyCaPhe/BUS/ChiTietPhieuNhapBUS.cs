using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCaPhe.DAL;
using QuanLyCaPhe.DTO;

namespace QuanLyCaPhe.BUS
{
    public class ChiTietPhieuNhapBUS
    {
        ChiTietPhieuNhapDAL dal = new ChiTietPhieuNhapDAL();

        public bool Insert(ChiTietPhieuNhap ct)
        {
            return dal.Insert(ct);
        }

        public DataTable GetByMaPN(string maPN)
        {
            return dal.GetByMaPN(maPN);
        }

        public string GenerateMaCTPN()
        {
            return dal.GenerateMaCTPN();
        }

        public bool DeleteByMaPN(string maPN)
        {
            return dal.DeleteByMaPN(maPN);
        }
    }
}

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
    public class PhieuNhapBUS
    {
        PhieuNhapDAL dal = new PhieuNhapDAL();

        public DataTable GetAll()
        {
            return dal.GetAll();
        }

        public bool Insert(PhieuNhap pn)
        {
            return dal.Insert(pn);
        }

        public string GenerateMaPN()
        {
            return dal.GenerateMaPN();
        }

        public bool Update(PhieuNhap pn)
        {
            return dal.Update(pn);
        }   
    }
}

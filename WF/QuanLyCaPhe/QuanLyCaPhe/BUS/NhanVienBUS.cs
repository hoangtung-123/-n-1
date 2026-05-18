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
    public class NhanVienBUS
    {
        NhanVienDAL dal = new NhanVienDAL();

        public DataTable GetAll()
        {
            return dal.GetAll();
        }

        public DataTable GetQuanLy()
        {
            return dal.GetQuanLy();
        }
        public bool Insert(NhanVien nv)
        {
            return dal.Insert(nv);
        }

        public bool Update(NhanVien nv)
        {
            return dal.Update(nv);
        }

        public bool Delete(string maNV)
        {
            return dal.Delete(maNV);
        }

        public bool Exists(string maNV)
        {
            return dal.Exists(maNV);
        }

        public bool ExistsUsername(string username)
        {
            return dal.ExistsUsername(username);
        }

        public bool ExistsSDT(string sdt)
        {
            return dal.ExistsSDT(sdt);
        }

        public bool ExistsSDTUpdate(string sdt, string maNV)
        {
            return dal.ExistsSDTUpdate(sdt, maNV);
        }

        public bool ExistsUsernameUpdate(string username, string maNV)
        {
            return dal.ExistsUsernameUpdate(username, maNV);
        }

        public bool IsUsed(string maNV)
        {
            return dal.IsUsed(maNV);
        }
    }
}

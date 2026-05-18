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
    public class NguyenLieuBUS
    {
        NguyenLieuDAL dal = new NguyenLieuDAL();

        public DataTable GetAll() => dal.GetAll();
        public bool Insert(NguyenLieu nl) => dal.Insert(nl);
        public bool Update(NguyenLieu nl) => dal.Update(nl);
        public bool Delete(string maNL) => dal.Delete(maNL);
        public bool Exists(string maNL) => dal.Exists(maNL);
        public bool IsUsed(string maNL) => dal.IsUsed(maNL);
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using QuanLyCaPhe.DAL;
using QuanLyCaPhe.DTO;

namespace QuanLyCaPhe.BUS
{
    public class BanBUS
    {
        BanDAL dal = new BanDAL();

        public DataTable GetAll() => dal.GetAll();
        public bool Insert(Ban ban) => dal.Insert(ban);
        public bool Update(Ban ban) => dal.Update(ban); 
        public bool Delete(string maBan) => dal.Delete(maBan);
        public bool Exists(string maBan) => dal.Exists(maBan);
        public bool IsUsed(string maBan) => dal.IsUsed(maBan);
    }
}

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
    public class MonBUS
    {
        MonDAL dal = new MonDAL();

        public DataTable GetAll()
        {
            return dal.GetAll();
        }

        public DataTable GetDangBan()
        {
            return dal.GetDangBan();
        }

        public bool Insert(Mon mon)
        {
            return dal.Insert(mon);
        }

        public bool Update(Mon mon)
        {
            return dal.Update(mon);
        }

        public bool Exists(string maMon)
        {
            return dal.Exists(maMon);
        }
    }
}

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
    public class KhuVucBUS
    {
        KhuVucDAL dal = new KhuVucDAL();

        public DataTable GetAll()
        {
            return dal.GetAll();
        }

        public bool Insert(KhuVuc kv)
        {
            return dal.Insert(kv);
        }

        public bool Update(KhuVuc kv)
        {
            return dal.Update(kv);
        }

        public bool Delete(string maKV)
        {
            return dal.Delete(maKV);
        }

        public bool Exists(string maKV)
        {
            return dal.Exists(maKV);
        }

        public bool IsUsed(string maKV)
        {
            return dal.IsUsed(maKV);
        }
    }
}

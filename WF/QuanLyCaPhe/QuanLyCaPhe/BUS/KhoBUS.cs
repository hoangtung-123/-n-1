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
    public class KhoBUS
    {
        private readonly KhoDAL dal = new KhoDAL();

        public DataTable GetAll() => dal.GetAll();

        public DataTable GetChiTietKho(string maKho) => dal.GetChiTietKho(maKho);

        public bool Insert(Kho kho) => dal.Insert(kho);

        public bool Update(Kho kho) => dal.Update(kho);

        public bool Delete(string maKho) => dal.Delete(maKho);

        public bool Exists(string maKho) => dal.Exists(maKho);

        public bool IsUsed(string maKho) => dal.IsUsed(maKho);
    }
}

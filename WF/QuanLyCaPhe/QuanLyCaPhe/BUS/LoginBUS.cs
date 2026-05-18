using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCaPhe.DAL;
using QuanLyCaPhe.DTO;

namespace QuanLyCaPhe.BUS
{
    public class LoginBUS
    {
        LoginDAL dal = new LoginDAL();

        public NhanVien Login(string user, string pass)
        {
            return dal.CheckLogin(user, pass);
        }
    }
}

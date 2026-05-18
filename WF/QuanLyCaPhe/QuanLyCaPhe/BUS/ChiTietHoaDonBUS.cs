using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCaPhe.DAL;
using QuanLyCaPhe.Utils;

namespace QuanLyCaPhe.BUS
{
    public class ChiTietHoaDonBUS
    {
        ChiTietHoaDonDAL dal = new ChiTietHoaDonDAL();

        public DataTable GetByBan(string maBan)
        {
            return dal.GetByBan(maBan);
        }

        public bool ThemMon(string maBan, string maMon)
        {
            try
            {
                if (string.IsNullOrEmpty(maBan) || string.IsNullOrEmpty(maMon))
                {
                    MessageBox.Show("Thiếu thông tin bàn hoặc món", "Debug");
                    return false;
                }

                if (string.IsNullOrEmpty(Session.MaNV))
                {
                    MessageBox.Show("Session.MaNV bị rỗng!", "Debug");
                    return false;
                }

                dal.ThemMon(maBan, maMon);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("LỖI CHI TIẾT:\n" + ex.Message, "Debug Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool TangSL(string maBan, string maMon)
        {
            try
            {
                dal.TangSL(maBan, maMon);
                return true;
            }
            catch { return false; }
        }

        public bool GiamSL(string maBan, string maMon)
        {
            try
            {
                dal.GiamSL(maBan, maMon);
                return true;
            }
            catch { return false; }
        }

        public bool XoaMon(string maBan, string maMon)
        {
            try
            {
                dal.XoaMon(maBan, maMon);
                return true;
            }
            catch { return false; }
        }

        public DataTable GetByMaHD(string maHD)
        {
            return dal.GetByMaHD(maHD);
        }
    }
}

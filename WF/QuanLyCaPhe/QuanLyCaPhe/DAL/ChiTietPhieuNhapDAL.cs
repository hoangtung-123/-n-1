using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using QuanLyCaPhe.DTO;

namespace QuanLyCaPhe.DAL
{
    public class ChiTietPhieuNhapDAL
    {
        private readonly DBConnect db = new DBConnect();

        public bool Insert(ChiTietPhieuNhap ct)
        {
            string sql = @"
                INSERT INTO ChiTietPhieuNhap 
                    (MaCTPN, MaPN, MaNL, SoLuong, GiaNhap)
                VALUES 
                    (@MaCTPN, @MaPN, @MaNL, @SoLuong, @GiaNhap)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaCTPN", ct.MaCTPN),
                new SqlParameter("@MaPN", ct.MaPN),
                new SqlParameter("@MaNL", ct.MaNL),
                new SqlParameter("@SoLuong", ct.SoLuong),
                new SqlParameter("@GiaNhap", ct.GiaNhap)
            };

            int result = db.ExecuteNonQuery(sql, parameters);
            return result > 0;
        }

        public bool DeleteByMaPN(string maPN)
        {
            string sql = "DELETE FROM ChiTietPhieuNhap WHERE MaPN = @MaPN";

            SqlParameter[] parameters = { new SqlParameter("@MaPN", maPN) };

            int result = db.ExecuteNonQuery(sql, parameters);
            return result >= 0;
        }

        public DataTable GetByMaPN(string maPN)
        {
            string sql = @"
                SELECT 
                    ct.MaNL, 
                    nl.TenNL,
                    ct.SoLuong,
                    ct.GiaNhap,
                    (ct.SoLuong * ct.GiaNhap) AS ThanhTien
                FROM ChiTietPhieuNhap ct
                JOIN NguyenLieu nl ON ct.MaNL = nl.MaNL
                WHERE ct.MaPN = @MaPN";

            SqlParameter[] parameters = { new SqlParameter("@MaPN", maPN) };

            return db.GetDataTable(sql, parameters);
        }

        public string GenerateMaCTPN()
        {
            string sql = @"
                SELECT TOP 1 MaCTPN 
                FROM ChiTietPhieuNhap 
                ORDER BY MaCTPN DESC";

            object result = db.ExecuteScalar(sql);

            if (result == null)
                return "CTPN01";

            string lastCode = result.ToString();
            int number = int.Parse(lastCode.Substring(4)) + 1;

            return "CTPN" + number.ToString("00");
        }   
    }
}

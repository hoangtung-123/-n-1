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
    public class PhieuNhapDAL
    {
        private readonly DBConnect db = new DBConnect();

        public DataTable GetAll()
        {
            string sql = @"
                SELECT 
                    pn.MaPN, 
                    nv.TenNV, 
                    pn.NgayTao,
                    ISNULL(SUM(ct.SoLuong * ct.GiaNhap), 0) AS TongTien
                FROM PhieuNhap pn
                JOIN NhanVien nv ON pn.MaNV = nv.MaNV
                LEFT JOIN ChiTietPhieuNhap ct ON pn.MaPN = ct.MaPN
                GROUP BY pn.MaPN, nv.TenNV, pn.NgayTao
                ORDER BY pn.NgayTao DESC";

            return db.GetDataTable(sql);
        }

        public bool Insert(PhieuNhap pn)
        {
            string sql = @"
                INSERT INTO PhieuNhap 
                    (MaPN, MaNV, NgayTao, GhiChu, TongTien)
                VALUES 
                    (@MaPN, @MaNV, @NgayTao, @GhiChu, @TongTien)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPN", pn.MaPN),
                new SqlParameter("@MaNV", pn.MaNV),
                new SqlParameter("@NgayTao", pn.NgayTao),
                new SqlParameter("@GhiChu", pn.GhiChu ?? (object)DBNull.Value),
                new SqlParameter("@TongTien", pn.TongTien)
            };

            int result = db.ExecuteNonQuery(sql, parameters);
            return result > 0;
        }

        public bool Update(PhieuNhap pn)
        {
            string sql = @"
                UPDATE PhieuNhap
                SET MaNV = @MaNV,
                    NgayTao = @NgayTao,
                    GhiChu = @GhiChu,
                    TongTien = @TongTien
                WHERE MaPN = @MaPN";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaPN", pn.MaPN),
                new SqlParameter("@MaNV", pn.MaNV),
                new SqlParameter("@NgayTao", pn.NgayTao),
                new SqlParameter("@GhiChu", pn.GhiChu ?? (object)DBNull.Value),
                new SqlParameter("@TongTien", pn.TongTien)
            };

            int result = db.ExecuteNonQuery(sql, parameters);
            return result > 0;
        }

        public string GenerateMaPN()
        {
            string sql = @"
                SELECT TOP 1 MaPN 
                FROM PhieuNhap 
                ORDER BY MaPN DESC";

            object result = db.ExecuteScalar(sql);

            if (result == null)
                return "PN01";

            string lastCode = result.ToString();
            string numberPart = lastCode.Substring(2);
            int newNumber = int.Parse(numberPart) + 1;

            return "PN" + newNumber.ToString("00");
        }   
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class ThongKeDAL : DBConnect
    {
        public DataTable getNhanVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MANV FROM NHANVIEN",_conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ThongKeDLSoLanNhanVienDiTour(string tu, string den, string ma)
        {
            string sql = "SELECT td.NHIEMVU, d.MATOUR, d.MADOAN,t.TENTOUR " +
                " FROM dbo.DOAN d, dbo.NHANVIEN n, dbo.NVTHUOCDOAN td, dbo.TOUR t" +
                " WHERE NGAYBD BETWEEN '" + tu + "' AND '" + den + "' " +
                " AND d.MADOAN=td.MADOAN AND td.MANV = n.MANV" +
                " AND  n.MANV='" + ma + "' AND t.MATOUR = d.MATOUR";
            Console.WriteLine(sql);
            SqlDataAdapter sda = new SqlDataAdapter(sql, _conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable ThongKeSoLanNhanVienDiTour(string tu, string den, string ma)
        {
            string sql = "SELECT COUNT(d.MADOAN) AS TONGSO, n.TENNV " +
                " FROM dbo.DOAN d, dbo.NHANVIEN n, dbo.NVTHUOCDOAN td, dbo.TOUR t" +
                " WHERE NGAYBD BETWEEN '" + tu + "' AND '" + den + "' " +
                " AND d.MADOAN=td.MADOAN AND td.MANV = n.MANV" +
                " AND  n.MANV='" + ma + "' AND t.MATOUR = d.MATOUR" +
                " GROUP BY n.TENNV";
            Console.WriteLine(sql);
            SqlDataAdapter sda = new SqlDataAdapter(sql, _conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable getMaDoanDeThongKeChiPhi(string ma, string tu, string den)
        {
            string sql = "SELECT d.MADOAN " +
                        "FROM dbo.TOUR t, dbo.DOAN d " +
                        "WHERE t.MATOUR = d.MATOUR AND d.NGAYBD BETWEEN '" +tu+"' AND '"+den+"' " +
                        "AND d.MATOUR = '"+ma+"'";
            Console.WriteLine(sql);
            SqlDataAdapter sda = new SqlDataAdapter(sql, _conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable ThongKeChiPhiTatCaDoanTheoTour(string ma, string tu, string den)
        {
            string sql = "SELECT c.GIATRI, d.MADOAN, t.MATOUR " +
                        "FROM dbo.CHIPHI c, dbo.LOAICP l, dbo.DOAN d, dbo.TOUR t " +
                        "WHERE l.MALOAICP=c.MALOAICP AND d.MADOAN = c.MADOAN AND d.NGAYBD BETWEEN '"+tu+"' AND '"+den+"' "+
                        "AND d.MATOUR = '" + ma + "' AND t.MATOUR=d.MATOUR";
            Console.WriteLine(sql);
            SqlDataAdapter sda = new SqlDataAdapter(sql, _conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable ThongKeChiPhiTatCaDoanTheoTourCoMaDoan(string ma, string tu, string den, string doan)
        {
            string sql = "SELECT c.GIATRI, d.MADOAN, t.MATOUR " +
                        "FROM dbo.CHIPHI c, dbo.LOAICP l, dbo.DOAN d, dbo.TOUR t " +
                        "WHERE l.MALOAICP=c.MALOAICP AND d.MADOAN = c.MADOAN AND d.NGAYBD BETWEEN '" + tu + "' AND '" + den + "' " +
                        "AND d.MATOUR = '" + ma + "' AND t.MATOUR=d.MATOUR AND d.MADOAN = '"+doan+"'";
            Console.WriteLine(sql);
            SqlDataAdapter sda = new SqlDataAdapter(sql, _conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable ThongKeDoanhThu(string ma, string bd, string kt)
        {
            string sql = "SELECT d.MADOAN, d.NGAYBD, d.NGAYKT, COUNT(ctd.MAKHACH) AS TONGSOKHACH, g.GIATIEN,SUM(c.GIATRI) AS TONGCHIPHI, (COUNT(ctd.MAKHACH)*g.GIATIEN) AS TONGTHU, ((COUNT(ctd.MAKHACH)*g.GIATIEN) - SUM(c.GIATRI)) AS DOANHTHU" +
                " FROM dbo.DOAN d, dbo.KHACH k, dbo.CHITIETDOAN ctd, dbo.GIATOUR g, dbo.TOUR t, dbo.CHIPHI c" +
                " WHERE d.MADOAN = ctd.MADOAN AND ctd.MAKHACH = k.MAKHACH AND g.MATOUR = t.MATOUR AND t.MATOUR = d.MATOUR AND c.MADOAN = d.MADOAN AND t.MATOUR = '"+ma+ "' AND d.NGAYBD BETWEEN '"+bd+"' AND '"+kt+"'" +
                " GROUP BY d.MADOAN, d.NGAYBD, d.NGAYKT, g.GIATIEN";

            Console.WriteLine(sql);

            SqlDataAdapter da = new SqlDataAdapter(sql, _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class DoanDAL :  DBConnect
    {
        public DataTable getDoan()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DOAN", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable TimKiemTheoMa(string ma)
        {
            string sql = "SELECT * FROM DOAN WHERE MADOAN LIKE N'%" + ma + "%'";
            Console.WriteLine(sql);
            SqlDataAdapter sda = new SqlDataAdapter(sql, _conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable getMaDoan()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MADOAN FROM DOAN", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable DSKhach(string ma)
        {
            String query = "SELECT k.MAKHACH, HOTEN, d.MADOAN" +
                            " FROM dbo.KHACH k, dbo.DOAN d, dbo.CHITIETDOAN c" +
                            " WHERE d.MADOAN = c.MADOAN AND c.MAKHACH = k.MAKHACH AND" +
                            " d.MADOAN = '"+ma+"'";
            Console.WriteLine(query);
            SqlDataAdapter sda = new SqlDataAdapter(query, _conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}

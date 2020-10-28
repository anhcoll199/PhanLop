using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class KhachDAL :DBConnect
    {
        public DataTable TimKiemTheoMaKhach(string ma)
        {
            string sql = "SELECT * FROM KHACH WHERE MAKHACH LIKE N'%" + ma + "%'";
            Console.WriteLine(sql);
            SqlDataAdapter sda = new SqlDataAdapter(sql, _conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}

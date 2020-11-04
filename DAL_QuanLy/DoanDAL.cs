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

        public bool themDoan(DoanDTO t)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("INSERT INTO DOAN(MADOAN, NGAYBD, NGAYKT, MATOUR) VALUES ('{0}', '{1}', '{2}', '{3}')", t.MaDoan1, t.NgayBD1, t.NgayKT1, t.MaTour1);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                _conn.Close();
            }

            return false;
        }

        public bool suaDoan(DoanDTO l)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("UPDATE DOAN SET NGAYBD = '{0}', NGAYKT = '{1}', MATOUR = '{2}' WHERE MADOAN = '{3}'", l.NgayBD1, l.NgayKT1, l.MaTour1, l.MaDoan1);
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }

        public bool xoaDoan(String ma)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("DELETE FROM DOAN WHERE MADOAN = '{0}'", ma);
                Console.WriteLine(SQL);

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }
    }
}

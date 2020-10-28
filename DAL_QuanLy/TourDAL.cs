using DTO_QuanLy;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QuanLy
{
    public class TourDAL : DBConnect
    {
        public DataTable getTour()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MATOUR, TENTOUR, MALOAI FROM TOUR", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable TimKiemTheoMa(string ma)
        {
            string sql = "SELECT * FROM TOUR WHERE MATOUR LIKE N'%" + ma + "%'";
            Console.WriteLine(sql);
            SqlDataAdapter sda = new SqlDataAdapter(sql, _conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable getMaTour()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MATOUR FROM TOUR", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /// Thêm thành viên

        public bool themTour(TourDTO t)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("INSERT INTO TOUR(MATOUR, TENTOUR, MALOAI) VALUES ('{0}', '{1}', '{2}')", t.MaTour1, t.Ten1, t.MaTheLoai1);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }

            return false;
        }


        /////// Sửa thành viên

        public bool suaTour(TourDTO l)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("UPDATE TOUR SET TENTOUR = '{0}', MALOAI = '{1}' WHERE MATOUR = '{2}'", l.Ten1,  l.MaTheLoai1, l.MaTour1);
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }


        /////// Xóa thành viên

        public bool xoaTour(String ma)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("DELETE FROM TOUR WHERE MATOUR = '{0}'", ma);
                Console.WriteLine(SQL);

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }
        //Lay du lieu MaLoaiTour
        public DataTable getMaLoai()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MALOAI FROM LOAITOUR", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable DSDiaDiem(string ma)
        {
            String query = "SELECT d.MADIADIEM, d.TENDD " +
                            " FROM dbo.TOUR t, dbo.CTTOUR c, dbo.DIADIEM d" +
                            " WHERE t.MATOUR =c.MATOUR AND c.MADD = d.MADIADIEM AND" +
                            " t.MATOUR = '" + ma + "'";
            Console.WriteLine(query);
            SqlDataAdapter sda = new SqlDataAdapter(query, _conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public string XemGiaTheoTour(String ma)
        {
            _conn.Open();
            string tien = "";

            SqlCommand dbcommand = new SqlCommand();
            dbcommand.CommandText = @"select giatien from giatour where matour = '" + ma + "'";
            dbcommand.Connection = _conn;
            Console.WriteLine(dbcommand.CommandText);

            //tien = (Int32)dbcommand.ExecuteScalar();
            //Console.WriteLine(tien);

            using (SqlDataReader dr = dbcommand.ExecuteReader())
            {
                while (dr.Read())
                {
                    tien = dr[0].ToString();
                }
            }
            Console.WriteLine(tien);
            _conn.Close();

            return tien;
        }
    }
}

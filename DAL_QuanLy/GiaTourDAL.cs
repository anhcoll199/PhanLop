using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class GiaTourDAL : DBConnect
    {
        public DataTable getGia()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM GIATOUR", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /// Thêm thành viên

        public bool themGia(GiaTourDTO t)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("INSERT INTO GIATOUR(MAGIA, GIATIEN, TGBD, TGKT, MATOUR) VALUES ('{0}', {1}, '{2}', '{3}', '{4}')", t.MaGia1,t.GiaTien1,t.TGBD1,t.TGKT1,t.MaTour1);
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

        public bool suaGia(GiaTourDTO l)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("UPDATE GIATOUR SET GIATIEN = {0}, TGBD = '{1}', TGKT = '{2}', MATOUR = '{3}' WHERE MAGIA = '{4}'", l.GiaTien1, l.TGBD1, l.TGKT1,l.MaTour1, l.MaGia1);
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

        public bool xoaGia(String ma)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("DELETE FROM GIATOUR WHERE MAGIA = '{0}'", ma);
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
        public DataTable getMaTour()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MATOUR FROM TOUR", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}

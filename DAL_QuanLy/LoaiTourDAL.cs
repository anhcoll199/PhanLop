using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class LoaiTourDAL : DBConnect
    {
        public DataTable getLoaiTour()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LOAITOUR", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /// Thêm thành viên

        public bool themLoai(LoaiTourDTO l)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("INSERT INTO LOAITOUR(MALOAI, TENLOAI) VALUES ('{0}', '{1}')", l.MaLoai1,l.TenLoai1);
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

        public bool suaLoia(LoaiTourDTO l)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("UPDATE LOAITOUR SET TENLOAI = '{0}' WHERE MALOAI = '{1}'", l.TenLoai1,l.MaLoai1);
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

        public bool xoaLoai(String ma)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("DELETE FROM LOAITOUR WHERE MALOAI = '{0}'", ma);
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
    }
}

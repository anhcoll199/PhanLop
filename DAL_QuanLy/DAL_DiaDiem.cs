using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class DiaDiemDAL : DBConnect
    {
        public DataTable getDiaDiem()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DIADIEM", _conn);
            DataTable dtDiaDiem = new DataTable();
            da.Fill(dtDiaDiem);
            return dtDiaDiem;
        }

        /// Thêm thành viên

        public bool themDiaDiem(DiaDiemDTO dd)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("INSERT INTO DIADIEM(MADIADIEM, TENDD) VALUES ('{0}', '{1}')", dd.MaDD1,dd.TenDD1);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                Console.WriteLine(SQL);
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


        ///// Sửa thành viên

        public bool suaDiemDia(DiaDiemDTO dd)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("UPDATE DIADIEM SET TENDD = '{0}' WHERE MADIADIEM = '{1}'", dd.TenDD1,dd.MaDD1);
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


        ///// Xóa thành viên

        public bool xoaThanhVien(String ma)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("DELETE FROM DIADIEM WHERE MADIADIEM = '{0}'", ma);
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

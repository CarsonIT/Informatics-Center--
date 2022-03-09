using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_KhoaHoc_Used
    {

        public static DataTable getKhoaHocChoUsed(string tentaikhoan)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_GetKhoaHocChoUsed", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@TenTaiKhoan", SqlDbType.NChar, 10);
            command.Parameters["@TenTaiKhoan"].Value = tentaikhoan;

            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static DataTable getLopHocChoUsed(string tentaikhoan, string malopkhoahoc)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_GetLopHocChoUsed", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@TenTaiKhoan", SqlDbType.NChar, 10);
            command.Parameters["@TenTaiKhoan"].Value = tentaikhoan;
            command.Parameters.Add("@MaLopKhoaHoc", SqlDbType.NVarChar, 50);
            command.Parameters["@MaLopKhoaHoc"].Value = malopkhoahoc;


            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static string LoaiKhoaHoc(string malkh)
        {
            string result;
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("select dbo.fLoaiKhoaHoc (@malkh)", Conn);


            command.Parameters.Add("@malkh", SqlDbType.NVarChar, 50);
            command.Parameters["@malkh"].Value = malkh;

            Conn.Open();
            result = (string)command.ExecuteScalar();
            Conn.Close();
            return result;
        }
        public static string LayKQKhoaHoc(string tentk, string mlkh)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("spXemKQ", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@tentk", tentk);
            command.Parameters.AddWithValue("@malkh", mlkh);
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            string str = dt.Rows[0][0].ToString(); //ở đây giá trị trả về chỉ là 1 chuỗi             
            Conn.Close();
            return str;
        }
        public static DataTable getKhoaHocCungLoai(string malopkhoahoc)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_XemKhoaHocCungLoai", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MaLopKhoaHoc", SqlDbType.NVarChar, 50);
            command.Parameters["@MaLopKhoaHoc"].Value = malopkhoahoc;

            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static int KiemtraKhoaHocDaHocHayChua(string malopkhoahoc)
        {
            int result;
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("select dbo.sp_KiemTraKhoaHocDaHocChua(@malopkhoahoc)", Conn);


            command.Parameters.Add("@malopkhoahoc", SqlDbType.NVarChar, 50);
            command.Parameters["@malopkhoahoc"].Value = malopkhoahoc;


            Conn.Open();
            result = (int)command.ExecuteScalar();
            Conn.Close();
            return result;
        }

        public static void XacNhanChuyenKhoa(string malopHocCu, string malopHocMoi, string tentaikhoan)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_XacNhanChuyenKhoa", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@malopkhoahoc_Cu", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@malopkhoahoc_Moi", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@tentaikhoan", SqlDbType.NChar, 10);

            command.Parameters["@malopkhoahoc_Cu"].Value = malopHocCu;
            command.Parameters["@malopkhoahoc_Moi"].Value = malopHocMoi;
            command.Parameters["@tentaikhoan"].Value = tentaikhoan;


            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}

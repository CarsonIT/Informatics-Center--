using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class D_LopMonHoc
    {
        public static DataTable GetLopMonHocGV(string MAGV)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_GetLopMonHoc " + MAGV, Conn);
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static DataTable GetDSLopMonHoc(string MaLopMonHoc)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_GetDSLopMonHoc " + MaLopMonHoc, Conn);
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static bool ChamDiemMonHoc(string MaLichThi,string MaHocVien,string Diem)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_ChamDiemMonHoc " + MaLichThi + ", "+MaHocVien+", "+Diem.Replace(",","."), Conn);
            Conn.Open();
            if (command.ExecuteNonQuery() > 0)
            {
                Conn.Close();
                return true;
            }
            else
            {
                Conn.Close();
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_NhomHocPhan_PDT
    {
        public static DataTable Get_TenHocPhan(String makh)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_TenHocPhan_KTV", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaKhoaHoc", SqlDbType.NVarChar, 50);
            command.Parameters["@MaKhoaHoc"].Value = makh;
            Conn.Open();
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(command);
            ad.Fill(dt);
            return dt;
            Conn.Close();
        }
        public static DataTable Get_MonHoc(String tenhp)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_Get_MonHoc_HocPhan", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@TenHocPhan", SqlDbType.NVarChar, 50);
            command.Parameters["@TenHocPhan"].Value = tenhp;
            Conn.Open();
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(command);
            ad.Fill(dt);
            return dt;
            Conn.Close();
        }
        
    }
}

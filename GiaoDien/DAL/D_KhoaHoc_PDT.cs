using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_KhoaHoc_PDT
    {
        public static DataTable getView_KhoaHoc()
        {
            SqlConnection conn = dbConnectionData.HamKetNoi();
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter("sp_View_KhoaHoc", conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            conn.Close();
            return (dt);
        }
        public static DataTable Get_TenChuyenDe(String makh)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_GetTenChuyenDe", Conn);
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
    }
}

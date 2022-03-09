using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_LopMonHoc_PDT
    {
        public static DataTable getView_LopMonHocKTV()
        {
            SqlConnection conn = dbConnectionData.HamKetNoi();
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter("sp_View_LopMonHocKTV", conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            conn.Close();
            return (dt);
        }
        public static DataTable getView_LopMonHocDTCD(String makhoahoc)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_View_LopMonHocDTCD", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaKhoaHoc", SqlDbType.NVarChar, 50);
            command.Parameters["@MaKhoaHoc"].Value = makhoahoc;
            Conn.Open();
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(command);
            ad.Fill(dt);
            Conn.Close();
            return (dt);
        }
    }
}

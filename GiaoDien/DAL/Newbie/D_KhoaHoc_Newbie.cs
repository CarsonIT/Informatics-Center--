using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_KhoaHoc_Newbie
    {
        public static DataTable getKhoaHocChoNewbie()
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_GetKhoaHocChoNewbie", Conn);
            command.CommandType = CommandType.StoredProcedure;

            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static DataTable GetLopHocChoNewbie(string MaLopKhoaHoc)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_GetLopHocChoNewbie", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MaLopKhoaHoc", SqlDbType.NVarChar,50);

            command.Parameters["@MaLopKhoaHoc"].Value = MaLopKhoaHoc;

            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_KQMonHoc
    {
        public static List<DTO_KQMonHoc> LayDSKQMonHoc(string tentk,string mlkh)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("spXemKQLopCC", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@tentk", tentk);
            command.Parameters.AddWithValue("@malkh", mlkh);
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<DTO_KQMonHoc> ds;
            ds = (from DataRow row in dt.Rows

                         select new DTO_KQMonHoc
                         {
                             MaMH1 = row["MaMonHoc"].ToString(),
                             TenMH1 = row["TenMonHoc"].ToString(),
                             MaLMH1= row["MaLopMH"].ToString(),
                             Diem1 = row["Diem"].ToString(),

                         }).ToList();
            Conn.Close();
            return ds;
        }
        
        public static List<DTO_KQMonHoc> LayDSKQMH(string tentk, string mlkh, string mhp)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("spXemKQMH", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@tentk", tentk);
            command.Parameters.AddWithValue("@malkh", mlkh);
            command.Parameters.AddWithValue("@mahp", mhp);

            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<DTO_KQMonHoc> ds;
            ds = (from DataRow row in dt.Rows

                  select new DTO_KQMonHoc
                  {
                      MaMH1 = row["MaMonHoc"].ToString(),
                      TenMH1 = row["TenMonHoc"].ToString(),
                      MaLMH1 = row["MaLopMH"].ToString(),
                      Diem1 = row["Diem"].ToString(),

                  }).ToList();
            Conn.Close();
            return ds;
        }
    }
}

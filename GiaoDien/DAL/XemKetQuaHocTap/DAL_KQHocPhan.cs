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
    public class DAL_KQHocPhan
    {
        
            public static List<DTO_KQHocPhan> LayKQHocPhan(string tentk, string mlkh)
            {
                SqlConnection Conn = dbConnectionData.HamKetNoi();
                SqlCommand command = new SqlCommand("spXemKQHocPhan", Conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@tentk", tentk);
                command.Parameters.AddWithValue("@malkh", mlkh);
                Conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;
                DataTable dt = new DataTable();
                da.Fill(dt);
                List<DTO_KQHocPhan> ds;
                ds = (from DataRow row in dt.Rows

                      select new DTO_KQHocPhan
                      {
                          MaHP1 = row["MaHocPhan"].ToString(),
                          TenHP1 = row["TenHocPhan"].ToString(),
                          DiemTB1 = row["DiemTB"].ToString(),

                      }).ToList();
                Conn.Close();
                return ds;
            }
        public static string LayDiemThiTN(string tentk, string mlkh)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("spLayDiemThiTN", Conn);
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
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class DAL_TaiKhoan
    {
        public static int Login(string tentk, string mk)
        {
            int result;
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("select dbo.login (@username,@pass)", Conn);

            command.Parameters.Add("@username", SqlDbType.NChar, 10);
            command.Parameters["@username"].Value = tentk;
            command.Parameters.Add("@pass", SqlDbType.NChar, 50);
            command.Parameters["@pass"].Value = mk;
            Conn.Open();
            result = (int)command.ExecuteScalar();
            Conn.Close();
            return result;
        }
    }
}

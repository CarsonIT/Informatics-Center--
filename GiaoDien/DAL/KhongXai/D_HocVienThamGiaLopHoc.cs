using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class D_HocVienThamGiaLopHoc
    {
        public static DataTable getKhoaHocCuaHocVien(int mahv)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_GetKhoaHocCua1HocVien", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MaHV", SqlDbType.Int);

            command.Parameters["@MaHV"].Value = mahv;
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

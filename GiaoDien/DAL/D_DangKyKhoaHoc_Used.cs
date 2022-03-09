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
    public class D_DangKyKhoaHoc_Used
    {
        public static void DangKyKhoaHoc_Used(tbl_DangKyKhoaHoc_Used dangkykh)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_InsertHocVien_Logined", Conn);
            command.CommandType = CommandType.StoredProcedure;

  
            command.Parameters.Add("@TenTaiKhoan", SqlDbType.NChar, 10);
            command.Parameters.Add("@MaLopKhoaHoc", SqlDbType.NVarChar, 50);

            command.Parameters["@TenTaiKhoan"].Value = dangkykh.TenTaiKhoan1;
            command.Parameters["@MaLopKhoaHoc"].Value = dangkykh.MaLopKhoaHoc1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}

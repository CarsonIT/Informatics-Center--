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
    public class D_HocVien
    {

        public static void InsertHS(tbl_HocVien hv)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_InsertHocVien", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@TenHV", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@NgaySinh", SqlDbType.Date);
            command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 3);
            command.Parameters.Add("@SDT", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@Email", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@TenTaiKhoan", SqlDbType.NChar, 10);
            command.Parameters.Add("@MatKhau", SqlDbType.NChar, 50);

            command.Parameters["@TenHV"].Value = hv.TenHocVien1;
            command.Parameters["@NgaySinh"].Value = hv.NgaySinh1;
            command.Parameters["@GioiTinh"].Value = hv.GioiTinh1;
            command.Parameters["@SDT"].Value = hv.SDT1;
            command.Parameters["@Email"].Value = hv.Email1;
            command.Parameters["@TenTaiKhoan"].Value = hv.TenTaiKhoan1;
            command.Parameters["@MatKhau"].Value = hv.MatKhau1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}

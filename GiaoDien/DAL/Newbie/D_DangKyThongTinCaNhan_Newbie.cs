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
    public class D_DangKyThongTinCaNhan_Newbie
    {
        public static void InsertHS(tbl_ThongTinCaNhan thongtincn)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_InsertHocVien_Newbie", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@TenHV", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@NgaySinh", SqlDbType.Date);
            command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 3);
            command.Parameters.Add("@SDT", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@Email", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@TenTaiKhoan", SqlDbType.NChar, 10);
            command.Parameters.Add("@MatKhau", SqlDbType.NChar, 50);
            command.Parameters.Add("@MaLopKhoaHoc", SqlDbType.NVarChar, 50);

            command.Parameters["@TenHV"].Value = thongtincn.TenHocVien1;
            command.Parameters["@NgaySinh"].Value = thongtincn.NgaySinh1;
            command.Parameters["@GioiTinh"].Value = thongtincn.GioiTinh1;
            command.Parameters["@SDT"].Value = thongtincn.SDT1;
            command.Parameters["@Email"].Value = thongtincn.Email1;
            command.Parameters["@TenTaiKhoan"].Value = thongtincn.TenTaiKhoan1;
            command.Parameters["@MatKhau"].Value = thongtincn.MatKhau1;
            command.Parameters["@MaLopKhoaHoc"].Value = thongtincn.MaLopKhoaHoc1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}

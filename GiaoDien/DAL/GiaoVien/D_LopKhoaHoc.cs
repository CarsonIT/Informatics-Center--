using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DTO;
namespace DAL
{
    public class D_LopKhoaHoc
    {
        public static DataTable getView_LopKhoaHocCD()
        {
            SqlConnection conn = dbConnectionData.HamKetNoi();
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter("sp_View_LopKhoaHocCD ", conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            conn.Close();
            return (dt);
        }
        public static DataTable getView_LopKhoaHoc()
        {
            SqlConnection conn = dbConnectionData.HamKetNoi();
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter("sp_View_LopKhoaHoc ", conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            conn.Close();
            return (dt);
        }
        public static void Insert_LopChuyenChe(tbl_LopKhoaHoc lkh)
        {
            try
            {
                SqlConnection Conn = dbConnectionData.HamKetNoi();
                SqlCommand command = new SqlCommand("sp_Insert_LopChuyenDe", Conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MaLopKhoaHoc", SqlDbType.NVarChar, 50);
                command.Parameters.Add("@NgayKG", SqlDbType.Date);
                command.Parameters.Add("@SiSo", SqlDbType.Int);
                command.Parameters.Add("@MaGV", SqlDbType.Int);
                command.Parameters.Add("@MaKhoaHoc", SqlDbType.NVarChar, 50);
                command.Parameters["@MaLopKhoaHoc"].Value = lkh.MaLopKhoaHoc1;
                command.Parameters["@NgayKG"].Value = lkh.NgayKhaiGiang1;
                command.Parameters["@SiSo"].Value = lkh.SiSo1;
                command.Parameters["@MaGV"].Value = lkh.MaGV1;
                command.Parameters["@MaKhoaHoc"].Value = lkh.MaKhoaHoc1;
                Conn.Open();
                command.ExecuteNonQuery();
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static void Insert_LopKyThuatVien(tbl_LopKhoaHoc lkh, tbl_LopMonHoc LopMonHoc1)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_Insert_KyThuatVien", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaLopKhoaHoc", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@MaKhoaHoc", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@NgayKG", SqlDbType.Date);
            command.Parameters.Add("@SiSo", SqlDbType.Int);
            command.Parameters.Add("@MaMonHoc", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@MaLop", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@ThoiGianHoc", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@MaGV", SqlDbType.Int);

            command.Parameters["@MaLopKhoaHoc"].Value = lkh.MaLopKhoaHoc1;
            command.Parameters["@MaKhoaHoc"].Value = lkh.MaKhoaHoc1;
            command.Parameters["@NgayKG"].Value = lkh.NgayKhaiGiang1;
            command.Parameters["@SiSo"].Value = lkh.SiSo1;
            command.Parameters["@MaMonHoc"].Value = LopMonHoc1.MaMonHoc1;
            command.Parameters["@MaLop"].Value = LopMonHoc1.MaLop1;
            command.Parameters["@ThoiGianHoc"].Value = LopMonHoc1.ThoiGianHoc1;
            command.Parameters["@MaGV"].Value = LopMonHoc1.MaGV1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();

        }
        public static DataTable GetLopKhoaHocGV(string MAGV)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_GetLopKhoaHoc "+MAGV, Conn);
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static DataTable GetDSLopKhoaHoc(string MaLopKhoaHoc)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_GetDSLopKhoaHoc " + MaLopKhoaHoc, Conn);
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static bool ChamDiemTotNghiep(string MaLichThi, string MaHocVien, string Diem)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_ChamDiemTotNghiep " + MaLichThi + ", " + MaHocVien + ", " + Diem.Replace(",", "."), Conn);
            Conn.Open();
            if(command.ExecuteNonQuery()>0)
            {
                Conn.Close();
                return true;
            }
            else
            {
                Conn.Close();
                return false;
            } 
                
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class B_KhoaHoc_Used
    {
        public static DataTable getKhoaHocChoUsed(string tentaikhoan)
        {
            return D_KhoaHoc_Used.getKhoaHocChoUsed(tentaikhoan);
        }
        public static DataTable getLopHocChoUsed(string tentaikhoan, string malopkhoahoc)
        {
            return D_KhoaHoc_Used.getLopHocChoUsed(tentaikhoan,malopkhoahoc);
        }
        public static void DangKyKhoaHoc_Used(tbl_DangKyKhoaHoc_Used dangkykh)
        {
            D_DangKyKhoaHoc_Used.DangKyKhoaHoc_Used(dangkykh);
        }
        public static string LoaiKhoaHoc(string malkh)
        {
            return D_KhoaHoc_Used.LoaiKhoaHoc(malkh);
        }
        public static string LayKQKhoaHoc(string tentk, string mlkh)
        {
            return D_KhoaHoc_Used.LayKQKhoaHoc(tentk, mlkh);
        }
        public static DataTable getKhoaHocCungLoai(string malopkhoahoc)
        {
            return D_KhoaHoc_Used.getKhoaHocCungLoai(malopkhoahoc);
        }
        public static int KiemTraKhoaHocDaHocChua(string malopkhoahoc)
        {
            return D_KhoaHoc_Used.KiemtraKhoaHocDaHocHayChua(malopkhoahoc);
        }
        public static void XacNhanChuyenKhoa(string malopHocCu, string malopHocMoi, string tentaikhoan)
        {
            D_KhoaHoc_Used.XacNhanChuyenKhoa(malopHocCu, malopHocMoi, tentaikhoan);
        }
    }
}

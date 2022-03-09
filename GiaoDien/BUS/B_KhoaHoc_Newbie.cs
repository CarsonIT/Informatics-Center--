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
    public class B_KhoaHoc_Newbie
    {
        public static DataTable getKhoaHocChoNewbie()
        {
            return D_KhoaHoc_Newbie.getKhoaHocChoNewbie();
        }
        public static DataTable getLopHocChoNewbie(string MaLopKhoaHoc)
        {
            return D_KhoaHoc_Newbie.GetLopHocChoNewbie(MaLopKhoaHoc);
        }
        public static void InsertHocVien(tbl_ThongTinCaNhan thongtincn)
        {
            D_DangKyThongTinCaNhan_Newbie.InsertHS(thongtincn);
        }

    }
}

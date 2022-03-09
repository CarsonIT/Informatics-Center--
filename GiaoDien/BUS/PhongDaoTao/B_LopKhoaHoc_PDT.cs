using System;
using System.Data;
using DAL;
using DTO;
namespace BUS
{
    public static class B_LopKhoaHoc_PDT
    {
        public static DataTable GetView_LopKhoaHocCD()
        {
            return D_LopKhoaHoc_PDT.getView_LopKhoaHocCD();
        }
        public static DataTable GetView_LopKhoaHoc()
        {
            return D_LopKhoaHoc_PDT.getView_LopKhoaHoc();
        }
        public static void Insert_LopKhoaHocCD(tbl_LopKhoaHoc lkh)
        {
            D_LopKhoaHoc_PDT.Insert_LopChuyenChe(lkh);
        }
        public static void Insert_LopKhoaHocKTV(tbl_LopKhoaHoc lkh,tbl_LopMonHoc LopMonHoc1)
        {
            D_LopKhoaHoc_PDT.Insert_LopKyThuatVien(lkh, LopMonHoc1);
        }
    }
};

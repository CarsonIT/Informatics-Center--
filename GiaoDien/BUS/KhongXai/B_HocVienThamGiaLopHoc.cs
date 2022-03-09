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
    public class B_HocVienThamGiaLopHoc
    {
        public static DataTable GetKhoaHocCuaHocVien(int mahv)
        {
            return D_HocVienThamGiaLopHoc.getKhoaHocCuaHocVien(mahv);
        }
    }
}

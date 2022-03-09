using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
   public  class B_NhomHocPhan_PDT
    {
        public static DataTable Get_TenHocPhanKTV(String makh)
        {
            return D_NhomHocPhan_PDT.Get_TenHocPhan(makh);
        }
        public static DataTable Get_MonHoc(String tenhp)
        {
            return D_NhomHocPhan_PDT.Get_MonHoc(tenhp);
        }
    }
}

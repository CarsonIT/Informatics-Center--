using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class B_KhoaHoc_PDT
    {
        public static DataTable GetView_KhoaHoc()
        {
            return D_KhoaHoc_PDT.getView_KhoaHoc();
        }
        public static DataTable Get_TenChuyenDe(String makh)
        {
            return D_KhoaHoc_PDT.Get_TenChuyenDe(makh);
        }
    }
}

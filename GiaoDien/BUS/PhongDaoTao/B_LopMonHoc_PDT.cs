using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
   public  class B_LopMonHoc_PDT
    {
        public static DataTable View_LopMonKTV()
        {
            return D_LopMonHoc_PDT.getView_LopMonHocKTV();
        }
        public static DataTable View_LopMonDTCD(String makhoahoc)
        {
            return D_LopMonHoc_PDT.getView_LopMonHocDTCD(makhoahoc);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BUS
{
    public class B_LopMonHoc
    {
        public static DataTable GetLopMonHocGV(string MAGV)
        {
            return D_LopMonHoc.GetLopMonHocGV(MAGV);
        }
        public static DataTable GetDSLopMonHoc(string MaLopMonHoc)
        {
            return D_LopMonHoc.GetDSLopMonHoc(MaLopMonHoc);
        }
        public static bool ChamDiemMonHoc(DataTable data)
        {
            bool temp;
            for (int i = 0; i < data.Rows.Count; i++)
            {
               temp = D_LopMonHoc.ChamDiemMonHoc(data.Rows[i]["MaLichThi"].ToString(), data.Rows[i]["MaHocVien"].ToString(), data.Rows[i]["Diem"].ToString());
                if (!temp)
                    return false;
            }
            return true;
        }
    }
}

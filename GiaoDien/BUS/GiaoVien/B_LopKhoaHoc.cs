using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUS
{
    public class B_LopKhoaHoc
    {
        public static DataTable GetLopKhoaHocGV(string MAGV)
        {
            return D_LopKhoaHoc.GetLopKhoaHocGV(MAGV);
        }
        public static DataTable GetDSLopKhoaHoc(string MaLopKhoaHoc)
        {
            return D_LopKhoaHoc.GetDSLopKhoaHoc(MaLopKhoaHoc);
        }
        public static bool ChamDiemTotNghiep(DataTable data)
        {
            bool temp;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i]["Diem"].ToString() != "")
                {
                   temp = D_LopKhoaHoc.ChamDiemTotNghiep(data.Rows[i]["MaLichThi"].ToString(), data.Rows[i]["MaHocVien"].ToString(), data.Rows[i]["Diem"].ToString());
                    if (!temp)
                        return false;
                }
            }
            return true;
        }
    }
}

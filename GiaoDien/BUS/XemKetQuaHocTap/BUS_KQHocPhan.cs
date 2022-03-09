using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_KQHocPhan
    {
        public static List<DTO_KQHocPhan> LayKQHocPhan(string tentk, string mlkh)
        {
            return DAL_KQHocPhan.LayKQHocPhan(tentk, mlkh);
        }
        public static string LayDiemThiTN(string tentk, string mlkh)
        {
            return DAL_KQHocPhan.LayDiemThiTN(tentk, mlkh);
        }
    }
}

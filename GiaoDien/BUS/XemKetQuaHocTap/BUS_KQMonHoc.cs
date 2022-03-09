using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_KQMonHoc
    {
        public static List<DTO_KQMonHoc> LayDSKQMonHoc(string tentk, string mlkh)
        {
            return DAL_KQMonHoc.LayDSKQMonHoc(tentk,mlkh);
        }
        public static List<DTO_KQMonHoc> LayKQMH(string tentk, string mlkh, string mhp)
        {
            return DAL_KQMonHoc.LayDSKQMH(tentk, mlkh,mhp);
        }
    }
}

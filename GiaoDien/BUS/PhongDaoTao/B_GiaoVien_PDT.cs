using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
        public class B_GiaoVien_PDT
        {
            public static DataTable GetAllGiaoVien()
            {
                return D_GiaoVien_PDT.showGV();
            }
        }
}

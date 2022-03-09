using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_TaiKhoan
    {
        string tentk;
        string mk;

        public static int Login(string tentk, string mk)
        {
            return DAL_TaiKhoan.Login(tentk,mk);
        }


    }
}

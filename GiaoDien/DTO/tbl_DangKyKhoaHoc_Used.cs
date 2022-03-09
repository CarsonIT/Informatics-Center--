using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tbl_DangKyKhoaHoc_Used
    {
        private string TenTaiKhoan;
        private string MaLopKhoaHoc;

        public tbl_DangKyKhoaHoc_Used(string tenTaiKhoan, string maLopKhoaHoc)
        {
            TenTaiKhoan = tenTaiKhoan;
            MaLopKhoaHoc = maLopKhoaHoc;
        }

        public string TenTaiKhoan1 { get => TenTaiKhoan; set => TenTaiKhoan = value; }
        public string MaLopKhoaHoc1 { get => MaLopKhoaHoc; set => MaLopKhoaHoc = value; }
    }
}

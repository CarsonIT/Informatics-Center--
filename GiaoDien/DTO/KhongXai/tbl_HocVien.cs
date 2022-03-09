using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tbl_HocVien
    {
        private string TenHocVien;
        private DateTime NgaySinh;
        private string GioiTinh;
        private string SDT;
        private string Email;
        private string TenTaiKhoan;
        private string MatKhau;

        public tbl_HocVien(string tenHocVien, DateTime ngaySinh, string gioiTinh, string sDT, string email, string tenTaiKhoan, string matKhau)
        {
            TenHocVien = tenHocVien;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            SDT = sDT;
            Email = email;
            TenTaiKhoan = tenTaiKhoan;
            MatKhau = matKhau;
        }

        public string TenHocVien1 { get => TenHocVien; set => TenHocVien = value; }
        public DateTime NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string TenTaiKhoan1 { get => TenTaiKhoan; set => TenTaiKhoan = value; }
        public string MatKhau1 { get => MatKhau; set => MatKhau = value; }
    }
}

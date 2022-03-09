using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tbl_HocVienThamGiaLopHoc
    {
        private int MaHV;
        private string MaLopHoc;
        private string TinhTrangThamGia;

        public tbl_HocVienThamGiaLopHoc(int maHV, string maLopHoc, string tinhTrangThamGia)
        {
            MaHV = maHV;
            MaLopHoc = maLopHoc;
            TinhTrangThamGia = tinhTrangThamGia;
        }

        public int MaHV1 { get => MaHV; set => MaHV = value; }
        public string MaLopHoc1 { get => MaLopHoc; set => MaLopHoc = value; }
        public string TinhTrangThamGia1 { get => TinhTrangThamGia; set => TinhTrangThamGia = value; }
    }
}

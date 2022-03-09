using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tbl_KhoaHoc
    {
        private string MaKH;
        private string TenKH;
        private float HocPhi;
        private int TongSoTiet;
        private int SiSoToiDa;

        public tbl_KhoaHoc(string maKH, string tenKH, float hocPhi, int tongSoTiet, int siSoToiDa)
        {
            MaKH = maKH;
            TenKH = tenKH;
            HocPhi = hocPhi;
            TongSoTiet = tongSoTiet;
            SiSoToiDa = siSoToiDa;
        }

        public string MaKH1 { get => MaKH; set => MaKH = value; }
        public string TenKH1 { get => TenKH; set => TenKH = value; }
        public float HocPhi1 { get => HocPhi; set => HocPhi = value; }
        public int TongSoTiet1 { get => TongSoTiet; set => TongSoTiet = value; }
        public int SiSoToiDa1 { get => SiSoToiDa; set => SiSoToiDa = value; }
    }
}

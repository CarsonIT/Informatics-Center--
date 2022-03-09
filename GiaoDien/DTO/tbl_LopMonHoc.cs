using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
 public    class tbl_LopMonHoc
    {
        private String MaLop;
        private String ThoiGianHoc;
        private String MaLopKhoaHoc;
        private int MaGV;
        private String MaMonHoc;

        public tbl_LopMonHoc(string maLop, string thoiGianHoc, string maLopKhoaHoc, int maGV, string maMonHoc)
        {
            MaLop1 = maLop;
            ThoiGianHoc1 = thoiGianHoc;
            MaLopKhoaHoc1 = maLopKhoaHoc;
            MaGV1 = maGV;
            MaMonHoc1 = maMonHoc;
        }

        public string MaLop1 { get => MaLop; set => MaLop = value; }
        public string ThoiGianHoc1 { get => ThoiGianHoc; set => ThoiGianHoc = value; }
        public string MaLopKhoaHoc1 { get => MaLopKhoaHoc; set => MaLopKhoaHoc = value; }
        public int MaGV1 { get => MaGV; set => MaGV = value; }
        public string MaMonHoc1 { get => MaMonHoc; set => MaMonHoc = value; }
    }
}

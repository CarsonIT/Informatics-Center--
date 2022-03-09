using System;

namespace DTO
{
    public class tbl_LopKhoaHoc
    {
        private String MaLopKhoaHoc;
        private DateTime NgayKhaiGiang;
        private int SiSo;
        private int MaGV;
        private String MaKhoaHoc;

        public tbl_LopKhoaHoc(string maLopKhoaHoc, DateTime ngayKhaiGiang, int siSo, int maGV, string maKhoaHoc)
        {
            MaLopKhoaHoc1 = maLopKhoaHoc;
            NgayKhaiGiang1 = ngayKhaiGiang;
            SiSo1 = siSo;
            MaGV1 = maGV;
            MaKhoaHoc1 = maKhoaHoc;
        }
        public tbl_LopKhoaHoc(string maLopKhoaHoc, DateTime ngayKhaiGiang, int siSo, string maKhoaHoc)
        {
            MaLopKhoaHoc1 = maLopKhoaHoc;
            NgayKhaiGiang1 = ngayKhaiGiang;
            SiSo1 = siSo;
            MaKhoaHoc1 = maKhoaHoc;
        }


        public string MaLopKhoaHoc1 { get => MaLopKhoaHoc; set => MaLopKhoaHoc = value; }
        public DateTime NgayKhaiGiang1 { get => NgayKhaiGiang; set => NgayKhaiGiang = value; }
        public int SiSo1 { get => SiSo; set => SiSo = value; }
        public int MaGV1 { get => MaGV; set => MaGV = value; }
        public string MaKhoaHoc1 { get => MaKhoaHoc; set => MaKhoaHoc = value; }
    }


}

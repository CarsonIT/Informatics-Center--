using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class DTO_KQMonHoc
    {
        private string MaMH;
        private string TenMH;
        private string MaLMH;
        private string Diem;

        public DTO_KQMonHoc() { }

        public DTO_KQMonHoc(string maMH, string tenMH, string maLMH, string diem)
        {
            MaMH = maMH;
            TenMH = tenMH;
            MaLMH = maLMH;
            Diem = diem;
        }

        public string MaMH1 { get => MaMH; set => MaMH = value; }
        public string TenMH1 { get => TenMH; set => TenMH = value; }
        public string MaLMH1 { get => MaLMH; set => MaLMH = value; }
        public string Diem1 { get => Diem; set => Diem = value; }
    }
}

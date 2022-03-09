using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KQHocPhan
    {
        private string MaHP;
        private string TenHP;
        private string DiemTB;

        public DTO_KQHocPhan() { }

        public DTO_KQHocPhan(string maHP, string tenHP, string diemTB)
        {
            MaHP1 = maHP;
            TenHP1 = tenHP;
            DiemTB1 = diemTB;
        }

        public string MaHP1 { get => MaHP; set => MaHP = value; }
        public string TenHP1 { get => TenHP; set => TenHP = value; }
        public string DiemTB1 { get => DiemTB; set => DiemTB = value; }
    }
}

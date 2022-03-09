using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GiaoDien
{
    public partial class ChamDiem : Form
    {
        public static string malophoc;
        public static int classtype;
        public static string MAGV;
        public ChamDiem(string MALOP,int TYPE)
        {
            InitializeComponent();
            malophoc = MALOP;
            classtype = TYPE;
            ChamDiem_loadform(MALOP, TYPE);
        }
        void ChamDiem_loadform(string MALOP,int TYPE)
        {
            ClassCode.Text = MALOP;
            if(TYPE==1)
            {
                DataTable temp = B_LopKhoaHoc.GetDSLopKhoaHoc(MALOP);
                HVList.DataSource = temp;
            }
            else
            {
                DataTable temp = B_LopMonHoc.GetDSLopMonHoc(MALOP);
                HVList.DataSource = temp;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            DataTable data = (DataTable)(HVList.DataSource);
            if (classtype == 1)
            {
               if( B_LopKhoaHoc.ChamDiemTotNghiep(data))
                {
                    MessageBox.Show("thành công");
                }   
               else
                {
                    MessageBox.Show("không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (B_LopMonHoc.ChamDiemMonHoc(data))
                {
                    MessageBox.Show("thành công");
                }
                else
                {
                    MessageBox.Show("không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void HVList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int row = HVList.CurrentCell.RowIndex;
            float Diem = float.Parse(HVList.CurrentCell.Value.ToString());
            if (Diem < 0 || Diem > 10)
            {
                MessageBox.Show("Điểm đã nhập phải nằm trong khoảng cho phép","Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                HVList.Rows[row].Cells["Diem"].Value = 0;
            }
        }
    }
}

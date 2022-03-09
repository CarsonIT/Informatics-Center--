using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GiaoDien
{
    public partial class GIAOVIEN : Form
    {
        public BindingSource DSLopKhoaHoc = new BindingSource();
        public string MAGV = "1";
        public GIAOVIEN()
        {
            InitializeComponent();
            GiaoVien_Load();
        }
        void GiaoVien_Load()
        {
            ClassList.DataSource = DSLopKhoaHoc;
            DSLopKhoaHoc.DataSource = B_LopMonHoc.GetLopMonHocGV(MAGV);
            ClassCode.DataBindings.Add(new Binding("text", DSLopKhoaHoc, "MALOP"));
        }
        private void SJClass_CheckedChanged(object sender, EventArgs e)
        {
            if (SJClass.Checked)
                DSLopKhoaHoc.DataSource = B_LopMonHoc.GetLopMonHocGV(MAGV);
            else 
                DSLopKhoaHoc.DataSource = B_LopKhoaHoc.GetLopKhoaHocGV(MAGV);
        }

        private void Mark_Click(object sender, EventArgs e)
        {
            if (SJClass.Checked)
            {
                Form tc1 = new ChamDiem(ClassCode.Text,2);
                ChamDiem.MAGV = MAGV;
                tc1.ShowDialog();
            }   
            else
            {
                Form tc1 = new ChamDiem(ClassCode.Text, 1);
                tc1.ShowDialog();
            }    
        }
    }
}

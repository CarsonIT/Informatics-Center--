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
namespace GiaoDien
{
    public partial class GUI_MoKhoaHoc : Form
    {
        public GUI_MoKhoaHoc()
        {
            InitializeComponent();
        }

        private void GUI_MoKhoaHoc_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = B_LopKhoaHoc_PDT.GetView_LopKhoaHoc();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
           GUI_MKH_LopChuyenDe form = new GUI_MKH_LopChuyenDe();
            form.ShowDialog();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            GUI_MKH_LopChungChi form = new GUI_MKH_LopChungChi();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_MKH_LopKyThuatVien form = new GUI_MKH_LopKyThuatVien();
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}

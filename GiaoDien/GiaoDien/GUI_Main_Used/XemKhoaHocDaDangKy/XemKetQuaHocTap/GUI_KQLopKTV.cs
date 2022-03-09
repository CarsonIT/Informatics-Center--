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
    public partial class GUI_KQLopKTV : Form
    {
        string malkh, tenkh, tentk;
        //Hàm lấy giá trị từ việc chọn 1 khóa học từ MainMenu ==> Submenu(cho các việc như chuyển lớp, kết quả học tập dễ dàng)
        public string Message
        {
            get { return malkh; }
            set
            {
                malkh = value;
            }
        }
        public string Message1
        {
            get { return tenkh; }
            set
            {
                tenkh = value;
            }
        }
        public string Message2
        {
            get { return tentk; }
            set
            {
                tentk = value;
            }
        }
        public GUI_KQLopKTV()
        {
            InitializeComponent();
        }
        private void DislayData()
        {
            lbdiemtn.Text = BUS_KQHocPhan.LayDiemThiTN(tentk, malkh);
            lbkq.Text = B_KhoaHoc_Used.LayKQKhoaHoc(tentk, malkh);
            dgv_DSHP.DataSource = BUS_KQHocPhan.LayKQHocPhan(tentk, malkh);
            lbmahp.Text = dgv_DSHP.Rows[0].Cells[0].Value.ToString();
            dgv_MonHoc.DataSource = BUS_KQMonHoc.LayKQMH(tentk, malkh, lbmahp.Text);
            dgv_DSHP.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            
            
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_DSHP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_DSHP.CurrentRow.Index;
            lbmahp.Text = dgv_DSHP.Rows[i].Cells[0].Value.ToString();
            dgv_MonHoc.DataSource = BUS_KQMonHoc.LayKQMH(tentk, malkh, lbmahp.Text);

        }

        private void dgv_MonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GUI_KQLopKTV_Load(object sender, EventArgs e)
        {
            DislayData();
        }
    }
}

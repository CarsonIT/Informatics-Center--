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
    public partial class GUI_KQLopChungChi : Form
    {
        public GUI_KQLopChungChi()
        {
            InitializeComponent();
        }
        string strTemp,strTemp1,tentk;
        //Hàm lấy giá trị từ việc chọn 1 khóa học từ MainMenu ==> Submenu(cho các việc như chuyển lớp, kết quả học tập dễ dàng)
        public string Message
        {
            get { return strTemp; }
            set
            {
                strTemp = value;
            }
        }
        public string Message1
        {
            get { return strTemp1; }
            set
            {
                strTemp1 = value;
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
        private void MainMenu_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void lbkq_Click(object sender, EventArgs e)
        {

        }

        private void HienThi()
        {
            lbmakh.Text = Message;
            lbtenkh.Text = Message1;
            dgv_KhoaHoc.DataSource = BUS_KQMonHoc.LayDSKQMonHoc(tentk, lbmakh.Text);
            lbkq.Text = B_KhoaHoc_Used.LayKQKhoaHoc(tentk, lbmakh.Text);
            dgv_KhoaHoc.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            
        }
        
        private void Newbie_DangKyKhoaHoc_Load(object sender, EventArgs e)
        {
            HienThi();
        }

       
    }
}

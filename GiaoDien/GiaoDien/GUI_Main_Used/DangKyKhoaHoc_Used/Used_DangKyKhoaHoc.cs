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
    public partial class Used_DangKyKhoaHoc : Form
    {
        public Used_DangKyKhoaHoc()
        {
            InitializeComponent();
        }
        string TenTaiKhoan;
        public string GetTenTaiKhoan
        {
            get { return TenTaiKhoan; }
            set
            {
                TenTaiKhoan = value;
            }
        }

        private void DislayData()
        {
            dgv_All_KhoaHoc.DataSource = B_KhoaHoc_Newbie.getKhoaHocChoNewbie();
            dgv_All_KhoaHoc.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            lb_MaLopKhoaHoc.Text = dgv_All_KhoaHoc.Rows[0].Cells[0].Value.ToString();
            lb_TenKhoaHoc.Text = dgv_All_KhoaHoc.Rows[0].Cells[1].Value.ToString();
            lb_ngayKhaiGiang.Text = dgv_All_KhoaHoc.Rows[0].Cells[2].Value.ToString();
            lb_HocPhi.Text = dgv_All_KhoaHoc.Rows[0].Cells[3].Value.ToString();
            lb_SoTietHoc.Text = dgv_All_KhoaHoc.Rows[0].Cells[4].Value.ToString();
        }

        private void dgv_All_KhoaHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_All_KhoaHoc.CurrentRow.Index;
            lb_MaLopKhoaHoc.Text = dgv_All_KhoaHoc.Rows[i].Cells[0].Value.ToString();
            lb_TenKhoaHoc.Text = dgv_All_KhoaHoc.Rows[i].Cells[1].Value.ToString();
            lb_ngayKhaiGiang.Text = dgv_All_KhoaHoc.Rows[i].Cells[2].Value.ToString();
            lb_HocPhi.Text = dgv_All_KhoaHoc.Rows[i].Cells[3].Value.ToString();
            lb_SoTietHoc.Text = dgv_All_KhoaHoc.Rows[i].Cells[4].Value.ToString();
            dgv_All_LopHoc.DataSource = B_KhoaHoc_Newbie.getLopHocChoNewbie(lb_MaLopKhoaHoc.Text);
            dgv_All_LopHoc.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
        }

        private void Used_DangKyKhoaHoc_Load(object sender, EventArgs e)
        {
            lb_TenTaiKhoan.Text = TenTaiKhoan;
            DislayData();
        }

        private void btn_XemChiTietLopHoc_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            try
            {
                string ttk = TenTaiKhoan;
                string makh = lb_MaLopKhoaHoc.Text;
                tbl_DangKyKhoaHoc_Used dkkh = new tbl_DangKyKhoaHoc_Used(ttk,makh);
                B_KhoaHoc_Used.DangKyKhoaHoc_Used(dkkh);
                MessageBox.Show("Tài khoản " + TenTaiKhoan + " đã đăng ký thành công khóa học " + lb_TenKhoaHoc.Text + " !!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

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
    public partial class GUI_ChuyenKhoa : Form
    {
        public GUI_ChuyenKhoa()
        {
            InitializeComponent();
        }

        string MaLopKhoaHoc;
        public string GetMaLopKhoaHoc
        {
            get { return MaLopKhoaHoc; }
            set
            {
                MaLopKhoaHoc = value;
            }
        }
        string TenLopKhoaHoc;
        public string GetTenLopKhoaHoc
        {
            get { return TenLopKhoaHoc; }
            set
            {
                TenLopKhoaHoc = value;
            }
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
            dgv_KhoaHocCungLoai.DataSource = B_KhoaHoc_Used.getKhoaHocCungLoai(MaLopKhoaHoc);
            dgv_KhoaHocCungLoai.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            lb_MaLopKhoaHoc.Text = dgv_KhoaHocCungLoai.Rows[0].Cells[0].Value.ToString();
            lb_TenKhoaHoc.Text = dgv_KhoaHocCungLoai.Rows[0].Cells[1].Value.ToString();
            lb_ngayKhaiGiang.Text = dgv_KhoaHocCungLoai.Rows[0].Cells[2].Value.ToString();
            lb_HocPhi.Text = dgv_KhoaHocCungLoai.Rows[0].Cells[3].Value.ToString();
            lb_SoTietHoc.Text = dgv_KhoaHocCungLoai.Rows[0].Cells[4].Value.ToString();
        }

        private void GUI_ChuyenKhoa_Load(object sender, EventArgs e)
        {
            lb_maKH_Hientai.Text = MaLopKhoaHoc;
            lb_TenLopKH_HienTai.Text = TenLopKhoaHoc;
            lb_TenTaiKhoan.Text = TenTaiKhoan;
            DislayData();
        }

        private void dgv_KhoaHocCungLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_KhoaHocCungLoai.CurrentRow.Index;
            lb_MaLopKhoaHoc.Text = dgv_KhoaHocCungLoai.Rows[i].Cells[0].Value.ToString();
            lb_TenKhoaHoc.Text = dgv_KhoaHocCungLoai.Rows[i].Cells[1].Value.ToString();
            lb_ngayKhaiGiang.Text = dgv_KhoaHocCungLoai.Rows[i].Cells[2].Value.ToString();
            lb_HocPhi.Text = dgv_KhoaHocCungLoai.Rows[i].Cells[3].Value.ToString();
            lb_SoTietHoc.Text = dgv_KhoaHocCungLoai.Rows[i].Cells[4].Value.ToString();
            dgv_All_LopHoc.DataSource = B_KhoaHoc_Newbie.getLopHocChoNewbie(lb_MaLopKhoaHoc.Text);
            dgv_All_LopHoc.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btn_XemChiTietLopHoc_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_XacNhanChuyenKhoa_Click(object sender, EventArgs e)
        {
            try
            {
                B_KhoaHoc_Used.XacNhanChuyenKhoa(lb_maKH_Hientai.Text, lb_MaLopKhoaHoc.Text, TenTaiKhoan);
                MessageBox.Show("Tài khoản " + TenTaiKhoan + " đã chuyển thành công từ khóa học " + lb_maKH_Hientai.Text + " sang khóa học: "+ lb_MaLopKhoaHoc.Text + "!!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

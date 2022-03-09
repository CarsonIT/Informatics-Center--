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
    public partial class KhoaHocDaDangKy : Form
    {
        public KhoaHocDaDangKy()
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
            dgv_All_KhoaHoc.DataSource = B_KhoaHoc_Used.getKhoaHocChoUsed(TenTaiKhoan);
            dgv_All_KhoaHoc.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            lb_MaLopKhoaHoc.Text = dgv_All_KhoaHoc.Rows[0].Cells[0].Value.ToString();
            lb_TenKhoaHoc.Text = dgv_All_KhoaHoc.Rows[0].Cells[1].Value.ToString();
            lb_ngayKhaiGiang.Text = dgv_All_KhoaHoc.Rows[0].Cells[2].Value.ToString();
            lb_HocPhi.Text = dgv_All_KhoaHoc.Rows[0].Cells[3].Value.ToString();
            lb_SoTietHoc.Text = dgv_All_KhoaHoc.Rows[0].Cells[4].Value.ToString();
        }

        private void KhoaHocDaDangKy_Load(object sender, EventArgs e)
        {
            lb_TenTaiKhoan.Text = TenTaiKhoan;
            DislayData();
        }

        private void dgv_All_KhoaHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_All_KhoaHoc.CurrentRow.Index;
            lb_MaLopKhoaHoc.Text = dgv_All_KhoaHoc.Rows[i].Cells[0].Value.ToString();
            lb_TenKhoaHoc.Text = dgv_All_KhoaHoc.Rows[i].Cells[1].Value.ToString();
            lb_ngayKhaiGiang.Text = dgv_All_KhoaHoc.Rows[i].Cells[2].Value.ToString();
            lb_HocPhi.Text = dgv_All_KhoaHoc.Rows[i].Cells[3].Value.ToString();
            lb_SoTietHoc.Text = dgv_All_KhoaHoc.Rows[i].Cells[4].Value.ToString();
            dgv_All_LopHoc.DataSource = B_KhoaHoc_Used.getLopHocChoUsed(TenTaiKhoan, lb_MaLopKhoaHoc.Text);
            dgv_All_LopHoc.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btn_XemChiTietLopHoc_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_XemKetQua_Click(object sender, EventArgs e)
        {
            string malkh;
            malkh= B_KhoaHoc_Used.LoaiKhoaHoc(lb_MaLopKhoaHoc.Text);
            if (malkh == "Chuyên đề")
            {
                string kq;
                kq = B_KhoaHoc_Used.LayKQKhoaHoc(TenTaiKhoan, lb_MaLopKhoaHoc.Text);
                MessageBox.Show(kq);

            }
            if (malkh == "Đào tạo chứng chỉ")
            {
                GUI_KQLopChungChi kq = new GUI_KQLopChungChi();
                kq.Message = lb_MaLopKhoaHoc.Text;
                kq.Message1 = lb_TenKhoaHoc.Text;
                kq.Message2 = TenTaiKhoan;
                kq.ShowDialog();
            }
            if (malkh == "Kỹ thuật viên")
            {
                GUI_KQLopKTV kq = new GUI_KQLopKTV();
                kq.Message = lb_MaLopKhoaHoc.Text;
                kq.Message1 = lb_TenKhoaHoc.Text;
                kq.Message2 = TenTaiKhoan;
                kq.ShowDialog();
            }


        }

        private void btn_ChuyenKhoa_Click(object sender, EventArgs e)
        {
            if (B_KhoaHoc_Used.KiemTraKhoaHocDaHocChua(lb_MaLopKhoaHoc.Text) == 0)
            {
                MessageBox.Show("Đã quá thời hạn để có thể chuyển khóa.!!!");
            }
            else
            {
                GUI_ChuyenKhoa ck = new GUI_ChuyenKhoa();
                ck.GetTenTaiKhoan = lb_TenTaiKhoan.Text;
                ck.GetMaLopKhoaHoc = lb_MaLopKhoaHoc.Text;
                ck.GetTenLopKhoaHoc = lb_TenKhoaHoc.Text;
                ck.ShowDialog();
            }
        }
    }
}

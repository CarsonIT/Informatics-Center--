using GiaoDien.DangKyKhoaHoc_Newbie;
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
    public partial class Newbie_DangKyKhoaHoc : Form
    {
        public Newbie_DangKyKhoaHoc()
        {
            InitializeComponent();
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
        private void btn_Chon_Click(object sender, EventArgs e)
        {
            GUI_DangKyThongTin dktt = new GUI_DangKyThongTin();
            dktt.GetMaKhoaHoc = lb_MaLopKhoaHoc.Text;
            dktt.GetTenKhoaHoc = lb_TenKhoaHoc.Text;
            dktt.ShowDialog();
        }

        private void Newbie_DangKyKhoaHoc_Load(object sender, EventArgs e)
        {
            DislayData();
        }

        private void dgv_KhoaHoc_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void btn_XemChiTietLopHoc_Click(object sender, EventArgs e)
        {
           
        }
    }
}

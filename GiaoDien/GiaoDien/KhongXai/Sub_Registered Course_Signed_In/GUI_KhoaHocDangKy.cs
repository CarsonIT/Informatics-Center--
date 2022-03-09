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
    public partial class GUI_KhoaHocDangKy : Form
    {
        public GUI_KhoaHocDangKy()
        {
            InitializeComponent();
        }
        private void DislayData()
        {
            dgv_KhoaHoc.DataSource = B_HocVienThamGiaLopHoc.GetKhoaHocCuaHocVien(1);
            dgv_KhoaHoc.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            lb_MaHocVien.Text = dgv_KhoaHoc.Rows[0].Cells[0].Value.ToString();
            lb_TenHocVien.Text = dgv_KhoaHoc.Rows[0].Cells[1].Value.ToString();
            lb_TenKhoaHoc.Text = dgv_KhoaHoc.Rows[0].Cells[2].Value.ToString();
            lb_HocPhi.Text = dgv_KhoaHoc.Rows[0].Cells[3].Value.ToString();
        }

        private void btn_Chon_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_SubMenu subMenu = new GUI_SubMenu();
            subMenu.Message = lb_TenKhoaHoc.Text;
            subMenu.ShowDialog();
            this.Close();
        }

        private void GUI_KhoaHocDangKy_Load(object sender, EventArgs e)
        {
            DislayData();
        }

        private void dgv_KhoaHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_KhoaHoc.CurrentRow.Index;
            lb_MaHocVien.Text = dgv_KhoaHoc.Rows[i].Cells[0].Value.ToString();
            lb_TenHocVien.Text = dgv_KhoaHoc.Rows[i].Cells[1].Value.ToString();
            lb_TenKhoaHoc.Text = dgv_KhoaHoc.Rows[i].Cells[2].Value.ToString();
            lb_HocPhi.Text = dgv_KhoaHoc.Rows[i].Cells[3].Value.ToString();
        }
    }
}

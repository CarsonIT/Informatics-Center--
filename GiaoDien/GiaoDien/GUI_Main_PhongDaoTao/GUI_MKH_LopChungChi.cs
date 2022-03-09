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
using DAL;
using DTO;
namespace GiaoDien
{
    public partial class GUI_MKH_LopChungChi : Form
    {
        public GUI_MKH_LopChungChi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tb_tmh1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_MKH_TextChanged(object sender, EventArgs e)
        {

            DataTable dt = B_NhomHocPhan_PDT.Get_TenHocPhanKTV(tb_MKH.Text);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox2.Items.Add(dr["TenHocPhan"].ToString());
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GUI_MKH_LopChungChi_Load(object sender, EventArgs e)
        {
            String str = "MKH101";
            tb_MKH.Enabled = true;
            tb_MKH.Text = str;
            String str1 = "MKH105";
            tb_MKH.Enabled = true;
            tb_MaKhoaHoc1.Text = str1;
        }

        private void tb_MaKhoaHoc1_TextChanged(object sender, EventArgs e)
        {

            DataTable dt = B_NhomHocPhan_PDT.Get_TenHocPhanKTV(tb_MaKhoaHoc1.Text);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["TenHocPhan"].ToString());
            }
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_GV_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = B_GiaoVien_PDT.GetAllGiaoVien();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView2.DataSource = B_GiaoVien_PDT.GetAllGiaoVien();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_MoKhoaHoc form = new GUI_MoKhoaHoc();
            form.ShowDialog();
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = B_NhomHocPhan_PDT.Get_MonHoc(comboBox2.Text);
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = B_NhomHocPhan_PDT.Get_MonHoc(comboBox1.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tb_MGV_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tb_tgh1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_TKH_Click(object sender, EventArgs e)
        {
           
        }

        private void tb_ThemKhoaHoc1_Click(object sender, EventArgs e)
        {
            try
            {
                String maLopKhoaHoc = tb_maLopKhoaHoc1.Text;
                String MaKhoaHoc = tb_MaKhoaHoc1.Text;
                DateTime NgayKG = TimePicker1_NKG1.Value;
                int SiSo = Convert.ToInt32(this.tb_SiSo1.Text);
                String MaMonHoc = tb_MaMonHoc1.Text;
                String TenMonHoc = tb_TenMonHoc1.Text;
                String MaLop = tb_MaLop1.Text;
                String thoigianhoc = tb_ThoiGianHoc1.Text;
                int MaGiaoVien = Convert.ToInt32(this.tb_MaGiaoVien1.Text);
                tbl_LopKhoaHoc insert_lkh = new tbl_LopKhoaHoc(maLopKhoaHoc, NgayKG, SiSo, MaKhoaHoc);
                tbl_LopMonHoc insert_lmh = new tbl_LopMonHoc(MaLop, thoigianhoc, maLopKhoaHoc, MaGiaoVien, MaMonHoc);
                B_LopKhoaHoc_PDT.Insert_LopKhoaHocKTV(insert_lkh, insert_lmh);
                MessageBox.Show("Thêm thành công");


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            dataGridView2.DataSource = B_LopMonHoc_PDT.View_LopMonDTCD(tb_MKH.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            dataGridView1.DataSource = B_LopMonHoc_PDT.View_LopMonDTCD(tb_MaKhoaHoc1.Text);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView2.Rows[e.RowIndex];
            if (dataGridView2.Columns[0].Name == "MaGV")
            {
                tb_MGV.Text = row.Cells["MaGV"].Value.ToString();
            }
            if (dataGridView2.Columns[0].Name != "MaGV")
            {
                tb_MMH.Text = row.Cells["MaMonHoc"].Value.ToString();
                tb_TMH.Text = row.Cells["TenMonHoc"].Value.ToString();

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            if (dataGridView1.Columns[0].Name == "MaGV")
            {
                tb_MaGiaoVien1.Text = row.Cells["MaGV"].Value.ToString();
            }
            if (dataGridView1.Columns[0].Name != "MaGV")
            {
                tb_MaMonHoc1.Text = row.Cells["MaMonHoc"].Value.ToString();
                tb_TenMonHoc1.Text = row.Cells["TenMonHoc"].Value.ToString();

            }
        }

        private void btn_ThemKH_ChungChiA_Click(object sender, EventArgs e)
        {
            try
            {
                String maLopKhoaHoc = tb_MLKH.Text;
                String MaKhoaHoc = tb_MKH.Text;
                DateTime NgayKG = timePicker_NKG.Value;
                int SiSo = Convert.ToInt32(this.tb_SS.Text);
                String MaMonHoc = tb_MMH.Text;
                String TenMonHoc = tb_TMH.Text;
                String MaLop = tb_ML.Text;
                String thoigianhoc = tb_ThoiGH.Text;
                int MaGiaoVien = Convert.ToInt32(this.tb_MGV.Text);
                tbl_LopKhoaHoc insert_lkh = new tbl_LopKhoaHoc(maLopKhoaHoc, NgayKG, SiSo, MaKhoaHoc);
                tbl_LopMonHoc insert_lmh = new tbl_LopMonHoc(MaLop, thoigianhoc, maLopKhoaHoc, MaGiaoVien, MaMonHoc);
                B_LopKhoaHoc_PDT.Insert_LopKhoaHocKTV(insert_lkh, insert_lmh);
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void tb_SiSo1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

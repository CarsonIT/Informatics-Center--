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
using DAL;
namespace GiaoDien
{
    public partial class GUI_MKH_LopKyThuatVien : Form
    {
        public GUI_MKH_LopKyThuatVien()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tb_MKH_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = B_NhomHocPhan_PDT.Get_TenHocPhanKTV(tb_MKH.Text);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["TenHocPhan"].ToString());
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GUI_MKH_LopKyThuatVien_Load(object sender, EventArgs e)
        {

            String str = "MKH102";
            tb_MKH.Enabled = true;
            tb_MKH.Text = str;

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
                String maLopKhoaHoc = tb_MLKH.Text;
                String MaKhoaHoc = tb_MKH.Text;
                DateTime NgayKG = timePicker_NKG.Value;
                int SiSo = Convert.ToInt32(this.tb_SS.Text);
                String MaMonHoc = tb_MMH1.Text;
                String TenMonHoc = tb_TMH.Text;
                String MaLop = tb_ML1.Text;
                String thoigianhoc = tb_tgh1.Text;
                int MaGiaoVien =  Convert.ToInt32(this.tb_MGV1.Text);
                tbl_LopKhoaHoc insert_lkh = new tbl_LopKhoaHoc(maLopKhoaHoc, NgayKG, SiSo, MaKhoaHoc);
                tbl_LopMonHoc insert_lmh = new tbl_LopMonHoc(MaLop, thoigianhoc, maLopKhoaHoc, MaGiaoVien, MaMonHoc);
                B_LopKhoaHoc_PDT.Insert_LopKhoaHocKTV(insert_lkh, insert_lmh);
                MessageBox.Show("Insert thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_MaLopKH1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

    

        private void tb_ML1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
              

            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

          
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = B_NhomHocPhan_PDT.Get_MonHoc(comboBox1.Text);
             
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = B_GiaoVien_PDT.GetAllGiaoVien();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            GUI_MoKhoaHoc form = new GUI_MoKhoaHoc();
            form.ShowDialog();
            
        }

        private void tb_tgh1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = B_LopMonHoc_PDT.View_LopMonKTV();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            if (dataGridView1.Columns[0].Name == "MaGV")
            {
                tb_MGV1.Text = row.Cells["MaGV"].Value.ToString();
            }
            if (dataGridView1.Columns[0].Name != "MaGV")
            {
                tb_MMH1.Text = row.Cells["MaMonHoc"].Value.ToString();
                tb_TMH.Text = row.Cells["TenMonHoc"].Value.ToString();
            }
        }

        private void tb_ML1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class GUI_MKH_LopChuyenDe : Form
    {
        public GUI_MKH_LopChuyenDe()
        {
            InitializeComponent();
        }

        private void GUI_MKH_LopChuyenDe_Load(object sender, EventArgs e)
        {
            datagridview1.DataSource = B_LopKhoaHoc_PDT.GetView_LopKhoaHocCD();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String malopkhoahoc = tb_MaLKH.Text;
                int maGV = Convert.ToInt32(tb_MaGV.Text);
                DateTime NgayKG = Date_NgayKG.Value;
                String makhoahoc = tb_MaKH.Text;
                int SiSo = Convert.ToInt32(this.tb_SiSo.Text);
                tbl_LopKhoaHoc insert_lkh = new tbl_LopKhoaHoc(malopkhoahoc, NgayKG, SiSo, maGV, makhoahoc);
                B_LopKhoaHoc_PDT.Insert_LopKhoaHocCD(insert_lkh);
                MessageBox.Show("Insert thanh cong");
                datagridview1.DataSource = B_LopKhoaHoc_PDT.GetView_LopKhoaHocCD(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_MoKhoaHoc form1 = new GUI_MoKhoaHoc();
            form1.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      

        }

        private void tb_MaKH_TextChanged(object sender, EventArgs e)
        {

          
            if (tb_MaKH!=null)
            {
                comboBox1.Items.Clear();
                DataTable dt = B_KhoaHoc_PDT.Get_TenChuyenDe(tb_MaKH.Text);
               
                foreach(DataRow dr in dt.Rows)
                {
                    comboBox1.Items.Add(dr["TenChuyenDe"].ToString());
                }    
            }                
                    
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            datagridview1.DataSource = B_KhoaHoc_PDT.GetView_KhoaHoc();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            datagridview1.DataSource = B_LopKhoaHoc_PDT.GetView_LopKhoaHoc();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_MaLKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            datagridview1.DataSource = B_GiaoVien_PDT.GetAllGiaoVien();
        }

        private void datagridview1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = datagridview1.Rows[e.RowIndex];
            if (datagridview1.Columns[0].Name == "MaKhoaHoc")
            {
                tb_MaKH.Text = row.Cells[0].Value.ToString();
            }

            if (datagridview1.Columns[0].Name == "MaGV")
            {
                tb_MaGV.Text = row.Cells["MaGV"].Value.ToString();
            }
        }
    }
}

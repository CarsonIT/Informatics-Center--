using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class GUI_MainMenu : Form
    {
        public GUI_MainMenu()
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
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btn_Registrated_Courses_Click(object sender, EventArgs e)
        {
            KhoaHocDaDangKy khddk = new KhoaHocDaDangKy();
            khddk.GetTenTaiKhoan = lb_TenTaiKhoan.Text;
            openChildForm(khddk);
        }

        private void btn_Course_Click(object sender, EventArgs e)
        {
            Used_DangKyKhoaHoc dkkh = new Used_DangKyKhoaHoc();
            dkkh.GetTenTaiKhoan = lb_TenTaiKhoan.Text;
            openChildForm(dkkh);
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            panel_main.Controls.Add(panel_cover);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_SignIn login = new GUI_SignIn();
            login.ShowDialog();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel_cover_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_logo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_side_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GUI_MainMenu_Load(object sender, EventArgs e)
        {
            lb_TenTaiKhoan.Text = TenTaiKhoan;
        }
    }
}

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
    public partial class GUI_Newbie_HocVien : Form
    {
        public GUI_Newbie_HocVien()
        {
            InitializeComponent();
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
        private void btn_Course_Click(object sender, EventArgs e)
        {
            openChildForm(new Newbie_DangKyKhoaHoc());
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            panel_main.Controls.Add(panel_cover);
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {

        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_SignIn signin = new GUI_SignIn();
            signin.ShowDialog();
            this.Close();
        }
    }
}

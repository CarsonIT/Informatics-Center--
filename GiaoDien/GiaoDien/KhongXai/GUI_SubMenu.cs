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
    public partial class GUI_SubMenu : Form
    {
        public GUI_SubMenu()
        {
            InitializeComponent();
            customizeDesign();
        }

        string strTemp;
        //Hàm lấy giá trị từ việc chọn 1 khóa học từ MainMenu ==> Submenu(cho các việc như chuyển lớp, kết quả học tập dễ dàng)
        public string Message
        {
            get { return strTemp; }
            set
            {
                strTemp = value;
            }
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            lb_TenKhoaHoc.Text = strTemp;
        }

        private void customizeDesign()
        {
            panel_Course_Submenu.Visible = false;
            panel_Registered_Submenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panel_Course_Submenu.Visible == true)
                panel_Course_Submenu.Visible = false;
            if (panel_Registered_Submenu.Visible == true)
                panel_Registered_Submenu.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void btn_Course_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_Course_Submenu);
        }

        private void btn_Registration_Click(object sender, EventArgs e)
        {
            openChildForm(new Used_DangKyKhoaHoc());
            //Your code ...
            //...
            hideSubmenu();
            panel_Course_Submenu.Visible = true;
        }

        private void btn_Registrated_Courses_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_Registered_Submenu);
        }

        private void btn_Results_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI_Learning_Results());
            //Your code ...

            //...
            hideSubmenu();
            panel_Registered_Submenu.Visible = true;

        }

        private void btn_Exam_Sche_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI_Exam_Schedule());

            //Your code ...
            //...
            hideSubmenu();
            panel_Registered_Submenu.Visible = true;
        }

        private void btn_ChangeClass_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI_ChuyenLop());

            //Your code ...
            //...
            hideSubmenu();
            panel_Registered_Submenu.Visible = true;
        }

        private void btn_DangKyThiLai_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI_DangKyThiLai());
            //Your code ...
            //...
            hideSubmenu();
            panel_Registered_Submenu.Visible = true;
        }

        private void btn_DangKyHoclai_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI_DangKyHocLai());
            //Your code ...
            //...
            hideSubmenu();
            panel_Registered_Submenu.Visible = true;
        }

        //to show child form in mainform

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

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            panel_main.Controls.Add(panel_cover);
        }
    }
}

using GiaoDien.LoginTableAdapters;
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

namespace GiaoDien
{
    public partial class GUI_SignIn : Form
    {
        public GUI_SignIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            int kq;
            kq = BUS_TaiKhoan.Login(txt_TenDangNhap.Text, txt_MatKhau.Text);
            if (kq== 1)
            {
                GUI_MainMenu mainMenuUsed = new GUI_MainMenu();
                mainMenuUsed.GetTenTaiKhoan = txt_TenDangNhap.Text;
                mainMenuUsed.ShowDialog();
                this.Hide();
            }
            if (kq == 2)
            {
                GUI_GiaoVien giaoVien = new GUI_GiaoVien();
                //giaoVien.GetTenTaiKhoan = txt_TenDangNhap.Text;
                giaoVien.ShowDialog();
                this.Hide();
            }
            if (kq == 3)
            {
                GUI_PhongDaoTao giaovu = new GUI_PhongDaoTao();
                //giaoVien.GetTenTaiKhoan = txt_TenDangNhap.Text;
                giaovu.ShowDialog();
                this.Hide();
            }
            if (kq==0)
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

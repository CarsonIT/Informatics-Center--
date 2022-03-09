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

namespace GiaoDien.DangKyKhoaHoc_Newbie
{
    public partial class GUI_DangKyThongTin : Form
    {
        public GUI_DangKyThongTin()
        {
            InitializeComponent();
        }

        //Hàm lấy giá trị Mã khóa học,Ten Khoa hoc từ FORM khác (FORM lúc chọn Khóa học)
        string MaKhoaHoc;
        public string GetMaKhoaHoc
        {
            get { return MaKhoaHoc; }
            set
            {
                MaKhoaHoc = value;
            }
        }
        string TenKhoaHoc;
        public string GetTenKhoaHoc
        {
            get { return TenKhoaHoc; }
            set
            {
                TenKhoaHoc = value;
            }
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            if (txt_HoTen.Text == "" || dtp_NgaySinh.Text == "" || rbt_GioiTinhNam.Text == "" || txt_Email.Text =="" || txt_SDT.Text == "" || txt_TenDangNhap.Text == "" || txt_MatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }    
            try
            {
                string tenhs = txt_HoTen.Text;
                DateTime ngaysinh = dtp_NgaySinh.Value;
                string gioitinh;
                if (rbt_GioiTinhNam.Checked)
                {
                    gioitinh = rbt_GioiTinhNam.Text;
                }
                else
                {
                    gioitinh = rbt_GioiTinh_Nu.Text;
                }
                string sdt = txt_SDT.Text;
                string email = txt_Email.Text;
                string tendangnhap = txt_TenDangNhap.Text;
                string matkhau = txt_MatKhau.Text;
                string makh = MaKhoaHoc;
                tbl_ThongTinCaNhan thongtincn = new tbl_ThongTinCaNhan(tenhs,ngaysinh,gioitinh,sdt,email,tendangnhap,matkhau,makh);
                B_KhoaHoc_Newbie.InsertHocVien(thongtincn);
                MessageBox.Show("Bạn " + tenhs + " đã đăng ký thành công khóa học "+ TenKhoaHoc +" !!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void GUI_DangKyThongTin_Load(object sender, EventArgs e)
        {
            lb_TenKH.Text = TenKhoaHoc;
        }
    }
}

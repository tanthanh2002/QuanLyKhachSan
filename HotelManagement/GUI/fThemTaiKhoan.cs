using HotelManagement.BUS;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HotelManagement.GUI
{
    public partial class fThemTaiKhoan : MaterialSkin.Controls.MaterialForm
    {
        private BcryptEncoder bcryptEncoder = BcryptEncoder.getInstance();
        private TaiKhoanService taiKhoanService = TaiKhoanService.getInstance();
        private NhanVienService nhanVienService= NhanVienService.getInstance();

        public fThemTaiKhoan()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }



        private void materialLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void btThemTKNV_Click(object sender, EventArgs e)
        {

            TaiKhoan taiKhoan = new TaiKhoan();
            taiKhoan.tentaikhoan = txtTK.Text.ToString();
            taiKhoan.matkhau = bcryptEncoder.HashPassword(txtMK.Text);
            taiKhoan.loaitaikhoan = txtLoaiTK.Text;
            taiKhoan.bikhoa = false;
            
            NhanVien nv = new NhanVien();
            nv.ten=txtTenNV.Text;
            nv.loai=txtLoaiNV.Text;
            nv.luong=double.Parse(txtLuong.Text);
            nv.trangthai = "còn làm việc";
            //nv.ngaybatdau=
            try
            {
                nv.TaiKhoan = taiKhoan;
                nhanVienService.save(nv);

                MessageBox.Show("Đăng ký thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Đăng ký thất bại!");
            }

        }
    }
}

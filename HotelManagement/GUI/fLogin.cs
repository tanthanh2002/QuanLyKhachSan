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

namespace HotelManagement.GUI
{
    public partial class fLogin : MaterialSkin.Controls.MaterialForm
    {
        private TaiKhoanService taiKhoanService = TaiKhoanService.getInstance();

        private KhachHangService khachHangService = KhachHangService.getInstance();

        private BcryptEncoder bcryptEncoder = BcryptEncoder.getInstance();
        private NhanVienService nhanVienService = NhanVienService.getInstance();
        public fLogin()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            if (username == "admin" && password == "123")
            {
                //fQuanLyTaiKhoan quanly = new fQuanLyTaiKhoan();
                //quanly.Show();
                //this.Visible = false;

                //fQuanLyDichVu quanly = new fQuanLyDichVu();
                //quanly.Show();
                //this.Visible = false;

                fQuanLyKhuyenMai quanly = new fQuanLyKhuyenMai();
                quanly.Show();
                this.Visible = false;
            }

            else {

                if (taiKhoanService.login(username, password))
                {
                    String type = taiKhoanService.findByUsername(username).loaitaikhoan;

                    CONST.TaiKhoanConst.setUser(taiKhoanService.findByUsername(username));

                    TaiKhoan curUser = CONST.TaiKhoanConst.getUser();
                    int matk = curUser.mataikhoan;
                    CONST.KhachHangConst.setKH(khachHangService.findByMaTaiKhoan(matk));
                    CONST.NhanVienConst.setNV(nhanVienService.findByMaTaiKhoan(matk));
                    //KhachHang curMaKH = CONST.KhachHangConst.getKH();
                    //int maKH = curMaKH.makhachhang;
                    //CONST.PhieuDatPhongConst.setMaPhieu(DatPhongService.find(maKH));

                    MessageBox.Show("Đăng nhập thành công! Bạn là " + type);
                    /////////////////////////////////////////
                    if (type == "ketoan")
                    {
                        fKeToanHome ketoan = new fKeToanHome();
                        ketoan.Show();
                        this.Visible = false;
                    }

                    if (type == "letan")
                    {
                        fLeTanHome lt = new fLeTanHome();
                        lt.Show();
                        this.Visible = false;
                    }

                    if (type == "khachhang")
                    {
                        fKhachHangHome kh = new fKhachHangHome();
                        kh.Show();
                        this.Visible = false;
                    }

                    if (type == "buongphong")
                    {
                        fBuongPhongHome bp = new fBuongPhongHome();
                        bp.Show();
                        this.Visible = false;
                    }

                    else
                    {
                        MessageBox.Show("không thể đăng nhập, bạn không có tài khoản!!");

                    }
                   
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!");
                }
            }
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControlMenu.SelectTab(tabRegister);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            String username = registerTxtUsername.Text;
            String password = registerTxtPassword.Text;
            String fullName = registerTxtFullName.Text;
            String phone = registerTxtPhone.Text;
            String email = registerTxtEmail.Text;
            String fax = registerTxtFax.Text;
            String id = registerTxtID.Text;
            String address = registerTxtAddress.Text;
            
            TaiKhoan taiKhoan = new TaiKhoan();
            taiKhoan.tentaikhoan = username;
            taiKhoan.matkhau = bcryptEncoder.HashPassword(password);
            taiKhoan.loaitaikhoan = "khachhang";
            taiKhoan.bikhoa = false;

            KhachHang khachHang = new KhachHang();
            khachHang.tenkhachhang = fullName;
            khachHang.diachi = address;
            khachHang.sodienthoai = phone;
            khachHang.cccd = id;
            khachHang.email = email;
            khachHang.sofax = fax;



            try
            {
                khachHang.TaiKhoan = taiKhoan;
                khachHangService.save(khachHang);

                MessageBox.Show("Đăng ký thành công!");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Đăng ký thất bại!");
            }
            


        }

        private void tabRegister_Click(object sender, EventArgs e)
        {

        }

        private void tabLogin_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel7_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class fRoomBook : MaterialSkin.Controls.MaterialForm
    {
        private DatPhongService datPhongService = DatPhongService.getInstance();

        private KhachHangService khachHangService = KhachHangService.getInstance();
        private int maKH;
        public fRoomBook()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang();
            khachHang.tenkhachhang = txtTenKhachHang.Text;
            khachHang.diachi = txtDiaChi.Text;
            khachHang.sodienthoai = txtSoDienThoai.Text;
            khachHang.sofax = txtSoFax.Text;
            khachHang.email = "";
            khachHang.cccd = txtCCCD.Text;
            //???
            khachHang.mataikhoan = 0;
            try
            {
                maKH = khachHangService.CheckInsertOrUpdate(khachHang);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Hãy kiểm tra lại thông tin cá nhân!"); 
            }
            PhieuDatPhong phieuDatPhong = new PhieuDatPhong();
            phieuDatPhong.yeucaudatbiet = txtYeuCauDacBiet.Text;
            phieuDatPhong.sodemluutru = Convert.ToInt32(txtSoDemLuuTru.Text);
            phieuDatPhong.ngayden = txtNgayDen.Value;
            phieuDatPhong.makhachhang = maKH;
            //???
            phieuDatPhong.nhanviencheckout = 0;
            phieuDatPhong.nhanvienvesinh = 0;
            try
            {
                datPhongService.addRoomBook(phieuDatPhong);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Hãy kiểm tra lại thông tin đặt phòng!");
            }
        }
    }
}

using HotelManagement.BUS;
using HotelManagement.TANN;
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
        private PhieuDatPhongChiTietService phieuDatPhongChiTietService = PhieuDatPhongChiTietService.getInstance();
        private PhieuSuDungDichVuService phieuSuDungDichVuService = PhieuSuDungDichVuService.getInstance();
        private PhieuSuDungDichVuChiTietService phieuSuDungDichVuChiTietService = PhieuSuDungDichVuChiTietService.getInstance();    
        private int maKH;
        private int maTK;

        private int maPhong;
        private int maPhieuDatPhong;
        private decimal gia;
        private int maPhieuDP;

        private KhachHang khachHang = new KhachHang();
        private PhieuDatPhong phieuDatPhong = new PhieuDatPhong();
        private PhieuDatPhongChiTiet phieuDatPhongChiTiet = new PhieuDatPhongChiTiet();
        private PhieuSuDungDichVu phieuSuDungDichVu = new PhieuSuDungDichVu();
        private PhieuSuDungDichVuChiTiet phieuSuDungDichVuChiTiet = new PhieuSuDungDichVuChiTiet();
        public fRoomBook()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            TANN.EventAggregator.Instance.Subscribe<datPhongSelected>(Load);
            LoadDefault();
        }

        private void LoadDefault()
        {
            TaiKhoan curUser = CONST.TaiKhoanConst.getUser();
            khachHang = khachHangService.findByMaTaiKhoan(curUser.mataikhoan);
            txtTenKhachHang.Text = khachHang.tenkhachhang.ToString();
            txtSoDienThoai.Text = khachHang.sodienthoai.ToString();
            txtDiaChi.Text = khachHang.diachi.ToString();
            txtSoFax.Text = khachHang.sofax.ToString();
            txtEmail.Text = khachHang.email.ToString();
            txtCCCD.Text = khachHang.cccd.ToString();
            txtMaPhong.Text = maPhong.ToString();
        }
        private new void Load(datPhongSelected obj)
        {
            maPhong = obj._maPhong;
            txtMaPhong.Text = maPhong.ToString();
            gia = obj._gia;
        }

        private void themKhachHang(KhachHang khachHang)
        {
            var newView = new fOnlinePayment();
            newView.Show();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
           /* try
            {
                maKH = khachHangService.CheckInsertOrUpdate(khachHang);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Hãy kiểm tra lại thông tin cá nhân!");
            }*/
           //PhieuDatPhong
            phieuDatPhong.yeucaudatbiet = txtYeuCauDacBiet.Text.ToString();
            phieuDatPhong.sodemluutru = Convert.ToInt32(txtSoDemLuuTru.Text);
            phieuDatPhong.ngayden = txtNgayDen.Value;
            phieuDatPhong.makhachhang = khachHang.makhachhang;
            phieuDatPhong.checkin = false;
           /* phieuDatPhong.nhanviencheckout = 0;
            phieuDatPhong.nhanvienvesinh = 0;*/
            //PhieuDatPhongChiTiet
            phieuDatPhongChiTiet.maphong = maPhong;
            //PhieuSuDungDichVu
            phieuSuDungDichVu.tongtien = (double?)(phieuDatPhong.sodemluutru * gia);
            phieuSuDungDichVu.maletan = 0;
            //PhieuSuDungDichVuChiTiet
            //phieuSuDungDichVuChiTiet.soluong = 0;
            /*phieuSuDungDichVuChiTiet.thoigiansudung = phieuDatPhong.sodemluutru;
            phieuSuDungDichVuChiTiet.thoigianbatdau = phieuDatPhong.ngayden;
            phieuSuDungDichVuChiTiet.dongia = (float)gia;
            phieuSuDungDichVuChiTiet.tenkhachhang = khachHang.tenkhachhang;*/

            try
            {
                maPhieuDatPhong = datPhongService.themPhieuDatPhong(phieuDatPhong);
                phieuDatPhongChiTiet.maphieudatphong = maPhieuDatPhong;
                phieuDatPhongChiTietService.themPhieuDPCT(phieuDatPhongChiTiet);
                phieuSuDungDichVu.maphieudatphong = maPhieuDatPhong;
                int temp = phieuSuDungDichVuService.addPhieuSuDungDichVu(phieuSuDungDichVu);
                /*phieuSuDungDichVuChiTietService.addPhieuSuDungDichVuChiTiet(phieuSuDungDichVuChiTiet);*/
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Hãy kiểm tra lại thông tin đặt phòng!");
            }
            var newView = new fOnlinePayment();
            newView.Show();
            TANN.EventAggregator.Instance.Publish(new onlinePaymentInf(maPhieuDatPhong, phieuSuDungDichVu.tongtien));
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

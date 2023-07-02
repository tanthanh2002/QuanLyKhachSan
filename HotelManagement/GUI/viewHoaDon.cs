using HotelManagement.BUS;
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
    public partial class viewHoaDon : Form

    {
        private int maphieudatphong;
        private HoaDonService hoaDonService = HoaDonService.getInstance();
        private PhieuDatPhongService phieuDatPhongService = PhieuDatPhongService.getInstance();
        private PhieuSuDungThucPhamService phieuSuDungThucPhamService = PhieuSuDungThucPhamService.getInstance();
        private PhieuSuDungDichVuService phieuSuDungDichVuService = PhieuSuDungDichVuService.getInstance();
        private PhieuHuHongNoiThatService phieuHuHongNoiThatService = PhieuHuHongNoiThatService.getInstance();
        private PhieuDatPhongChiTietService phieuDatPhongChiTietService = PhieuDatPhongChiTietService.getInstance();


        public viewHoaDon(int maphieudatphong)
        {
            InitializeComponent();
            loadViewHoaDon(maphieudatphong);
            this.maphieudatphong = maphieudatphong;
        }


        #region
        void loadViewHoaDon(int maphieudatphong)
        {
            PhieuDatPhong phieuDatPhong = phieuDatPhongService.getById(maphieudatphong);
            float tienphong = 0;

            HoaDon hoaDon = hoaDonService.findByMaPhieuDatPhong(maphieudatphong);

            if(hoaDon == null) {
                hoaDon = new HoaDon();
            }
     
            hoaDon.maphieudatphong = maphieudatphong;

            //tien dich vu
            hoaDon.tiendichvu = phieuSuDungDichVuService.tongTienDichVu(maphieudatphong);
            //tien thuc pham
            hoaDon.tienthucpham = phieuSuDungThucPhamService.tongTienThucPham(maphieudatphong);
            //tien hu hong noi that
            hoaDon.tienhuhongnoithat = phieuHuHongNoiThatService.tongTienHuHong(maphieudatphong);
            tienphong = (float) phieuDatPhongChiTietService.listMaPhongByMaPhieuDatPhong(maphieudatphong).Sum(p => p.Phong.gia);
            hoaDon.tongtien = hoaDon.tiendichvu + hoaDon.tienthucpham + tienphong + hoaDon.tienhuhongnoithat;
            hoaDon.sotiendathanhtoan = 1;
            if(hoaDon.tinhtrang == "đã thanh toán")
            {
                btnThanhToan.Enabled = false;
            }
            hoaDonService.addInvoice(hoaDon);

            lblMaPhieuDatPhong.Text = "";
            lblTenKhachHang.Text = "";
            lblTienDichVu.Text = "";
            lblTienHuHong.Text = "";
            lblTienPhong.Text = "";
            lblTienThucPham.Text = "";
            lblTongTien.Text = "";
            lblTinhTrang.Text = "";
            lblDaTra.Text = "";
            txtConLai.Text = "";



        }
        #endregion
        private void lblTienPhong_Click(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int maphieudatphong = this.maphieudatphong;
            PhieuDatPhong phieuDatPhong = phieuDatPhongService.getById(maphieudatphong);
            float tienphong = 0;

            HoaDon hoaDon = hoaDonService.findByMaPhieuDatPhong(maphieudatphong);
            hoaDon.tinhtrang = "đã thanh toán";
            hoaDonService.addInvoice(hoaDon);

        }

        private void viewHoaDon_Load(object sender, EventArgs e)
        {

        }
    }
}

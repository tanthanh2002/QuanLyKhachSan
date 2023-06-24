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
using HotelManagement.BUS;

namespace HotelManagement.GUI
{
    public partial class fKhachHangHome : MaterialSkin.Controls.MaterialForm
    {
        private KhachHangService khachHangService = KhachHangService.getInstance();
        private TourDuLichService tourDuLichService = TourDuLichService.getInstance();
        private DatTourService datTourService = DatTourService.getInstance();
        private PhieuDatPhongChiTietService phieuDatPhongChiTietService = PhieuDatPhongChiTietService.getInstance();
        private DichVuService dichVuService = DichVuService.getInstance();
        private PhieuSuDungDichVuChiTietService phieuSuDungDichVuChiTietService = PhieuSuDungDichVuChiTietService.getInstance();
        private PhieuSuDungDichVuService phieuSuDungDichVuService = PhieuSuDungDichVuService.getInstance();
        private PhieuDatPhongService phieuDatPhongService = PhieuDatPhongService.getInstance();
        int maDV = -1;
        public fKhachHangHome()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            loadThongTinTaiKhoanCuaToi();
            loadDSTour();
            loadDSTourCuaToi();
            KhachHang curUser = CONST.KhachHangConst.getKH();
            int makh = curUser.makhachhang;
            tbMaKhach.Text = Convert.ToString(makh);

            showComboBoxMaPhong(makh);
            int maPhongcb = Convert.ToInt32(cbMaPhong.Text);
            ListDVCoHoTroTheoMaKH(maPhongcb, makh);
            ListDVKhongHoTroTheoMaKH(maPhongcb, makh);

            loadDSDichVuCuaToi();
        }
        private void showComboBoxMaPhong(int makh)
        {
            cbMaPhong.ValueMember = "maphong";
            cbMaPhong.DataSource = phieuDatPhongChiTietService.showListMaPhong(makh);
        }
        private void ListDVCoHoTroTheoMaKH(int maPhongcb, int makh)
        {
            dgvDVCoHoTro.DataSource = dichVuService.showListDVCoHoTroTheoMaKH(maPhongcb, makh);
        }

        private void ListDVKhongHoTroTheoMaKH(int maPhongcb, int makh)
        {
            dgvDVKhongHoTro.DataSource = dichVuService.showListDVKhongHoTroTheoMaKH(maPhongcb, makh);
        }
        private void fKhachHangHome_Load(object sender, EventArgs e)
        {

        }

        private void phongBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void phongCuaToi_Click(object sender, EventArgs e)
        {

        }
        private void loadThongTinTaiKhoanCuaToi()
        {
            TaiKhoan curUser = CONST.TaiKhoanConst.getUser();
            dgvTKCuaToi.DataSource = khachHangService.TTKHfindByMaTaiKhoan(curUser.mataikhoan);
        }
        private void loadDSTour()
        {
            dgvDSTour.DataSource = tourDuLichService.dsTour();
        }
        private void loadDSTourCuaToi()
        {
            TaiKhoan curUser = CONST.TaiKhoanConst.getUser();
            dgvTourCuaToi.DataSource = datTourService.DSDatTourfindByMaTaiKhoan(curUser.mataikhoan);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvDSTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDSTour.CurrentRow.Selected = true;
            tbMaTour.Text = dgvDSTour.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dgvDSTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvDSTour.Rows[e.RowIndex];
            tbMaTour.Text = Convert.ToString(row.Cells["matour"].Value);
        }

        private void dtpKhoiHanh_ValueChanged(object sender, EventArgs e)
        {
            dtpKhoiHanh.Format = DateTimePickerFormat.Custom;
            dtpKhoiHanh.CustomFormat = "MM/dd/yyyy hh:mm tt";
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DatTour dattour = new DatTour();
            dattour.matour = Convert.ToInt32(tbMaTour.Text);
            dattour.makhachhang = Convert.ToInt32(tbMaKhach.Text);
            dattour.thoigiankhoihanh = Convert.ToDateTime(dtpKhoiHanh.Text);
            dattour.thoigiantrove = Convert.ToDateTime(dtpTroVe.Text);
            dattour.soluonghanhkhach = Convert.ToInt32(nudSoLuong.Value);
            try
            {
                datTourService.addDatTour(dattour);
                loadDSTourCuaToi();
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var newView = new fRoomSearch();
            newView.ShowDialog();
        }
        private void cbMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            KhachHang curUser = CONST.KhachHangConst.getKH();
            int makh = curUser.makhachhang;
            int maPhongcb = Convert.ToInt32(cbMaPhong.Text);
            ListDVCoHoTroTheoMaKH(maPhongcb, makh);
            ListDVKhongHoTroTheoMaKH(maPhongcb, makh);
        }

        private void dtpThoiGianBatDau_ValueChanged(object sender, EventArgs e)
        {
            dtpThoiGianBatDau.Format = DateTimePickerFormat.Custom;
            dtpThoiGianBatDau.CustomFormat = "MM/dd/yyyy hh:mm tt";
        }

        private void dgvDVCoHoTro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KhachHang curUser = CONST.KhachHangConst.getKH();
            int makh = curUser.makhachhang;
            dgvDVCoHoTro.CurrentRow.Selected = true;
            tbTenDichVu.Text = dgvDVCoHoTro.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbMaPhieuDatPhong.Text = phieuDatPhongService.getMaPhieuDatPhongByMaKH(makh).ToString();
        }

        private void dgvDVKhongHoTro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KhachHang curUser = CONST.KhachHangConst.getKH();
            int makh = curUser.makhachhang;
            dgvDVKhongHoTro.CurrentRow.Selected = true;
            tbTenDichVu.Text = dgvDVKhongHoTro.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbMaPhieuDatPhong.Text = phieuDatPhongService.getMaPhieuDatPhongByMaKH(makh).ToString();
        }

        private void btnDangKyDV_Click(object sender, EventArgs e)
        {
            PhieuSuDungDichVu phieu = new PhieuSuDungDichVu();
            phieu.maphieudatphong = Convert.ToInt32(tbMaPhieuDatPhong.Text);
            phieu.tongtien = Convert.ToDouble(tbTongTienDV.Text);
            phieu.maletan = -1;
            try
            {
                phieuSuDungDichVuService.addPhieuSuDungDichVu(phieu);

                PhieuSuDungDichVuChiTiet phieuchitiet = new PhieuSuDungDichVuChiTiet();
                phieuchitiet.madichvu = maDV;
                phieuchitiet.maphieusudungdichvu = phieuSuDungDichVuService.MaPhieuSuDungDichVuLatest();
                phieuchitiet.soluong = Convert.ToInt32(nudSoLuongDV.Value);
                phieuchitiet.thoigianbatdau = Convert.ToDateTime(dtpThoiGianBatDau.Value);
                phieuchitiet.thoigiansudung = Convert.ToInt32(tbThoiGianSuDung.Text);
                phieuchitiet.dongia = Convert.ToDouble(tbTongTienDV.Text);
                phieuchitiet.tenkhachhang = "";
                phieuSuDungDichVuChiTietService.addPhieuSuDungDichVuChiTiet(phieuchitiet);
                loadDSDichVuCuaToi();
                //phieuchitiet.madichvu = 2;
                //phieuchitiet.maphieusudungdichvu = 30;
                //phieuchitiet.soluong = 2;
                //phieuchitiet.thoigianbatdau = Convert.ToDateTime(dtpThoiGianBatDau.Value);
                //phieuchitiet.thoigiansudung = 60;
                //phieuchitiet.dongia = 345217;
                //phieuchitiet.tenkhachhang = "van";
                //phieuSuDungDichVuChiTietService.addPhieuSuDungDichVuChiTiet(phieuchitiet);
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Thêm thất bại!");
            }
        }



        private void nudSoLuongDV_ValueChanged(object sender, EventArgs e)
        {
            string tenDV = tbTenDichVu.Text;
            int maDV = dichVuService.getMaDVbyTenDV(tenDV);
            int soLuong = Convert.ToInt32(nudSoLuongDV.Value);
            tbTongTienDV.Text = Convert.ToString(dichVuService.sumDonGiaDV(soLuong, maDV));
        }

        private void tbTenDichVu_TextChanged(object sender, EventArgs e)
        {
            string tenDV = tbTenDichVu.Text;
            maDV = Convert.ToInt32(dichVuService.getMaDVbyTenDV(tenDV));
        }
        private void loadDSDichVuCuaToi()
        {
            KhachHang curUser = CONST.KhachHangConst.getKH();
            int makh = curUser.makhachhang;
            int maphieudat = phieuDatPhongService.getMaPhieuDatPhongByMaKH(makh);
            dgvDVCuaToi.DataSource = phieuSuDungDichVuChiTietService.DSDichVufindByMaDatPhong(maphieudat);
        }

        private void btnTimKiemTenDV_Click(object sender, EventArgs e)
        {
            string tenDV = tbTenDVTimKiem.Text;
            int maPhongcb = Convert.ToInt32(cbMaPhong.Text);
            KhachHang curUser = CONST.KhachHangConst.getKH();
            int makh = curUser.makhachhang;
            int maphieudat = phieuDatPhongService.getMaPhieuDatPhongByMaKH(makh);
            dgvDVCoHoTro.DataSource = dichVuService.showListDVCoHoTroTheoMaPhieuDatTimKiem(maPhongcb, maphieudat, tenDV);
            dgvDVCoHoTro.DataSource = dichVuService.showListDVKhongHoTroTheoMaPhieuDatTimKiem(maPhongcb, maphieudat, tenDV);
        }

        private void btnTimKiemTour_Click(object sender, EventArgs e)
        {
            string tenTOur = tbTenTour.Text;
            dgvDSTour.DataSource = tourDuLichService.getAllByTenTour(tenTOur);
        }
    }
}

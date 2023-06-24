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
    public partial class fLeTanHome : MaterialSkin.Controls.MaterialForm
    {
        private DichVuService dichVuService = DichVuService.getInstance();
        private PhieuDatPhongService phieuDatPhongService = PhieuDatPhongService.getInstance();
        private PhieuDatPhongChiTietService phieuDatPhongChiTietService = PhieuDatPhongChiTietService.getInstance();
        private PhongService phongService = PhongService.getInstance();
        private KhachHangService khachHangService = KhachHangService.getInstance();
        private TourDuLichService tourDuLichService = TourDuLichService.getInstance();
        private DatTourService datTourService = DatTourService.getInstance();
        private PhieuSuDungDichVuService phieuSuDungDichVuService = PhieuSuDungDichVuService.getInstance();
        private PhieuSuDungDichVuChiTietService phieuSuDungDichVuChiTietService = PhieuSuDungDichVuChiTietService.getInstance();
        int maDV = -1;
        public fLeTanHome()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            loadDSPhong();
            
            // tab dk tour
            cbMaKHDatTour.ValueMember = "makhachhang";
            cbMaKHDatTour.DataSource = khachHangService.getAll();

            // tab tour cua toi
            loadDSTour();
            loadDSTourDK();
            cbMaKHTimTour.ValueMember = "makhachhang";
            cbMaKHTimTour.DataSource = khachHangService.getAll();

            // tab dich vu
            cbMaPhieuDat.ValueMember = "maphieudatphong";
            cbMaPhieuDat.DataSource = phieuDatPhongService.listDSDatPhongCurrent();
            // tab dich vu cua toi
            cbMaPhieuDatPhongDV.ValueMember = "maphieudatphong";
            cbMaPhieuDatPhongDV.DataSource = phieuDatPhongService.listDSDatPhongCurrent();


        }

        private void fKhachHangHome_Load(object sender, EventArgs e)
        {

        }

        private void loadDSPhong()
        {
            DSPhongDaCheckin.DataSource = phongService.findByBiKhoa();
        }

        private void DSPhongDaCheckin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DSPhongDaCheckin.Columns[e.ColumnIndex].Name == "DichVu")
            {
                fDichVu dichVu = new fDichVu();
                dichVu.Show();
                this.Visible = true;
            }
        }

        private void phongBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        private void loadDSTour()
        {
            dgvDSTour.DataSource = tourDuLichService.dsTour();
        }
        private void dgvDSTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDSTour.CurrentRow.Selected = true;
            tbMaTour.Text = dgvDSTour.Rows[e.RowIndex].Cells[0].Value.ToString();
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
            dattour.makhachhang = Convert.ToInt32(cbMaKHDatTour.Text);
            dattour.thoigiankhoihanh = Convert.ToDateTime(dtpKhoiHanh.Text);
            dattour.thoigiantrove = Convert.ToDateTime(dtpTroVe.Text);
            dattour.soluonghanhkhach = Convert.ToInt32(nudSoLuong.Value);
            try
            {
                datTourService.addDatTour(dattour);
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void loadDSTourDK()
        {
            dgvDSTourDK.DataSource = datTourService.getAll();
        }

        private void btnTimKiemMaKH_Click(object sender, EventArgs e)
        {
            int makh = Convert.ToInt32(cbMaKHTimTour.Text);
            dgvDSTourDK.DataSource = datTourService.getByMaKH(makh);
        }

        private void cbMaPhieuDat_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maphieu = Convert.ToInt32(cbMaPhieuDat.Text);
            cbMaPhong.ValueMember = "maphong";
            cbMaPhong.DataSource = phieuDatPhongChiTietService.listMaPhongByMaPhieuDatPhong(maphieu);
        }
        private void ListDVCoHoTroTheoMaKH(int maPhongcb, int maphieudatphong)
        {
            dgvDVCoHoTro.DataSource = dichVuService.showListDVCoHoTroTheoMaPhieuDat(maPhongcb, maphieudatphong);
        }

        private void ListDVKhongHoTroTheoMaKH(int maPhongcb, int maphieudatphong)
        {
            dgvDVKhongHoTro.DataSource = dichVuService.showListDVKhongHoTroTheoMaPhieuDat(maPhongcb, maphieudatphong);
        }

        private void cbMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maPhongcb = Convert.ToInt32(cbMaPhong.Text);
            int maPhieuDat = Convert.ToInt32(cbMaPhieuDat.Text);
            ListDVCoHoTroTheoMaKH(maPhongcb, maPhieuDat);
            ListDVKhongHoTroTheoMaKH(maPhongcb, maPhieuDat);
        }
        private void dtpThoiGianBatDau_ValueChanged(object sender, EventArgs e)
        {
            dtpThoiGianBatDau.Format = DateTimePickerFormat.Custom;
            dtpThoiGianBatDau.CustomFormat = "MM/dd/yyyy hh:mm tt";
        }
        private void dgvDVCoHoTro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDVCoHoTro.CurrentRow.Selected = true;
            tbTenDichVu.Text = dgvDVCoHoTro.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbMaPhieuDatPhong.Text = cbMaPhieuDat.Text;
        }

        private void dgvDVKhongHoTro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDVKhongHoTro.CurrentRow.Selected = true;
            tbTenDichVu.Text = dgvDVKhongHoTro.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbMaPhieuDatPhong.Text = cbMaPhieuDat.Text;
        }

        private void btnDangKyDV_Click(object sender, EventArgs e)
        {
            NhanVien curUser = CONST.NhanVienConst.getNV();
            int manv = curUser.manhanvien;

            PhieuSuDungDichVu phieu = new PhieuSuDungDichVu();
            phieu.maphieudatphong = Convert.ToInt32(tbMaPhieuDatPhong.Text);
            phieu.tongtien = Convert.ToDouble(tbTongTienDV.Text);
            phieu.maletan = manv;
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
                phieuchitiet.tenkhachhang = tbTenKHDKDV.Text;
                phieuSuDungDichVuChiTietService.addPhieuSuDungDichVuChiTiet(phieuchitiet);
                loadDSDichVuCuaToi();
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
            dgvDSDVDaDK.DataSource = phieuSuDungDichVuChiTietService.getAll();
        }

        private void btnTimKiemDVDK_Click(object sender, EventArgs e)
        {
            int maphieu = Convert.ToInt32(cbMaPhieuDatPhongDV.Text);
            dgvDSDVDaDK.DataSource = phieuSuDungDichVuChiTietService.getAllByMaPhieuDatPhong(maphieu);
        }

        private void btnTimKiemTenDV_Click(object sender, EventArgs e)
        {
            string tenDV = tbTenDVTimKiem.Text;
            int maPhongcb = Convert.ToInt32(cbMaPhong.Text);
            int maphieudatphong = Convert.ToInt32(cbMaPhieuDat.Text);
            dgvDVCoHoTro.DataSource = dichVuService.showListDVCoHoTroTheoMaPhieuDatTimKiem(maPhongcb, maphieudatphong, tenDV);
            dgvDVCoHoTro.DataSource = dichVuService.showListDVKhongHoTroTheoMaPhieuDatTimKiem(maPhongcb, maphieudatphong, tenDV);
        }

        private void btnTimKiemTour_Click(object sender, EventArgs e)
        {
            string tenTOur = tbTenTour.Text;
            dgvDSTour.DataSource = tourDuLichService.getAllByTenTour(tenTOur);

        }
    }
}

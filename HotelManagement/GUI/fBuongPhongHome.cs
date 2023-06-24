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
    public partial class fBuongPhongHome : MaterialSkin.Controls.MaterialForm
    {
        private PhongService phongService = PhongService.getInstance();
        private ThucPhamService thucPhamService = ThucPhamService.getInstance();
        private NoiThatService noiThatService = NoiThatService.getInstance();
        private PhieuDatPhongChiTietService phieuDatPhongChiTietService = PhieuDatPhongChiTietService.getInstance();
        private PhieuSuDungThucPhamService phieuSuDungThucPhamService = PhieuSuDungThucPhamService.getInstance();
        private PhieuHuHongNoiThatService phieuHuHongNoiThatService = PhieuHuHongNoiThatService.getInstance();
        int maPhong;
        public fBuongPhongHome()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            loadDSPhong();
            cbTenThucPham.ValueMember = "tenthucpham";
            cbTenThucPham.DataSource = thucPhamService.showListThucPham();
            cbTinhTrangPhong.Items.Add("Chưa sẵn sàng");
            cbTinhTrangPhong.Items.Add("Đã sẵn sàng");
            cbTimMaPhong.ValueMember = "maphong";
            cbTimMaPhong.DataSource = phongService.dsPhong();
        }

        private void loadDSPhong()
        {
            dgvDSPhong.DataSource = phongService.dsPhong();
        }

        private void dgvDSPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDSPhong.CurrentRow.Selected = true;
            tbMaPhong.Text = dgvDSPhong.Rows[e.RowIndex].Cells[0].Value.ToString();
            maPhong = Convert.ToInt32(dgvDSPhong.Rows[e.RowIndex].Cells[0].Value);
            cbTenNoiThat.ValueMember = "ten";
            cbTenNoiThat.DataSource = noiThatService.showListNoiThat(maPhong);
            cbMaPhieuDat.ValueMember = "maphieudatphong";
            cbMaPhieuDat.DataSource = phieuDatPhongChiTietService.showListMaPhieuDatPhong(maPhong);
        }

        private void btnCapNhatTinhTrangPhong_Click(object sender, EventArgs e)
        {
            string tinhtrang = cbTinhTrangPhong.Text;
            try
            {
                phongService.updateTinhTrangPhong(maPhong, tinhtrang);
                loadDSPhong();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Cập nhật thất bại thất bại!");
            }
        }

        private void btnThemPhieuSuDungThucPham_Click(object sender, EventArgs e)
        {
            PhieuSuDungThucPham phieu = new PhieuSuDungThucPham();
            phieu.maphieudatphong = Convert.ToInt32(cbMaPhieuDat.Text);
            phieu.maphong = Convert.ToInt32(tbMaPhong.Text);
            int maThucPhamTemp = phieuSuDungThucPhamService.getMaThucPham(cbTenThucPham.Text);
            phieu.mathucpham = maThucPhamTemp;
            phieu.soluong = Convert.ToInt32(nudSoLuong.Text);
            int soLuong = Convert.ToInt32(nudSoLuong.Text);
            phieu.dongia = phieuSuDungThucPhamService.sumDonGia(soLuong, maThucPhamTemp);
            
            try
            {
                phieuSuDungThucPhamService.addPhieuSuDungThucPham(phieu);
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void dgvDSPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fBuongPhongHome_Load(object sender, EventArgs e)
        {

        }

        private void btnPhieuHuHongNoiThat_Click(object sender, EventArgs e)
        {
            PhieuHuHongNoiThat phieu = new PhieuHuHongNoiThat();
            phieu.maphieudatphong = Convert.ToInt32(cbMaPhieuDat.Text);
            int maNoiThatTemp = phieuHuHongNoiThatService.getMaNoiThat(cbTenNoiThat.Text);
            phieu.manoithat = maNoiThatTemp;
            double giaTienDenTemp = phieuHuHongNoiThatService.calGiaTienDen(maNoiThatTemp);
            phieu.giatienden = giaTienDenTemp;
            try
            {
                phieuHuHongNoiThatService.addPhieuHuHongNoiThatChiTiet(phieu);
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnTimKiemMaPhong_Click(object sender, EventArgs e)
        {
            int maphong = Convert.ToInt32(cbTimMaPhong.Text);
            dgvDSPhong.DataSource = phongService.dsPhongbyMaPhong(maphong);
        }
    }
}

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

            cbMaPhong.ValueMember = "maphong";
            cbMaPhong.DataSource = phieuDatPhongChiTietService.showListMaPhong(makh);
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
            string searchValue = tbTenTour.Text;
            dgvDSTour.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvDSTour.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var newView = new fRoomSearch();
            newView.ShowDialog();
        }
    }
}

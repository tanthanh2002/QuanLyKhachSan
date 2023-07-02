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
    public partial class fQuanLyKhuyenMai : MaterialSkin.Controls.MaterialForm
    {
        private BUS.KhuyenMaiService khuyenMaiService = BUS.KhuyenMaiService.getInstance();

        private KhuyenMai khuyenMai = new KhuyenMai();

        public fQuanLyKhuyenMai()
        {
            InitializeComponent();
            LoadDefault();
        }

        private void LoadDefault()
        {
            dgvDSKM.DataSource = khuyenMaiService.layDS();
            dgvDSKMThem.DataSource = khuyenMaiService.layDS();
            dgvSuaKM.DataSource = khuyenMaiService.layDS();

        }



        private void btnThemKM_Click(object sender, EventArgs e)
        {
            khuyenMai.tenkhuyenmai = Convert.ToString(txtTenKMThem.Text);
            khuyenMai.thoigianbatdau = DateTime.Parse(txtngayBDKMThem.Text);
            khuyenMai.thoigianketthuc = DateTime.Parse(txtNgayKTKMThem.Text);
            khuyenMai.ngaykhoa = DateTime.Parse(txtNgayKhoaKMThem.Text);
            khuyenMaiService.themKM(khuyenMai);
            LoadDefault();
        }

        private void btnSuaKM_Click(object sender, EventArgs e)
        {
            khuyenMai.thoigianbatdau = DateTime.Parse(txtNgayBDKMSua.Text);
            khuyenMai.thoigianketthuc = DateTime.Parse(txtNgayktKMSua.Text);

            khuyenMaiService.suaTTKM(khuyenMai);
            LoadDefault();
        }

        private void dgvSuaKM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvSuaKM.CurrentRow.Selected = true;

            khuyenMai.makhuyenmai = Convert.ToInt32(dgvSuaKM.Rows[e.RowIndex].Cells[0].Value);
            khuyenMai.tenkhuyenmai = dgvSuaKM.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMaKMSua.Text = khuyenMai.makhuyenmai.ToString();
            txtTenKMSua.Text = khuyenMai.tenkhuyenmai.ToString();
        }

        private void fQuanLyKhuyenMai_Load(object sender, EventArgs e)
        {

        }
    }
}

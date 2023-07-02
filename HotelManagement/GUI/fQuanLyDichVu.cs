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
    public partial class  fQuanLyDichVu : MaterialSkin.Controls.MaterialForm

    {
        private BUS.DichVuService dichVuService = BUS.DichVuService.getInstance();

        private int maDV;
        private string tenDV;

        private DichVu dichVu = new DichVu();

        public fQuanLyDichVu()
        {
            InitializeComponent();
            LoadDefault();
        }
        private void LoadDefault()
        {
            dgvDSDV.DataSource = dichVuService.layDS();
            dgvDSDVSua.DataSource = dichVuService.layDS();
            dgvThemDV.DataSource = dichVuService.layDS();
            

        }   

        private void dgvDSDVSua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDSDVSua.CurrentRow.Selected = true;
            dichVu.madichvu = Convert.ToInt32(dgvDSDVSua.Rows[e.RowIndex].Cells[0].Value);
            dichVu.tendichvu = dgvDSDVSua.Rows[e.RowIndex].Cells[1].Value.ToString();
            dichVu.gia = Convert.ToDouble(dgvDSDVSua.Rows[e.RowIndex].Cells[2].Value);
            txtTenDVSua.Text = dichVu.tendichvu.ToString();
            txtMaDVSua.Text = dichVu.madichvu.ToString();
            txtGiaCu.Text = dichVu.gia.ToString(); 
        }

        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            dichVu.gia = Convert.ToDouble(txtGiaMoi.Text);

            dichVuService.suaGiaDV(dichVu);
            LoadDefault();

        }

        private void dgvThemDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void fQuanLyDichVu_Load(object sender, EventArgs e)
        {

        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            
            dichVu.tendichvu = Convert.ToString(txtTenDVMoi.Text);
            dichVu.gia = Convert.ToDouble(txtGiaDVMoi.Text);
            dichVuService.themDV(dichVu);
            LoadDefault();
        }

        private void dgvDSDVKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void text_GiaMoi_Click(object sender, EventArgs e)
        {

        }
    }
}

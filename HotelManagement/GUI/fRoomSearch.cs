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
    public partial class fRoomSearch : MaterialSkin.Controls.MaterialForm
    {
        private TimPhongService timPhongService = TimPhongService.getInstance();

        DataGridViewRow row = new DataGridViewRow();
        private int maphong;
        private decimal gia;
        public fRoomSearch()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            float theoGia = 0;
            string theoSoPhong = "0";
            if (checkGia1.Checked)
            {
                theoGia = 2000000;
            }
            else if (checkGia2.Checked)
            {
                theoGia = 5000000;
            }
            else theoGia = 0;
            if (checkSoLuong1.Checked)
            {
                theoSoPhong = "1";
            }
            else if (checkSoLuong2.Checked)
            {
                theoSoPhong = "2";
            }
            else theoSoPhong = "0";

            dgvDSPhong.DataSource = timPhongService.tiemKiemPhong(theoGia, theoSoPhong);
           
        }

        private void dgvDSPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dgvDSPhong.Rows[e.RowIndex];
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (dgvDSPhong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng!");
            }
            else
            {

                /*int maphong = Convert.ToInt32(row.Cells["maphong"].Value);
                decimal gia = Convert.ToDecimal(row.Cells["gia"].Value);*/
                /* maphong = Convert.ToInt32(dgvDSPhong.Rows[e.RowIndex].Cells[0].Value);
                 gia = Convert.ToDecimal(dgvDSPhong.Rows[e.RowIndex].Cells[2].Value);*/
                var newView = new fRoomBook();
                newView.Show();
                TANN.EventAggregator.Instance.Publish(new datPhongSelected(maphong, gia));
               
                //return;
            }
        }
        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvDSPhong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng!");
            }
            else
            {
                return;
            }
        }
        private void btnXong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDSPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDSPhong.CurrentRow.Selected = true;
            //tbTenDichVu.Text = dgvDVCoHoTro.Rows[e.RowIndex].Cells[1].Value.ToString();
            maphong = Convert.ToInt32(dgvDSPhong.Rows[e.RowIndex].Cells[0].Value);
            gia = Convert.ToDecimal(dgvDSPhong.Rows[e.RowIndex].Cells[2].Value);

            /* row = dgvDSPhong.Rows[e.RowIndex];
             maphong = Convert.ToInt32(row.Cells[0].Value);
             gia = Convert.ToDecimal(row.Cells[2].Value);*/
        }
    }
}

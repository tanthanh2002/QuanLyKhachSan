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
    public partial class fKeToanHome : MaterialSkin.Controls.MaterialForm
    {
        HoaDonService hoaDonService = HoaDonService.getInstance();
        NhanVienService nhanVienService = NhanVienService.getInstance();

        public fKeToanHome()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            load();
            loadBangLuong();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        // thống kê doanh thu

        private void load()
        {
            dataGridViewDSHD.DataSource = hoaDonService.getAll();
        }

        private void loadBangLuong()
        {
            dataGridViewDSNVL.DataSource = nhanVienService.getAll();
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            dataGridViewDSHD.DataSource = hoaDonService.findByDate(dateTimePickertk.Value);
        }



        //sửa lương nhân viên
        private void btThayDoiLuong_Click(object sender, EventArgs e)
        {
            try
            {
                nhanVienService.changeLuong(int.Parse(txtMaNV.Text), float.Parse(txtLuong.Text));
                MessageBox.Show("thành công");
                loadBangLuong();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewDSNVL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridViewDSNVL.CurrentRow.Index;
            txtMaNV.Text = dataGridViewDSNVL.Rows[i].Cells[0].Value.ToString();
        }
    }
}

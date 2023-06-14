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
    public partial class fQuanLyTaiKhoan : MaterialSkin.Controls.MaterialForm
    {
        TaiKhoanService taikhoanService = TaiKhoanService.getInstance();
        //không kbao repo
        public fQuanLyTaiKhoan()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            load();
        }

        private void load()
        {
            dataGridViewdstk.DataSource = taikhoanService.getAll();//List,dataTable
        }

        private void btTHemTK_Click(object sender, EventArgs e)
        {
            fThemTaiKhoan themtk = new fThemTaiKhoan();
            themtk.Show();
            //this.Visible = false;
        }

        private void btChinhSua_Click(object sender, EventArgs e)
        {
            fChinhSuaTaiKhoan chinhtk = new fChinhSuaTaiKhoan(txtTenTK.Text);
            chinhtk.Show();
        }

        private void btKhoaTK_Click(object sender, EventArgs e)
        {
            taikhoanService.lockTaiKhoan(txtTenTK.Text);
            load();
        }

        private void btMoTK_Click(object sender, EventArgs e)
        {
            taikhoanService.unlockTaiKhoan(txtTenTK.Text);
            load();
        }

        private void dataGridViewdstk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridViewdstk.CurrentRow.Index;
            txtTenTK.Text = dataGridViewdstk.Rows[i].Cells[1].Value.ToString();
        }

        private void btRS_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}

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
        private PhongService phongService = PhongService.getInstance();

        public fLeTanHome()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            loadDSPhong();
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
    }
}

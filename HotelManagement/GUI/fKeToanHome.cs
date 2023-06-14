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

        public fKeToanHome()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            load();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void load()
        {

        }
    }
}

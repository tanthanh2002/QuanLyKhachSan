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
    public partial class fRoomSearch : MaterialSkin.Controls.MaterialForm
    {
        private TimPhongService timPhongService = TimPhongService.getInstance();
        public fRoomSearch()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btnXong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            float theoGia = 0;
            int theoSoPhong = 0;
            if (checkBinhDan.Checked)
            {
                theoGia = 2000000;
            }
            else if (checkCaoCap.Checked)
            {
                theoGia = 5000000;
            }
            if (checkPhongDon.Checked)
            {
                theoSoPhong = 1;
            }
            else if (checkPhongDoi.Checked)
            {
                theoSoPhong = 2;
            }
            // dataGridViewKetQua = timPhongService.GetPhongList(theoGia, theoSoPhong);
        }

        
    }
}

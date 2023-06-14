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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HotelManagement.GUI
{
    public partial class fChinhSuaTaiKhoan : MaterialSkin.Controls.MaterialForm
    {
        TaiKhoanService taiKhoanService=TaiKhoanService.getInstance();

        public fChinhSuaTaiKhoan(string tenTK)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            txtTenTK.Text = tenTK;
        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btDoiMK_Click(object sender, EventArgs e)
        {
            try
            {
                taiKhoanService.changePassword(txtTenTK.Text, txtMKCu.Text, txtMKMoi.Text);
                MessageBox.Show("thay đổi mật khẩu thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

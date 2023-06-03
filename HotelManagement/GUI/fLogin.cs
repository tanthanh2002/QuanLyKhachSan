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
    public partial class fLogin : MaterialSkin.Controls.MaterialForm
    {
        private TaiKhoanService taiKhoanService = TaiKhoanService.getInstance();
        public fLogin()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            if(taiKhoanService.login(username, password))
            {
                String type = taiKhoanService.findByUsername(username).loaitaikhoan;
                MessageBox.Show("Đăng nhập thành công! Bạn là " + type);
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
            }
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

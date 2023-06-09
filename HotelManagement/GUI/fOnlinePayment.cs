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
    public partial class fOnlinePayment : MaterialSkin.Controls.MaterialForm
    {
        private ThanhToanCocOnlineService thanhToanCocOnlineService = ThanhToanCocOnlineService.getInstance();
        public fOnlinePayment()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btnThanhCong_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.tiendichvu = 0;
            hoaDon.tienthucpham = 0;
            hoaDon.tienhuhongnoithat = 0;
            hoaDon.tongtien = Convert.ToDouble(txtMaDatPhong.Text);
            hoaDon.sotiendathanhtoan = Convert.ToDouble(txtSoTienDaThanhToan.Text);
            hoaDon.maphieudatphong = Convert.ToInt32(txtMaDatPhong.Text);
            //ma ke toan ? nen cho bang 0 neu dat online => nen bo khoa ngoai haojc them 1 nhan vien ma laf 0
            hoaDon.maketoan = 0;
            hoaDon.tinhtrang = "Da coc";
            try
            {
                thanhToanCocOnlineService.createInvoice(hoaDon);
                MessageBox.Show("Quý khách đã chuyển tiền cọc thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Quý khách chuyển tiền cọc thất bại!");
            }
        }
    }
}

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
    public partial class fOnlinePayment : MaterialSkin.Controls.MaterialForm
    {
        private ThanhToanCocOnlineService thanhToanCocOnlineService = ThanhToanCocOnlineService.getInstance();

        private HoaDon hoaDon = new HoaDon();
        public fOnlinePayment()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            TANN.EventAggregator.Instance.Subscribe<onlinePaymentInf>(Load);
        }
        private new void Load(onlinePaymentInf obj)
        {
            hoaDon.maphieudatphong = obj._maDP;
            hoaDon.tongtien = (double)obj._tongTien;
            txtMaDatPhong.Text = hoaDon.maphieudatphong.ToString();
            txtTongTien.Text = hoaDon.tongtien.ToString();
            txtNoiDungThanhToan.Text = hoaDon.maphieudatphong.ToString() + "-Datphong";
            hoaDon.sotiendathanhtoan = hoaDon.tongtien * 30 / 100;
            txtSoTienDaThanhToan.Text = hoaDon.sotiendathanhtoan.ToString();
        }
        private void btnThanhCong_Click(object sender, EventArgs e)
        {
            hoaDon.tiendichvu = 1;
            hoaDon.tienthucpham = 1;
            hoaDon.tienhuhongnoithat = 1;
            hoaDon.tinhtrang = "đã cọc";
            try
            {
                thanhToanCocOnlineService.createInvoice(hoaDon);
                MessageBox.Show("Quý khách đã chuyển tiền cọc thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Quý khách đã chuyển tiền cọc thành công!");
                this.Close();
            }
            
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

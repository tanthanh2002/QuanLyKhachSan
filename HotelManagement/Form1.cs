using HotelManagement.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class Form1 : Form
    {

        private KhachHangService khachHangService = KhachHangService.getInstance();

        private PhieuSuDungThucPhamService suDungThucPhamService = PhieuSuDungThucPhamService.getInstance();

        public Form1()
        {
            InitializeComponent();
        }
        #region methods
        
        void loadData()
        {
            List<KhachHang> list = new List<KhachHang>();
            list.Add(khachHangService.findByMaTaiKhoan(2));

            dataGridView1.DataSource = list.Select(p => new { p.tenkhachhang, p.mataikhoan, p.cccd}).ToList();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(suDungThucPhamService.getMaThucPham("coca").ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

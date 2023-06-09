﻿using HotelManagement.BUS;
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
    public partial class fTakeFeedback : MaterialSkin.Controls.MaterialForm
    {
        private PhieuDanhGiaService phieuDanhGiaService = PhieuDanhGiaService.getInstance();
        
        private PhieuSuDungDichVuChiTietService phieuSuDungDichVuChiTietService = PhieuSuDungDichVuChiTietService.getInstance();
        public fTakeFeedback()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            Load();
        }

        private void Load()
        {
          //  dataGridViewDS = phieuSuDungDichVuChiTietService.GetChiTietList(Convert.ToInt32(txtMaPhieuDatPhong.Text));
        }

        private void btnGhiNhan_Click(object sender, EventArgs e)
        {
            PhieuDanhGia phieuDanhGia = new PhieuDanhGia();
            phieuDanhGia.noidung = txtNoiDung.Text;
            phieuDanhGia.diem = Convert.ToInt32(txtDiem.Text);
            phieuDanhGia.makhachhang = -1;
            phieuDanhGia.maphieudanhgia = -1;
            try
            {
                phieuDanhGiaService.themDanhGia(phieuDanhGia);
                MessageBox.Show("Thêm đánh giá thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Thêm đánh giá thất bại!");
            }
        }
    }
}

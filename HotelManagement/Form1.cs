﻿using HotelManagement.BUS;
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

        public Form1()
        {
            InitializeComponent();
        }
        #region methods
        
        void loadData()
        {
            dataGridView1.DataSource = khachHangService.getAll();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

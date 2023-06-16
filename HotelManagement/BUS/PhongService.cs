﻿using HotelManagement.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BUS
{
    class PhongService
    {
        private static PhongService instance=new PhongService();

        private PhongRepo repo = PhongRepo.GetInstance();

        public static PhongService getInstance() { return instance; }

        public List<Phong> findByBiKhoa() { return repo.findByBiKhoa(); }

        public List<Phong> dsTour() { return repo.dsPhong(); }

        public List<Phong> showListTinhTrangPhong() { return repo.showListTinhTrangPhong(); }

        public void updateTinhTrangPhong(int maphong, string tinhtrang) { repo.updateTinhTrangPhong(maphong, tinhtrang); }
    }
}

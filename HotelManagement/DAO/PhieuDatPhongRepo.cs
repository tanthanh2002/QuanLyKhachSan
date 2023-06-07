﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    internal class PhieuDatPhongRepo
    {
        private static PhieuDatPhongRepo instance = new PhieuDatPhongRepo();
        private HotelManagementEntities db  = new HotelManagementEntities();
        private PhieuDatPhongRepo() { }

        public static PhieuDatPhongRepo getInstance() { return instance; }

        public void save(PhieuDatPhong phieuDatPhong) { 
            db.PhieuDatPhongs.Add(phieuDatPhong);
            db.SaveChanges();
        }

        public List<PhieuDatPhong> findByUsername(string username)
        {
            return db.PhieuDatPhongs.Where(p => p.KhachHang.tenkhachhang == username)
                .ToList();
        }

        public PhieuDatPhong findById(int id)
        {
            return db.PhieuDatPhongs.Find(id);
        }

        public void deleteById(int id)
        {
            db.PhieuDatPhongs.Remove(findById(id));
            db.SaveChanges();
        }
    }
}
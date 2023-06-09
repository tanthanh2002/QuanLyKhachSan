﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.DAO
{
    internal class NhanVienRepo
    {
        private HotelManagementEntities db = new HotelManagementEntities();
        private static NhanVienRepo instance = new NhanVienRepo();
        private NhanVienRepo() { }
        public static NhanVienRepo getInstance() { return instance; }

        public NhanVien findById(int id)
        {
            return db.NhanViens.Find(id);
        }
        
        public void save(NhanVien nhanVien)
        {
            try {
                db.NhanViens.AddOrUpdate(nhanVien);
                db.SaveChanges();
            }catch (Exception e) {
                Console.WriteLine(e.StackTrace);
                throw new Exception(e.Message);
            }
        }

        public void update(NhanVien nhanVien) { 
            db.NhanViens.AddOrUpdate(nhanVien) ; db.SaveChanges();
        }

        public List<NhanVien> getAll()
        {
            var result = from c in db.NhanViens select c;
            return result.ToList();
        }
        public NhanVien findByMaTaiKhoan(int mataikhoan)
        {
            return db.NhanViens.SingleOrDefault(p => p.TaiKhoan.mataikhoan == mataikhoan);
        }
    }
}

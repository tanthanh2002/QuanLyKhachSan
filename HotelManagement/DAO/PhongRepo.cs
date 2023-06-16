using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.DAO
{
    internal class PhongRepo
    {

        private static PhongRepo instance = new PhongRepo();
        private HotelManagementEntities db = new HotelManagementEntities();
        private PhongRepo() { }

        public static PhongRepo Instance { get {  return instance; } }

        public static PhongRepo GetInstance() { return instance; }
        public void save(Phong phong)
        {
            db.Phongs.Add(phong);
            db.SaveChanges();
        }

        public void delete(Phong phong) {  db.Phongs.Remove(phong); db.SaveChanges(); }

        public void updatePrice(int maphong, float price) {

            Phong phongUpdate = db.Phongs.Find(maphong);
            if(phongUpdate != null)
            {
                phongUpdate.gia=price;
                db.SaveChanges();
            }
        }

        public Phong findById(int id)
        {
            return db.Phongs.Find(id);
        }

        public Phong findByNumberRoom(string numberRoom) {  
            return db.Phongs.SingleOrDefault(p => p.sophong == numberRoom);
        }

        //Tan 
        public List<Phong> timPhongTheoGiaVaSLPhong(float theoGia, string theoSoPhong) 
        {
            if (theoGia == 0 && theoSoPhong == "0")
            {
                return db.Phongs.ToList();
            }
            else if (theoGia == 0)
            {
                return db.Phongs.Where(p => p.gia >= theoGia).ToList();
            }
            else if (theoSoPhong == "0")
            {
                return db.Phongs.Where(p => p.gia < theoGia).ToList();
            }
            else
            return db.Phongs.Where(p => p.gia < theoGia).ToList();
        }
        //

        public List<Phong> findByBiKhoa()
        {
            var s = db.Phongs.Where(p => p.bikhoa == true);
            return s.ToList();
        }

        public List<Phong> dsPhong()
        {
            return db.Phongs.ToList();
        }

        public List<Phong> showListTinhTrangPhong()
        {
            var s = from a in db.Phongs select a;
            return s.ToList();
        }

        public void updateTinhTrangPhong(int maphong, string tinhtrang)
        {
            Phong phongUpdate = db.Phongs.Find(maphong);
            if (phongUpdate != null)
            {
                phongUpdate.tinhtrang = tinhtrang;
                db.SaveChanges();
            }
        }

    }
}

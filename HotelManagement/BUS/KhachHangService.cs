using HotelManagement.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BUS
{
    public class KhachHangService
    {
        private static KhachHangService instance = new KhachHangService();

        private KhachHangRepo repo = KhachHangRepo.getInstance();

        private KhachHangService() { }

        public static KhachHangService getInstance() {  return instance; }

        public List<KhachHang> getAll()
        {
            return repo.getAll();
        }

        public void save(KhachHang khachHang)
        {
            repo.save(khachHang); 
        }

        public void register(KhachHang khachHang)
        {
            repo.save(khachHang);
        }

        public KhachHang findByMaTaiKhoan(int mataikhoan)
        {
            return repo.findByMaTaiKhoan(mataikhoan);
        }

        //Tan them
        public KhachHang findByCCCD(string CCCD)
        {
            return repo.findByCCCD(CCCD);
        }

        public int CheckInsertOrUpdate(KhachHang khachHang)
        {
            KhachHang temp = repo.findByCCCD(khachHang.cccd);
            if (temp == null)
            {
                repo.save(khachHang);
            }
            temp = repo.findByCCCD(khachHang.cccd);
            return temp.makhachhang;
        }
    }
}

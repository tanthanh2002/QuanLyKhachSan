using HotelManagement.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BUS
{
    public class TaiKhoanService
    {

        private static TaiKhoanService instance = new BUS.TaiKhoanService();

        private HotelManagementEntities db = new HotelManagementEntities();

        private KhachHangService khachHangService = KhachHangService.getInstance();
        
        private TaiKhoanRepo repo=TaiKhoanRepo.getInstance();
        private TaiKhoanService() { }

        public static TaiKhoanService getInstance() { return instance; }

        public TaiKhoan findByUsername(string username)
        {
           return repo.findByUsername(username);
        }

        public Boolean login(String username, String password)
        {
            try
            {
                TaiKhoan taiKhoan = repo.findByUsername(username);

                if (taiKhoan == null) { return false; }
                else
                {
                    return taiKhoan.matkhau == password;
                }
                return false;
            }catch(Exception e) { 
                return false; 
            }
            
        }


        public void save(TaiKhoan taiKhoan)
        {
            repo.save(taiKhoan);
        }

        public void update(TaiKhoan taiKhoan)
        {
            repo.saveOrUpdate(taiKhoan);
        }
    }
}

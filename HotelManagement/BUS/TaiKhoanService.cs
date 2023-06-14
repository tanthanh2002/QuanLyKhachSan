using HotelManagement.DAO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BUS
{
    public class TaiKhoanService
    {

        private static TaiKhoanService instance = new BUS.TaiKhoanService();

        private BcryptEncoder bcryptEncoder = BcryptEncoder.getInstance();

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
                    return bcryptEncoder.verify(password,taiKhoan.matkhau) && !taiKhoan.bikhoa;
                }
                return false;
            }catch(Exception e) { 
                return false; 
            }
            
        }
        public List<TaiKhoan> getAll() { return repo.getAll(); }

        public void save(TaiKhoan taiKhoan)
        {
            repo.save(taiKhoan);
        }

        public void update(TaiKhoan taiKhoan)
        {
            repo.saveOrUpdate(taiKhoan);
        }

        public void lockTaiKhoan(String username)
        {
            TaiKhoan taiKhoan = repo.findByUsername(username);
            taiKhoan.bikhoa = true;
            repo.save(taiKhoan);
        }

        public void unlockTaiKhoan(String username)
        {
            TaiKhoan taiKhoan = repo.findByUsername(username);
            taiKhoan.bikhoa = true;
            repo.save(taiKhoan);
        }

        public void changePassword(String username,String oldPassword, String newPassword)
        {
            try
            {
                TaiKhoan taiKhoan = repo.findByUsername(username);
                if(taiKhoan != null)
                {
                    throw new Exception("username not found!");
                }
                if (bcryptEncoder.verify(oldPassword, taiKhoan.matkhau))
                {
                    taiKhoan.matkhau = bcryptEncoder.HashPassword(newPassword);
                    repo.save(taiKhoan);
                }
                else
                {
                    throw new Exception("old password incorrect.");
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw new Exception(e.Message);
            }
        }

        public void resetPassword(String username)
        {
            TaiKhoan taiKhoan = repo.findByUsername(username);
            taiKhoan.matkhau = bcryptEncoder.HashPassword("123");
            repo.save(taiKhoan);
        }

    }
}

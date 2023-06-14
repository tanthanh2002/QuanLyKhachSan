using HotelManagement.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HotelManagement.BUS
{
    internal class NhanVienService
    {
        private static NhanVienService instance = new NhanVienService();
        private NhanVienRepo repo=NhanVienRepo.getInstance();

        private NhanVienService() { }
        public static NhanVienService getInstance() {  return instance; }
        public void save(NhanVien nhanVien)
        {
            repo.save(nhanVien);
        }
        
        public void changeLuong(int manhanvien, float luong) {
            try
            {
                NhanVien nhanVien = repo.findById(manhanvien);
                nhanVien.luong = luong;
                repo.save(nhanVien);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw new Exception(e.Message);
            }
        }

        public List<NhanVien> getAll() 
        {
            return repo.getAll();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    public class KhuyenMaiRepo
    {
        private static KhuyenMaiRepo instance = new KhuyenMaiRepo();

        private HotelManagementEntities db = new HotelManagementEntities();
        private KhuyenMaiRepo()
        {

        }

        public static KhuyenMaiRepo getInstance()
        {
            return instance;
        }
        public List<KhuyenMai> LayDS()
        {
            var result = from a in db.KhuyenMais
                         select a;
            return result.ToList();
        }
        public void suaTTKhuyenMai(KhuyenMai khuyenMai)
        {
            db.KhuyenMais.AddOrUpdate(khuyenMai);
            db.SaveChanges();
        }
        public void themKM(KhuyenMai khuyenMai)
        {
            db.KhuyenMais.AddOrUpdate(khuyenMai);
            db.SaveChanges();
        }

    }
       
}

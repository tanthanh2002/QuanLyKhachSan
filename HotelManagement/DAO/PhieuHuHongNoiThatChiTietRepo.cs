using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    internal class PhieuHuHongNoiThatChiTietRepo
    {
        private HotelManagementEntities db = new HotelManagementEntities();

        private static PhieuHuHongNoiThatChiTietRepo instance = new PhieuHuHongNoiThatChiTietRepo();

        private PhieuHuHongNoiThatChiTietRepo() { }

        public static PhieuHuHongNoiThatChiTietRepo getInstance() { return instance; }

        public int getMaNoiThat(string tennoithat)
        {
            NoiThat noiThat = db.NoiThats.SingleOrDefault(p => p.ten == tennoithat);
            if (noiThat != null)
            {
                return noiThat.manoithat;
            }
            else
            {
                return -1;
            }
        }
        public double calGiaTienDen(int manoithat)
        {
            NoiThat noiThat = db.NoiThats.SingleOrDefault(p => p.manoithat == manoithat);
            if (noiThat != null)
            {
                return (double)(noiThat.gia);
            }
            else
            {
                return -1;
            }
            
        }
        public void addPhieuHuHongNoiThatChiTiet(PhieuHuHongNoiThat phieu)
        {
            db.PhieuHuHongNoiThats.Add(phieu);
            db.SaveChanges();
        }
    }
}

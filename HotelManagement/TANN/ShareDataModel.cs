using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.TANN
{
    public class ShareDataModel
    {
        private static ShareDataModel instance;
        
        private ShareDataModel() { }
        public static ShareDataModel Instance
        {
            get
            {
                if (instance == null)
                    instance = new ShareDataModel();
                return instance;
            }
        }

    }
}

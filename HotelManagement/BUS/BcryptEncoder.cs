using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BUS
{
    internal class BcryptEncoder
    {
        private static BcryptEncoder instance = new BcryptEncoder();

        private BcryptEncoder() { }

        public static BcryptEncoder getInstance() { return instance; }

        public String HashPassword(String password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public Boolean verify(String rawPassword, String hashPassword)
        {
            return BCrypt.Net.BCrypt.Verify(rawPassword, hashPassword);
        }
    }
}

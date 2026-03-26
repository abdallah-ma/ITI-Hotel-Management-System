using System;
using System.Collections.Generic;
using System.Text;
using Hotel.DAL;
using Hotel.DAL.Identity;

namespace Hotel.BLL.Managers
{
    public static class UserManager
    {

        private readonly static HotelIdentityDbContext HotelIdentityDbContext = new HotelIdentityDbContext();

        public static bool CheckUser(User user)
        {
            return HotelIdentityDbContext.Users.
                FirstOrDefault(u => u.Username == user.Username && u.Password == user.Password) != null;
        }

        



    }
}

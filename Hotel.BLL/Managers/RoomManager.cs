using Hotel.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.BLL.Managers
{
    public static class RoomManager
    {

        private static readonly HotelDbContext HotelDbContext = new HotelDbContext();


        public static void MarkAsBooked(int roomId)
        {
            var room = HotelDbContext.Rooms.FirstOrDefault(r => r.RoomNumber == roomId);
            
            room.Booked = true;

            HotelDbContext.Update(room);
            HotelDbContext.SaveChanges();
        }

        public static void FreeRoom(int roomId)
        {
            var room = HotelDbContext.Rooms.FirstOrDefault(r => r.RoomNumber == roomId);

            room.Booked = false;
            HotelDbContext.Update(room);
            HotelDbContext.SaveChanges();

        }

    }
}

using Hotel.DAL;
using Hotel.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Data.SqlClient;
using Dapper;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace Hotel.BLL.Managers
{
    public static class ReservationManager
    {

        private static readonly HotelDbContext HotelDbContext = new HotelDbContext();

        public static BindingList<Reservation> GetAllReservation()
        {
            HotelDbContext.Reservations.Load();
            return HotelDbContext.Reservations.Local.ToBindingList();
        }


        public static BindingList<Reservation> GetAllReservationWithDapper()
        {

            string connectionString = ConfigurationManager.ConnectionStrings["Hotel"].ConnectionString;
            string query = "SELECT * FROM Reservations r JOIN Guests g ON r.GuestPhoneNumber = g.PhoneNumber JOIN Rooms rm ON r.RoomNumber = rm.RoomNumber";

            using (var connection = new SqlConnection(connectionString))
            {

                var reservationDictionary = new Dictionary<int , Reservation>();

                var reservations = connection.Query<Reservation , Guest , Reservation>(query , 
                    
                    (reservation , guest) => 
                    {

                        

                        reservation.Guest = guest;
                        return reservation;
                    } ,
                    splitOn:"FirstName"
                    
                   ).Distinct().ToList();

                if (reservations != null) return new BindingList<Reservation>(reservations);

            }

            return null;
        }

        public static int AddReservation(Reservation reservation)
        {

            bool free = HotelDbContext.Rooms.FirstOrDefault(r => r.RoomNumber == reservation.RoomNumber && !r.Booked) != null;

            if (!free) return 0;

            HotelDbContext.Reservations.Add(reservation);


            return HotelDbContext.SaveChanges();
        }

        public static int RemoveReservation(int reservationId)
        {
            var reservationToBeRemoved = HotelDbContext.Reservations.Find(reservationId);

            if(reservationToBeRemoved == null)
            {
                return 0;
            }

            HotelDbContext.Reservations.Remove(reservationToBeRemoved);
            return HotelDbContext.SaveChanges();
        }

        public static int UpdateReservation(Reservation reservation)
        {


            bool free = HotelDbContext.Reservations.FirstOrDefault(r => r.RoomNumber == reservation.RoomNumber && r.Id != reservation.Id) == null;

            if (!free) return 0;

            RoomManager.MarkAsBooked(reservation.RoomNumber);

            
            HotelDbContext.Update(reservation);
            return HotelDbContext.SaveChanges();
        }

    }
}

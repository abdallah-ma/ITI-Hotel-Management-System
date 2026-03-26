using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hotel.DAL.Entities
{
    public class Reservation
    {

        public int Id { get; set; }
        
        public virtual Guest Guest { get; set; }

        public string GuestPhoneNumber { get; set; }
        public virtual Room Room { get; set; }

        public int RoomNumber { get; set; }

        [NotMapped]
        public string Display => $"{Guest.FirstName} {Guest.LastName} | {RoomNumber}";

    }
}

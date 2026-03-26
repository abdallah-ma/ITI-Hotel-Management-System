using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hotel.DAL.Entities
{
    public class Guest
    {

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(15)]
        public string PhoneNumber { get; set; }


        public virtual List<Reservation> Reservations { get; set; }


    }
}

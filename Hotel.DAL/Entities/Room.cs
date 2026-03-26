using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hotel.DAL.Entities
{
    public class Room
    {
        [Key]
        public int RoomNumber { get; set; }

        public int FloorNumber { get; set; }

        public bool Booked { get; set; }

        
    }
}

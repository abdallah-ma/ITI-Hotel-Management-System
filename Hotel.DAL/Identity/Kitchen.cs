using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hotel.DAL.Identity
{
    public class Kitchen
    {
        [Key]
        [MaxLength(50)]
        public string Username { get; set; }

        [MaxLength(50)]

        public string Password { get; set; }
    }
}

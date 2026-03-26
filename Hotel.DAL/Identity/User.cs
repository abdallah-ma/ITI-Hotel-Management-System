using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hotel.DAL.Identity
{
    public class User
    {

        [MaxLength(50)]
        [Key]
        public string Username { get; set; }

        [MaxLength(50)]
        public string Password { get; set; }

    }
}

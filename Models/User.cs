using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace tour_logistic.Models
{
    [Table("Users")]
    public class User
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public ICollection<Route> Routes { get; set; }
    }

    
}
using System;
using System.Collections.Generic;

namespace tour_logistic.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public ICollection<Route> Routes { get; set; }
    }

    
}
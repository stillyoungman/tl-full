using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace tour_logistic.Models
{   
    [Table("Routes")]
    public class Route
    {
        public int RouteId { get; set; }
        public string Name { get; set; }
        public ICollection<Segment> Segments {get; set; }
    }
}
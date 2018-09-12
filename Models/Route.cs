using System;
using System.Collections.Generic;

namespace tour_logistic.Models
{
    public class Route
    {
        public int RouteId { get; set; }
        public string Name { get; set; }
        public ICollection<Segment> Segments {get; set; }
    }
}
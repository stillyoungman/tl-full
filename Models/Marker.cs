using System;

namespace tour_logistic.Models
{
    public class Marker
    {
        public int MarkerId { get; set; }
        public string Name { get; set; }
        public string Type {get; set; }
        public string Arrival {get; set; }
        public string Departure {get; set;}
        public string LatLang {get; set;}
    }
}
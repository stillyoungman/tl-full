using System;

namespace tour_logistic.Models
{
    public class Marker
    {
        public string Name { get; set; }
        public string Type {get; set; }
        public string Arrival {get; set; }
        public string Departure {get; set;}
        public object LatLang {get; set;}
    }
}
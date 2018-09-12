using System;
using System.Collections.Generic;

namespace tour_logistic.Models
{
    public class Segment
    {
        public int SegmentId { get; set; }
        public int Distance { get; set; }
        public ICollection<Section> Sections { get; set; }
    }
}
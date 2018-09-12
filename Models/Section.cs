namespace tour_logistic.Models
{
    public class Section
    {
        public int SectionId { get; set; }
        public string Path { get; set; }
        public string Params { get; set; }
        public Marker Marker { get; set; }
    }
}
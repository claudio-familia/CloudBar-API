namespace CloudBar.Domain.General
{
    public class Place : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}

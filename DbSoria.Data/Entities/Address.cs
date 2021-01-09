namespace DbSoria.Data.Entities
{
    public class Address : BaseEntity
    {
        public string CompleteAddress { get; set; }
        public string City { get; set; }
        public string Barangay { get; set; }
        public string ZipCode { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
    }
}
namespace SportClubSchedulerAPI.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string? Organisation { get; set; }
        public string StreetAddressLine { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
    }
}

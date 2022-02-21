using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportClubSchedulerAPI.Models
{
    public class Address
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string? Organisation { get; set; }

        [Required]
        [MaxLength(100)]
        public string StreetAddressLine { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string City { get; set; } = string.Empty;

        [Required]
        [MaxLength(10)]
        [Column(TypeName = "varchar(10)")]
        public string ZipCode { get; set; } = string.Empty;

        [Required]
        [MaxLength(2)]
        public string Country { get; set; } = string.Empty;
    }
}

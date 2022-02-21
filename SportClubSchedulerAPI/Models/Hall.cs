using System.ComponentModel.DataAnnotations;

namespace SportClubSchedulerAPI.Models
{
    public class Hall
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        public Address Address { get; set; } = new Address();
    }
}

using System.ComponentModel.DataAnnotations;

namespace SportClubSchedulerAPI.Models
{
    public class League
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public int Rang { get; set; }
    }
}

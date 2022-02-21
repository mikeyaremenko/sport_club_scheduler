using System.ComponentModel.DataAnnotations;

namespace SportClubSchedulerAPI.Models
{
    public class Club
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        public List<Team> Teams { get; set; } = new List<Team>();

        [MaxLength(100)]
        public string? Website { get; set; }
    }
}

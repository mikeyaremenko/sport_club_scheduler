using System.ComponentModel.DataAnnotations;

namespace SportClubSchedulerAPI.Models
{
    public class Player
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        public int Height { get; set; }
    }
}

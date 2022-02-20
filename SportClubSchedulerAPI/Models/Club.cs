namespace SportClubSchedulerAPI.Models
{
    public class Club
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Team> Teams { get; set; } = new List<Team>();
        public string? Website { get; set; }
    }
}

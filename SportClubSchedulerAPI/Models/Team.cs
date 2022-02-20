namespace SportClubSchedulerAPI.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Player> Player { get; set; } = new List<Player>();
    }
}

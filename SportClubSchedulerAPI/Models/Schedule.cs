namespace SportClubSchedulerAPI.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public Team Team { get; set; } = new Team();
        public Hall Hall { get; set; } = new Hall();
        public DateTime DateTime { get; set; } = new DateTime();
        public List<Player> Player { get; set; } = new List<Player>();
    }
}

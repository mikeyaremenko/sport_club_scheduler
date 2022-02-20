namespace SportClubSchedulerAPI.Models
{
    public class TrainingSchedule
    {
        public int Id { get; set; }
        public Team Team { get; set; } = new Team();
        public Hall SportHall { get; set; } = new Hall();
        public DateTime DateTime { get; set; } = new DateTime();
        public List<Player> Player { get; set; } = new List<Player>();
    }
}

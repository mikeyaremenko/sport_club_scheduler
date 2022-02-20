namespace SportClubSchedulerAPI.Models
{
    public class TrainingSchedule
    {
        public int Id { get; set; }
        public Team Team { get; set; } = new Team();
        public SportHall SportHall { get; set; } = new SportHall();
        public DateTime DateTime { get; set; } = new DateTime();
        public List<Player> Players { get; set; } = new List<Player>();
    }
}

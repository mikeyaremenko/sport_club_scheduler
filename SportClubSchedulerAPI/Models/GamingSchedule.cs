namespace SportClubSchedulerAPI.Models
{
    public class GamingSchedule
    {
        public int Id { get; set; }
        public Team HomeTeam { get; set; } = new Team();
        public Team GuestTeam { get; set; } = new Team();
        public SportHall SportHall { get; set; } = new SportHall();
        public DateTime DateTime { get; set; } = new DateTime();
        public string Result { get; set; } = string.Empty;
    }
}

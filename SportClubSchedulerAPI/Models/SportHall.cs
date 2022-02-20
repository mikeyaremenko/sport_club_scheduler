namespace SportClubSchedulerAPI.Models
{
    public class SportHall
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Address Address { get; set; } = new Address();
        public List<Equipment> Equipments { get; set; } = new List<Equipment>();
    }
}

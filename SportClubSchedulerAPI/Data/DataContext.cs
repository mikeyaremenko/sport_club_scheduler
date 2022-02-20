using Microsoft.EntityFrameworkCore;
using SportClubSchedulerAPI.Models;

namespace SportClubSchedulerAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Player> Player { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<League> League { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Hall> Hall { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<Club> Club { get; set; }
        public DbSet<TrainingSchedule> TrainingSchedule { get; set; }
        public DbSet<GamingSchedule> GamingSchedule { get; set; }
    }
}

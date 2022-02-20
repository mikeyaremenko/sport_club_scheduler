using Microsoft.EntityFrameworkCore;
using SportClubSchedulerAPI.Models;

namespace SportClubSchedulerAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Player> Player { get; set; } = default!;
        public DbSet<Equipment> Equipment { get; set; } = default!;
        public DbSet<League> League { get; set; } = default!;
        public DbSet<Address> Address { get; set; } = default!;
        public DbSet<Hall> Hall { get; set; } = default!;
        public DbSet<Team> Team { get; set; } = default!;
        public DbSet<Club> Club { get; set; } = default!;
        public DbSet<TrainingSchedule> TrainingSchedule { get; set; } = default!;
        public DbSet<GamingSchedule> GamingSchedule { get; set; } = default!;
    }
}

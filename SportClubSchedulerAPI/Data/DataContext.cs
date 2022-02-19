using Microsoft.EntityFrameworkCore;
using SportClubSchedulerAPI.Models;

namespace SportClubSchedulerAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Player> Players { get; set; }
    }
}

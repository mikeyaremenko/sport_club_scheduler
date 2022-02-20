﻿using Microsoft.EntityFrameworkCore;
using SportClubSchedulerAPI.Models;

namespace SportClubSchedulerAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Player> Players { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<SportHall> SportHalls { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<TrainingSchedule> TrainingSchedule { get; set; }
        public DbSet<GamingSchedule> GamingSchedule { get; set; }
    }
}

using BitGamb.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BitGamb.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}

        public DbSet<Robot> Robots {get; set;}
        public DbSet<User> Users {get; set;}
        public DbSet<RobotRace> RobotRaces {get; set;}

        public DbSet<RaceRegistries> RaceRegistries {get; set;}

    }
}
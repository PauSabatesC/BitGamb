using BitGamb.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BitGamb.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}

        public DbSet<Robot> Robots {get; set;}

    }
}
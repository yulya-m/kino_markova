using Kino26_Markova.Classes.Common;
using Kino26_Markova.Models;
using Microsoft.EntityFrameworkCore;

namespace Kino26_Markova.Classes
{
    public class ClubsContext : DbContext
    {
        public DbSet<Clubs> Clubs { get; set; }
        public ClubsContext()
        {
            Database.EnsureCreated();
            Clubs.Load();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseMySql(Config.ConnectionConfig, Config.Version);
    }
}

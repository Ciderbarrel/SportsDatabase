using Microsoft.EntityFrameworkCore;
using SportsDatabase.API.Models.Domain;

namespace SportsDatabase.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<GameLog> GameLogs { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamHistory> TeamHistories { get; set; }

    }
}

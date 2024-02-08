using SportsDatabase.API.Data;
using SportsDatabase.API.Models.Domain;
using SportsDatabase.API.Repositories.Interface;

namespace SportsDatabase.API.Repositories.Implementation
{
    public class TeamRepository : ITeamRepository
    {
        private readonly ApplicationDbContext dbContext;

        public TeamRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Team> CreateAsync(Team team)
        {
            await dbContext.Teams.AddAsync(team);
            await dbContext.SaveChangesAsync();

            return team;
        }
    }
}

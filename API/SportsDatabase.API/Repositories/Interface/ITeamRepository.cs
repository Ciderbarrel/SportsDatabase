using SportsDatabase.API.Models.Domain;

namespace SportsDatabase.API.Repositories.Interface
{
    public interface ITeamRepository
    {
        Task<Team> CreateAsync(Team team);
    }
}

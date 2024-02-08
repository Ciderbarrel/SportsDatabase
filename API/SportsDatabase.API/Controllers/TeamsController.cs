using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsDatabase.API.Data;
using SportsDatabase.API.Models.Domain;
using SportsDatabase.API.Models.DTO;
using SportsDatabase.API.Repositories.Interface;

namespace SportsDatabase.API.Controllers
{
    // https://localhost:xxxx/api/teams
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamRepository teamRepository;

        public TeamsController(ITeamRepository teamRepository)
        {
            this.teamRepository = teamRepository;
        }

        [HttpPost]
        public async Task<ActionResult> CreateTeam(CreateTeamRequestDto request)
        {
            // Map DTO to Domain Model
            var team = new Team
            {
                CurrentTeamHistoryId = request.CurrentTeamHistoryId,
            };

            await teamRepository.CreateAsync(team);

            // Domain model to DTO
            var response = new TeamDto
            {
                Id = team.Id,
                CurrentTeamHistoryId = team.CurrentTeamHistoryId,
                TeamHistories = null,
                GameLogs = null,
            };

            return Ok(response);
        }
    }
}

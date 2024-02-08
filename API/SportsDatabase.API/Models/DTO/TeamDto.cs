using SportsDatabase.API.Models.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsDatabase.API.Models.DTO
{
    public class TeamDto
    {
        public int Id { get; set; }
        public int? CurrentTeamHistoryId { get; set; }
        [NotMapped] public ICollection<TeamHistory>? TeamHistories { get; set; }
        [NotMapped] public ICollection<GameLog>? GameLogs { get; set; }
    }
}

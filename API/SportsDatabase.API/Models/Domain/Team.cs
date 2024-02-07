using System.ComponentModel.DataAnnotations.Schema;

namespace SportsDatabase.API.Models.Domain
{
    public class Team
    {
        public Guid Id { get; set; }
        public int CurrentTeamHistoryId { get; set; }
        [NotMapped] public ICollection<TeamHistory> TeamHistories { get; set; }
        [NotMapped] public ICollection<GameLog> GameLogs { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace SportsDatabase.API.Models.Domain
{
    public class TeamHistory
    {
        public int TeamHistoryId { get; set; }
        public int ParentTeamId { get; set; }
        [NotMapped] public Team Team { get; set; }
        public string TeamCity { get; set; }
        public string? TeamNickname { get; set; }
        public string? Division { get; set; }
        public string? Conference { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}

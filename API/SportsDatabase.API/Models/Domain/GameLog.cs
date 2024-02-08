using System.ComponentModel.DataAnnotations.Schema;

namespace SportsDatabase.API.Models.Domain
{
    public class GameLog
    {
        public int GameLogId { get; set; }
        public DateTime DatePlayed { get; set; }
        public int Season { get; set; }
        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }
        public int HomeTeamScore { get; set; }
        public int AwayTeamScore { get; set; }
        public GameResult Result { get; set; }

        [NotMapped] public Team HomeTeam { get; set; }
        [NotMapped] public Team AwayTeam { get; set; }
        public bool IsOvertime { get; set; }
        // To account for penality kicks after extra time
        public bool IsOvertimeTiebreaker { get; set; }
        public bool IsNeutralSite { get; set; }
        // For in season tournaments like the NBA or FA Cup
        public bool IsTournamentGame { get; set; }
        public bool IsPostSeasonGame { get; set; }
        public bool IsChampionshipGame { get; set; }

        // Division could be the NFC East, or FBS
        public bool? IsDivisionalGame { get; set; }
        // Conference could be NFC, Big Ten Conference, 
        public bool? IsConferenceGame { get; set; }
        // League could be Premier League, League One, NFL
        public bool? IsLeagueGame { get; set; }
        // Association could be UEFA, CONCACAF, NCAA, NAIA
        public bool? IsAssociationGame { get; set; }
        public string? GameNotes { get; set; }

        public int? HomeTeamHistoryId { get; set; }
        public int? AwayTeamHistoryId { get; set; }
    }
}

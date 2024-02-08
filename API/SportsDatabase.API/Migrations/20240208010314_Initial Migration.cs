using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsDatabase.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GameLogs",
                columns: table => new
                {
                    GameLogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatePlayed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Season = table.Column<int>(type: "int", nullable: false),
                    HomeTeamId = table.Column<int>(type: "int", nullable: false),
                    AwayTeamId = table.Column<int>(type: "int", nullable: false),
                    HomeTeamScore = table.Column<int>(type: "int", nullable: false),
                    AwayTeamScore = table.Column<int>(type: "int", nullable: false),
                    Result = table.Column<int>(type: "int", nullable: false),
                    IsOvertime = table.Column<bool>(type: "bit", nullable: false),
                    IsOvertimeTiebreaker = table.Column<bool>(type: "bit", nullable: false),
                    IsNeutralSite = table.Column<bool>(type: "bit", nullable: false),
                    IsTournamentGame = table.Column<bool>(type: "bit", nullable: false),
                    IsPostSeasonGame = table.Column<bool>(type: "bit", nullable: false),
                    IsChampionshipGame = table.Column<bool>(type: "bit", nullable: false),
                    IsDivisionalGame = table.Column<bool>(type: "bit", nullable: true),
                    IsConferenceGame = table.Column<bool>(type: "bit", nullable: true),
                    IsLeagueGame = table.Column<bool>(type: "bit", nullable: true),
                    IsAssociationGame = table.Column<bool>(type: "bit", nullable: true),
                    GameNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeTeamHistoryId = table.Column<int>(type: "int", nullable: true),
                    AwayTeamHistoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameLogs", x => x.GameLogId);
                });

            migrationBuilder.CreateTable(
                name: "TeamHistories",
                columns: table => new
                {
                    TeamHistoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentTeamId = table.Column<int>(type: "int", nullable: false),
                    TeamCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamNickname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Division = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Conference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamHistories", x => x.TeamHistoryId);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentTeamHistoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameLogs");

            migrationBuilder.DropTable(
                name: "TeamHistories");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}

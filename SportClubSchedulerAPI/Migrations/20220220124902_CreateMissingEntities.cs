using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportClubSchedulerAPI.Migrations
{
    public partial class CreateMissingEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "Players",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TrainingScheduleId",
                table: "Players",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Clubs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(64)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(128)", nullable: false),
                    ClubId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GamingSchedule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HomeTeamId = table.Column<int>(type: "int", nullable: false),
                    GuestTeamId = table.Column<int>(type: "int", nullable: false),
                    SportHallId = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Result = table.Column<string>(type: "nvarchar(64)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamingSchedule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GamingSchedule_SportHalls_SportHallId",
                        column: x => x.SportHallId,
                        principalTable: "SportHalls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GamingSchedule_Teams_GuestTeamId",
                        column: x => x.GuestTeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_GamingSchedule_Teams_HomeTeamId",
                        column: x => x.HomeTeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "TrainingSchedule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    SportHallId = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingSchedule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingSchedule_SportHalls_SportHallId",
                        column: x => x.SportHallId,
                        principalTable: "SportHalls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingSchedule_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_TrainingScheduleId",
                table: "Players",
                column: "TrainingScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_GamingSchedule_GuestTeamId",
                table: "GamingSchedule",
                column: "GuestTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_GamingSchedule_HomeTeamId",
                table: "GamingSchedule",
                column: "HomeTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_GamingSchedule_SportHallId",
                table: "GamingSchedule",
                column: "SportHallId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ClubId",
                table: "Teams",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingSchedule_SportHallId",
                table: "TrainingSchedule",
                column: "SportHallId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingSchedule_TeamId",
                table: "TrainingSchedule",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Teams_TeamId",
                table: "Players",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_TrainingSchedule_TrainingScheduleId",
                table: "Players",
                column: "TrainingScheduleId",
                principalTable: "TrainingSchedule",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Teams_TeamId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_TrainingSchedule_TrainingScheduleId",
                table: "Players");

            migrationBuilder.DropTable(
                name: "GamingSchedule");

            migrationBuilder.DropTable(
                name: "TrainingSchedule");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Clubs");

            migrationBuilder.DropIndex(
                name: "IX_Players_TeamId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_TrainingScheduleId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "TrainingScheduleId",
                table: "Players");
        }
    }
}

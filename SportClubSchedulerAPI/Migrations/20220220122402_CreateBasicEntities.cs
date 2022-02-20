using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportClubSchedulerAPI.Migrations
{
    public partial class CreateBasicEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Organisation = table.Column<string>(type: "nvarchar(128)", nullable: true),
                    StreetAddressLine = table.Column<string>(type: "nvarchar(128)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(64)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(16)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Leagues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(32)", nullable: false),
                    Rang = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leagues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SportHalls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(128)", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportHalls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SportHalls_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(128)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    SportHallId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipments_SportHalls_SportHallId",
                        column: x => x.SportHallId,
                        principalTable: "SportHalls",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_SportHallId",
                table: "Equipments",
                column: "SportHallId");

            migrationBuilder.CreateIndex(
                name: "IX_SportHalls_AddressId",
                table: "SportHalls",
                column: "AddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipments");

            migrationBuilder.DropTable(
                name: "Leagues");

            migrationBuilder.DropTable(
                name: "SportHalls");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}

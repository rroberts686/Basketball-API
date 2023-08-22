using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APIofMyChoice.Migrations
{
    /// <inheritdoc />
    public partial class intital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TeamOvr = table.Column<int>(type: "int", nullable: false),
                    TeamModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_Teams_TeamModelId",
                        column: x => x.TeamModelId,
                        principalTable: "Teams",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Position = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Archetype = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    JerseyNumber = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "TeamModelId", "TeamName", "TeamOvr" },
                values: new object[,]
                {
                    { 1, null, "Warriors", 89 },
                    { 2, null, "Bucks", 94 },
                    { 3, null, "Nuggets", 97 },
                    { 4, null, "Grizzlies", 91 },
                    { 5, null, "Trailblazers", 83 },
                    { 6, null, "Spurs", 80 },
                    { 7, null, "Heat", 92 },
                    { 8, null, "Hornets", 81 }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Archetype", "JerseyNumber", "Name", "Position", "TeamId" },
                values: new object[,]
                {
                    { 1, "Shooting Playmaker", 30, "Stephen Curry", "PG", 1 },
                    { 2, "2-Way Slasher", 34, "Giannis Antetokounmpo", "PF", 2 },
                    { 3, "2-Way 3pt Specialist", 11, "Klay Thompson", "SG", 1 },
                    { 4, "Playmaking Big", 15, "Nikola Jokic", "C", 3 },
                    { 5, "2-Way Stretch Big", 13, "Jaren Jackson Jr.", "PF", 4 },
                    { 6, "Slashing Playmaker", 0, "Scoot Henderson", "PG", 5 },
                    { 7, "Unicorn", 1, "Victor Wembanyama", "C", 6 },
                    { 8, "Pure 3pt Specialist", 55, "Duncan Robinson", "SG", 7 },
                    { 9, "Playmaking Shot Creator", 1, "Lamelo Ball", "PG", 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_TeamModelId",
                table: "Teams",
                column: "TeamModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}

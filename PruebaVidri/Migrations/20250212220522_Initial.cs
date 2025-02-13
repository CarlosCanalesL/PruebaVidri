using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PruebaVidri.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hero",
                columns: table => new
                {
                    HeroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Alias = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hero", x => x.HeroId);
                });

            migrationBuilder.CreateTable(
                name: "Power",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeroId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Power", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Hero",
                columns: new[] { "HeroId", "Alias", "name" },
                values: new object[,]
                {
                    { 1, "The Dark Knight", "Batman" },
                    { 2, "Friendly Neighbor", "Spider-man" },
                    { 3, "The Fastest Man", "Flash" },
                    { 4, "", "Green Lantern" },
                    { 5, "God of Thunder", "Thor" },
                    { 6, "The First Avenger", "Captain America" }
                });

            migrationBuilder.InsertData(
                table: "Power",
                columns: new[] { "Id", "Description", "HeroId", "Name" },
                values: new object[,]
                {
                    { 1, "Exceptional deduction", 1, "Detective Skills" },
                    { 2, "Hand-to-hand combat", 1, "Martials Arts" },
                    { 3, "Alerts to danger", 2, "Spider Sense" },
                    { 4, "Spins spider webs", 2, "Web-Shooting" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hero");

            migrationBuilder.DropTable(
                name: "Power");
        }
    }
}

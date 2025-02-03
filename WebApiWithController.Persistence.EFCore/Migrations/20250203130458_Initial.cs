using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApiWithController.Persistence.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Heroes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuperHeroName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Team = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "Id", "Name", "SuperHeroName", "Team" },
                values: new object[,]
                {
                    { 1, "Steve Rogers", "Captain America", "Avengers" },
                    { 2, "Tony Stark", "", "Avengers" },
                    { 3, "Bruce Banner", "Hulk", "Avengers" },
                    { 4, "Thor Odinson", "Thor", "Avengers" },
                    { 5, "Natasha Romanoff", "Black Widow", "Avengers" },
                    { 6, "Clint Barton", "Hawkeye", "Avengers" },
                    { 7, "Wanda Maximoff", "Scarlet Witch", "Avengers" },
                    { 8, "Vision", "", "Avengers" },
                    { 9, "James Rhodes", "War Machine", "Avengers" },
                    { 10, "Sam Wilson", "Falcon", "Avengers" },
                    { 11, "Clark Kent", "Superman", "Justice League" },
                    { 12, "Bruce Wayne", "Batman", "Justice League" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Heroes");
        }
    }
}

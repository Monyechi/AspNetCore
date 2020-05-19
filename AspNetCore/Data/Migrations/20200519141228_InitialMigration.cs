using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCore.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "superHeroes",
                columns: table => new
                {
                    name = table.Column<string>(nullable: false),
                    alterEgo = table.Column<string>(nullable: true),
                    secondarySuperheroAbility = table.Column<string>(nullable: true),
                    catchphrase = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_superHeroes", x => x.name);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "superHeroes");
        }
    }
}

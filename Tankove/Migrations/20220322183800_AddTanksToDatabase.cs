using Microsoft.EntityFrameworkCore.Migrations;

namespace Tankove.Migrations
{
    public partial class AddTanksToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tanks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Nationality = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    EnginePower = table.Column<int>(nullable: false),
                    Cannon = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tanks", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tanks");
        }
    }
}

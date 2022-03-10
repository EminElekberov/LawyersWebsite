using Microsoft.EntityFrameworkCore.Migrations;

namespace LawyerbackEnd.Migrations
{
    public partial class addAbout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IndexChooses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Textone = table.Column<string>(nullable: false),
                    TextTwo = table.Column<string>(nullable: false),
                    numberOne = table.Column<string>(nullable: false),
                    numberTwo = table.Column<string>(nullable: false),
                    numberThree = table.Column<string>(nullable: false),
                    numberFour = table.Column<string>(nullable: false),
                    numbroneDesc = table.Column<string>(nullable: false),
                    numbrTWoDesc = table.Column<string>(nullable: false),
                    numbrThreeDesc = table.Column<string>(nullable: false),
                    numbFourDesc = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndexChooses", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IndexChooses");
        }
    }
}

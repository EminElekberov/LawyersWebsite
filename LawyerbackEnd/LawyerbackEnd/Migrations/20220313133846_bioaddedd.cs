using Microsoft.EntityFrameworkCore.Migrations;

namespace LawyerbackEnd.Migrations
{
    public partial class bioaddedd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Biographies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BioHeader = table.Column<string>(nullable: true),
                    BioDescription = table.Column<string>(nullable: false),
                    EducationHeader = table.Column<string>(nullable: true),
                    EducationDescription = table.Column<string>(nullable: false),
                    Aphorizm = table.Column<string>(nullable: true),
                    AwarsHeader = table.Column<string>(nullable: true),
                    AwardDescription = table.Column<string>(nullable: false),
                    AwardIconsDesc = table.Column<string>(nullable: true),
                    Job = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Comminucate = table.Column<string>(nullable: true),
                    IconsComminucate = table.Column<string>(nullable: true),
                    PractiseHeader = table.Column<string>(nullable: true),
                    PrcatiseDesc = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biographies", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Biographies");
        }
    }
}

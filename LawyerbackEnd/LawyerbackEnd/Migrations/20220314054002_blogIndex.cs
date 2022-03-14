using Microsoft.EntityFrameworkCore.Migrations;

namespace LawyerbackEnd.Migrations
{
    public partial class blogIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogIndexAbouts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutHeadder = table.Column<string>(nullable: true),
                    ABoutDescription = table.Column<string>(nullable: true),
                    RecetHeader = table.Column<string>(nullable: true),
                    RecentDesc = table.Column<string>(nullable: true),
                    CategoryHEader = table.Column<string>(nullable: true),
                    catgoryDesc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogIndexAbouts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogIndexAbouts");
        }
    }
}

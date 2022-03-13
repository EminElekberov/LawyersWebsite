using Microsoft.EntityFrameworkCore.Migrations;

namespace LawyerbackEnd.Migrations
{
    public partial class blogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Dates = table.Column<string>(nullable: true),
                    Buttontext1 = table.Column<string>(nullable: true),
                    ButtonLink1 = table.Column<string>(nullable: true),
                    Buttontext2 = table.Column<string>(nullable: true),
                    ButtonLink2 = table.Column<string>(nullable: true),
                    Header = table.Column<string>(nullable: true),
                    headerDesc = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    titleDesc = table.Column<string>(nullable: true),
                    Aphorizm = table.Column<string>(nullable: true),
                    AphirzmWriter = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    AboutDesc = table.Column<string>(nullable: true),
                    RecentTitle = table.Column<string>(nullable: true),
                    RecentDesc = table.Column<string>(nullable: true),
                    CateagoriesTitle = table.Column<string>(nullable: true),
                    CategoriesDesc = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogDetails", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogDetails");
        }
    }
}

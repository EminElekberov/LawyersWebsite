using Microsoft.EntityFrameworkCore.Migrations;

namespace LawyerbackEnd.Migrations
{
    public partial class @case : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorys",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    className = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cases",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Challenge = table.Column<string>(nullable: true),
                    Solution = table.Column<string>(nullable: true),
                    Result = table.Column<string>(nullable: true),
                    Time = table.Column<int>(nullable: false),
                    LawherFullname = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    CategorysId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cases_Categorys_CategorysId",
                        column: x => x.CategorysId,
                        principalTable: "Categorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cases_CategorysId",
                table: "Cases",
                column: "CategorysId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cases");

            migrationBuilder.DropTable(
                name: "Categorys");
        }
    }
}

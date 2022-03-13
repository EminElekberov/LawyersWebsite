using Microsoft.EntityFrameworkCore.Migrations;

namespace LawyerbackEnd.Migrations
{
    public partial class wrong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IconsComminucate2",
                table: "Biographies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IconsComminucate3",
                table: "Biographies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IconsComminucate2",
                table: "Biographies");

            migrationBuilder.DropColumn(
                name: "IconsComminucate3",
                table: "Biographies");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace LawyerbackEnd.Migrations
{
    public partial class OurAbiutAdds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description2",
                table: "OurAbouts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description3",
                table: "OurAbouts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description2",
                table: "OurAbouts");

            migrationBuilder.DropColumn(
                name: "Description3",
                table: "OurAbouts");
        }
    }
}

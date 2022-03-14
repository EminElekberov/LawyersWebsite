using Microsoft.EntityFrameworkCore.Migrations;

namespace LawyerbackEnd.Migrations
{
    public partial class addedContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MyOpinion",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ReadyForm",
                table: "Contacts",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyOpinion",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "ReadyForm",
                table: "Contacts");
        }
    }
}

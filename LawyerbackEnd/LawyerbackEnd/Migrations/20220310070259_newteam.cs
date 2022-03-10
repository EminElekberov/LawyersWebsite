using Microsoft.EntityFrameworkCore.Migrations;

namespace LawyerbackEnd.Migrations
{
    public partial class newteam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SocialNetworkLink",
                table: "Teams",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "SocialNetworkLink2",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SocialNetworkLink3",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SocialNetworkLink4",
                table: "Teams",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SocialNetworkLink2",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "SocialNetworkLink3",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "SocialNetworkLink4",
                table: "Teams");

            migrationBuilder.AlterColumn<string>(
                name: "SocialNetworkLink",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace LawyerbackEnd.Migrations
{
    public partial class dleetecontact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "AddressHeader",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "ContactHeader",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "ContactHeaderDescription",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Hours",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "OfficeHeader",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "PhoneHeader",
                table: "Contacts");

            migrationBuilder.CreateTable(
                name: "AllContactsAreas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressHeader = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PhoneHeader = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    OfficeHeader = table.Column<string>(nullable: true),
                    Hours = table.Column<string>(nullable: true),
                    ContactHeader = table.Column<string>(nullable: true),
                    ContactHeaderDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllContactsAreas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllContactsAreas");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressHeader",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactHeader",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactHeaderDescription",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hours",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OfficeHeader",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneHeader",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

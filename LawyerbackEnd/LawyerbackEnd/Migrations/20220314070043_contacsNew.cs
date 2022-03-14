using Microsoft.EntityFrameworkCore.Migrations;

namespace LawyerbackEnd.Migrations
{
    public partial class contacsNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressHeader",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactHeader",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactHeaderDescription",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hours",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OfficeHeader",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneHeader",
                table: "Contacts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}

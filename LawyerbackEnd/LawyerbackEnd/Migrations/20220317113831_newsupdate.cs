using Microsoft.EntityFrameworkCore.Migrations;

namespace LawyerbackEnd.Migrations
{
    public partial class newsupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cases_Categorys_CategorysId",
                table: "Cases");

            migrationBuilder.RenameColumn(
                name: "CategorysId",
                table: "Cases",
                newName: "categorysId");

            migrationBuilder.RenameIndex(
                name: "IX_Cases_CategorysId",
                table: "Cases",
                newName: "IX_Cases_categorysId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_Categorys_categorysId",
                table: "Cases",
                column: "categorysId",
                principalTable: "Categorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cases_Categorys_categorysId",
                table: "Cases");

            migrationBuilder.RenameColumn(
                name: "categorysId",
                table: "Cases",
                newName: "CategorysId");

            migrationBuilder.RenameIndex(
                name: "IX_Cases_categorysId",
                table: "Cases",
                newName: "IX_Cases_CategorysId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_Categorys_CategorysId",
                table: "Cases",
                column: "CategorysId",
                principalTable: "Categorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

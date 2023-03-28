using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiafManagementStudio.Data.Migrations
{
    public partial class migra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EtudeTables_AspNetUsers_IdPersoNavigationId",
                table: "EtudeTables");

            migrationBuilder.DropColumn(
                name: "IdClient",
                table: "EtudeTables");

            migrationBuilder.DropColumn(
                name: "IdPerso",
                table: "EtudeTables");

            migrationBuilder.AlterColumn<string>(
                name: "IdPersoNavigationId",
                table: "EtudeTables",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EtudeTables_AspNetUsers_IdPersoNavigationId",
                table: "EtudeTables",
                column: "IdPersoNavigationId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EtudeTables_AspNetUsers_IdPersoNavigationId",
                table: "EtudeTables");

            migrationBuilder.AlterColumn<string>(
                name: "IdPersoNavigationId",
                table: "EtudeTables",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "IdClient",
                table: "EtudeTables",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "IdPerso",
                table: "EtudeTables",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_EtudeTables_AspNetUsers_IdPersoNavigationId",
                table: "EtudeTables",
                column: "IdPersoNavigationId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeFinal.Migrations
{
    public partial class ChangedBioTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contactimage",
                table: "Bios");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Bios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WebAdress",
                table: "Bios",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Bios");

            migrationBuilder.DropColumn(
                name: "WebAdress",
                table: "Bios");

            migrationBuilder.AddColumn<string>(
                name: "Contactimage",
                table: "Bios",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

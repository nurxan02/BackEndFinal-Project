using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeFinal.Migrations
{
    public partial class ChangedAppUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserThoughts",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserThoughts",
                table: "AspNetUsers");
        }
    }
}

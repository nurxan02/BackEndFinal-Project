using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeFinal.Migrations
{
    public partial class UpdatedSpeakersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Speakers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Speakers");
        }
    }
}

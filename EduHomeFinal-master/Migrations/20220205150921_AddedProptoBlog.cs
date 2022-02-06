using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeFinal.Migrations
{
    public partial class AddedProptoBlog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Blogs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Text",
                table: "Blogs");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeFinal.Migrations
{
    public partial class AddedSpeakersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventTime",
                table: "Events");

            migrationBuilder.AddColumn<string>(
                name: "Day",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Month",
                table: "Events",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Speakers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    EventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speakers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Speakers_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Speakers_EventId",
                table: "Speakers",
                column: "EventId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Speakers");

            migrationBuilder.DropColumn(
                name: "Day",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Month",
                table: "Events");

            migrationBuilder.AddColumn<string>(
                name: "EventTime",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

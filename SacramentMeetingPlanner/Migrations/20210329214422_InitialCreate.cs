using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace SacramentMeetingPlanner.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bulletin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BulletinDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Presiding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Conducting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chorister = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Organist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningPrayer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SacramentSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Speaker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClosingSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClosingPrayer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bulletin", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bulletin");
        }
    }
}
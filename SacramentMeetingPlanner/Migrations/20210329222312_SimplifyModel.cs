using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentMeetingPlanner.Migrations
{
    public partial class SimplifyModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Chorister",
                table: "Bulletin");

            migrationBuilder.DropColumn(
                name: "ClosingPrayer",
                table: "Bulletin");

            migrationBuilder.DropColumn(
                name: "OpeningPrayer",
                table: "Bulletin");

            migrationBuilder.RenameColumn(
                name: "Presiding",
                table: "Bulletin",
                newName: "Invocation");

            migrationBuilder.RenameColumn(
                name: "Organist",
                table: "Bulletin",
                newName: "Benediction");

            migrationBuilder.AlterColumn<string>(
                name: "SacramentSong",
                table: "Bulletin",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OpeningSong",
                table: "Bulletin",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Conducting",
                table: "Bulletin",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClosingSong",
                table: "Bulletin",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Invocation",
                table: "Bulletin",
                newName: "Presiding");

            migrationBuilder.RenameColumn(
                name: "Benediction",
                table: "Bulletin",
                newName: "Organist");

            migrationBuilder.AlterColumn<string>(
                name: "SacramentSong",
                table: "Bulletin",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "OpeningSong",
                table: "Bulletin",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Conducting",
                table: "Bulletin",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ClosingSong",
                table: "Bulletin",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Chorister",
                table: "Bulletin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClosingPrayer",
                table: "Bulletin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OpeningPrayer",
                table: "Bulletin",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
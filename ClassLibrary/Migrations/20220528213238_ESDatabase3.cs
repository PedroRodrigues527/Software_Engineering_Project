using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary.Migrations
{
    public partial class ESDatabase3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_User_Username",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Playlist_Title",
                table: "Playlist");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Playlist",
                type: "nchar(16)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nchar(16)",
                oldNullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_User_Username",
                table: "User",
                column: "Username");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Playlist_Title",
                table: "Playlist",
                column: "Title");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_User_Username",
                table: "User");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Playlist_Title",
                table: "Playlist");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Playlist",
                type: "nchar(16)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(16)");

            migrationBuilder.CreateIndex(
                name: "IX_User_Username",
                table: "User",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Playlist_Title",
                table: "Playlist",
                column: "Title",
                unique: true,
                filter: "[Title] IS NOT NULL");
        }
    }
}

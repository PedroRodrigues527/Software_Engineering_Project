using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary.Migrations
{
    public partial class ESDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreditCard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    HolderName = table.Column<string>(type: "nvarchar(max)", nullable: false, collation: "SQL_Latin1_General_CP1_CS_AS"),
                    ExpirationDate = table.Column<string>(type: "nvarchar(7)", nullable: false),
                    Pin = table.Column<short>(type: "smallint", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Playlist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nchar(16)", nullable: false, collation: "SQL_Latin1_General_CP1_CS_AS"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    DateCreation = table.Column<string>(type: "nchar(10)", nullable: false),
                    Type = table.Column<string>(type: "nchar(16)", nullable: false, defaultValue: "PRIVATE")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlist", x => x.Id);
                    table.UniqueConstraint("AK_Playlist_Title", x => x.Title);
                });

            migrationBuilder.CreateTable(
                name: "PlaylistVideo",
                columns: table => new
                {
                    IdPlaylist = table.Column<int>(type: "int", nullable: false),
                    IdVideo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nchar(16)", maxLength: 16, nullable: false, collation: "SQL_Latin1_General_CP1_CS_AS"),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: false, collation: "SQL_Latin1_General_CP1_CS_AS"),
                    Password = table.Column<string>(type: "nchar(16)", maxLength: 16, nullable: false, collation: "SQL_Latin1_General_CP1_CS_AS"),
                    Biography = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Plan = table.Column<string>(type: "nchar(16)", nullable: false, defaultValue: "FREE"),
                    DateExpirationPlan = table.Column<string>(type: "nchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.UniqueConstraint("AK_User_Username", x => x.Username);
                });

            migrationBuilder.CreateTable(
                name: "Video",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChannelName = table.Column<string>(type: "nvarchar(max)", nullable: true, collation: "SQL_Latin1_General_CP1_CS_AS"),
                    VideoId = table.Column<string>(type: "nchar(11)", nullable: false, collation: "SQL_Latin1_General_CP1_CS_AS"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true, collation: "SQL_Latin1_General_CP1_CS_AS"),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(max)", nullable: true, collation: "SQL_Latin1_General_CP1_CS_AS")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Video", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreditCard");

            migrationBuilder.DropTable(
                name: "Playlist");

            migrationBuilder.DropTable(
                name: "PlaylistVideo");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Video");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace musicmvc.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    ArtistId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.ArtistId);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    AlbumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    AlbumArtUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.AlbumId);
                    table.ForeignKey(
                        name: "FK_Albums_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "ArtistId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Albums_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Nome" },
                values: new object[,]
                {
                    { 1, "The Weeknd" },
                    { 2, "Adele" },
                    { 3, "Tierre" },
                    { 4, "Beyonce" },
                    { 5, "Coldplay" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "Hip Hop" },
                    { 2, null, "Pop" },
                    { 3, null, "Rock" },
                    { 4, null, "Eletrônica" },
                    { 5, null, "Blues" },
                    { 6, null, "Clássico" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "AlbumArtUrl", "ArtistId", "GenreId", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "https://open.spotify.com/album/4yP0hdKOZPNshxUOjY0cZj", 1, 1, 44.899999999999999, "After Hours" },
                    { 2, "https://open.spotify.com/album/21jF5jlMtzo94wbxmJ18aa", 2, 2, 44.899999999999999, "30" },
                    { 3, "https://open.spotify.com/album/0RzCItg7w7kHuLjDnZBCfB", 3, 6, 44.899999999999999, "Tierra" },
                    { 4, "https://open.spotify.com/album/7dK54iZuOxXFarGhXwEXfF", 4, 2, 44.899999999999999, "Lemonade" },
                    { 5, "https://open.spotify.com/album/2FeyIYDDAQqcOJKOKhvHdr", 5, 2, 44.899999999999999, "Everyday" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_ArtistId",
                table: "Albums",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_GenreId",
                table: "Albums",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}

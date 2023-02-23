using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ecommerce.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsTrendingProduct = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Detail", "ImageUrl", "IsTrendingProduct", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "The Americano coffe is a classic expresso-based drink", "https://th.bing.com/th/id/OIP.eTEn2xfvC_fL9C2P-ZfKpgHaHa?w=173&h=180&c=7&r=0&o=5&pid=1.7", true, "Americano", 25m },
                    { 2, "The Freeze Coffee ", "https://th.bing.com/th/id/OIP.Ry5aE9jiYBVZGTJrLNCfbQHaL2?w=115&h=180&c=7&r=0&o=5&pid=1.7", true, "Freezer Coffee", 25m },
                    { 3, "The Express Coffee", "https://th.bing.com/th/id/OIP.o-eiK1tjgp3ewYlsI78oBwHaHa?w=196&h=196&c=7&r=0&o=5&pid=1.7", true, "Express Coffe", 25m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}

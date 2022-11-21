using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cardapio.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bebidas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    CategoriaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bebidas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Saladas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    CategoriaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saladas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sanduiches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    CategoriaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sanduiches", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Bebidas",
                columns: new[] { "Id", "CategoriaId", "ImageUrl", "Name", "Price" },
                values: new object[] { 1, 2, "https://www.mundoboaforma.com.br/wp-content/uploads/2017/09/suco-de-maca-1-620x330.jpg", "Suco de maçã", 7.5 });

            migrationBuilder.InsertData(
                table: "Bebidas",
                columns: new[] { "Id", "CategoriaId", "ImageUrl", "Name", "Price" },
                values: new object[] { 2, 2, "https://th.bing.com/th/id/OIP.W6ZV25EGvJ3dx1lelLVAHQHaFD?pid=ImgDet&rs=1", "Suco de laranja com morango", 7.5 });

            migrationBuilder.InsertData(
                table: "Bebidas",
                columns: new[] { "Id", "CategoriaId", "ImageUrl", "Name", "Price" },
                values: new object[] { 3, 2, "https://www.tecnonutrireceitas.com.br/central/Content/handlers/Receita.ashx?id=82727&tipo=r&default=s", "Suco de limão de siciliano com hortelã", 7.5 });

            migrationBuilder.InsertData(
                table: "Bebidas",
                columns: new[] { "Id", "CategoriaId", "ImageUrl", "Name", "Price" },
                values: new object[] { 4, 2, "https://th.bing.com/th/id/OIP.2RlEdsGDOUkUH6bTTVYGywHaEd?pid=ImgDet&rs=1", "Suco de maracujá com creme de leite", 7.5 });

            migrationBuilder.InsertData(
                table: "Bebidas",
                columns: new[] { "Id", "CategoriaId", "ImageUrl", "Name", "Price" },
                values: new object[] { 5, 2, "https://www.dessertnowdinnerlater.com/wp-content/uploads/2019/04/Strawberry-Agua-Fresca-3.jpg", " Pink lemonade", 7.5 });

            migrationBuilder.InsertData(
                table: "Bebidas",
                columns: new[] { "Id", "CategoriaId", "ImageUrl", "Name", "Price" },
                values: new object[] { 6, 2, "https://boaforma.abril.com.br/wp-content/uploads/sites/2/2017/11/suco-verde.jpg", "Suco verde", 7.5 });

            migrationBuilder.InsertData(
                table: "Bebidas",
                columns: new[] { "Id", "CategoriaId", "ImageUrl", "Name", "Price" },
                values: new object[] { 7, 2, "https://www.dicasdetreino.com.br/wp-content/uploads/2019/01/Receitas-de-Suco-Detox-para-Limpar-o-Organismo.jpg", "Suco detox", 7.5 });

            migrationBuilder.InsertData(
                table: "Bebidas",
                columns: new[] { "Id", "CategoriaId", "ImageUrl", "Name", "Price" },
                values: new object[] { 8, 2, "https://th.bing.com/th/id/OIP.d4KfVU9uxtnfnyjWMrzhywHaFf?pid=ImgDet&w=1200&h=889&rs=1", " Suco digestivo", 7.5 });

            migrationBuilder.InsertData(
                table: "Bebidas",
                columns: new[] { "Id", "CategoriaId", "ImageUrl", "Name", "Price" },
                values: new object[] { 9, 2, "https://th.bing.com/th/id/OIP.zUlgeMS7vrs1O3WRBfqQoQHaEe?pid=ImgDet&w=1800&h=1087&rs=1", "Suco frisante de lichia e framboesa", 7.5 });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Sanduiche" });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Bebida" });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Salada" });

            migrationBuilder.InsertData(
                table: "Saladas",
                columns: new[] { "Id", "CategoriaId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 1, 3, " milho, ervilha, pepino, frango, alface, cenoura, tomate, ovo e abacaxi", "https://img.itdg.com.br/images/recipes/000/197/343/299262/299262_original.jpg", "Salada americana", 11.5 });

            migrationBuilder.InsertData(
                table: "Saladas",
                columns: new[] { "Id", "CategoriaId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 2, 3, "alface, pepino, alface, rabanete e pão sírio.", "https://th.bing.com/th/id/OIP.p1rSlUHGreAK-lqo-sFmXwHaJQ?pid=ImgDet&rs=1", "Salada fatoush", 11.5 });

            migrationBuilder.InsertData(
                table: "Saladas",
                columns: new[] { "Id", "CategoriaId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 3, 3, " batata, a ervilha, a maionese e a cenoura.", "https://th.bing.com/th/id/R.6eb407b09be8c0fce23592030dae609d?rik=iQbyd5l%2fS0XIZA&pid=ImgRaw&r=0", "Salada russa", 11.5 });

            migrationBuilder.InsertData(
                table: "Saladas",
                columns: new[] { "Id", "CategoriaId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 4, 3, "leva maçã, nozes e um incrível milho de iogurte.", "https://th.bing.com/th/id/OIP.7MwHLJKBOg9N2MNI0E47CwHaFP?pid=ImgDet&w=3000&h=2122&rs=1", "Salada Waldorf", 11.5 });

            migrationBuilder.InsertData(
                table: "Saladas",
                columns: new[] { "Id", "CategoriaId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 5, 3, "alface, agrião, frango assado ou grelhado, bacon, ovo cozido, abacate, queijo e cebolinha.", "https://th.bing.com/th/id/OIP.2_K6rYsvrBOkQpBvevy4XgHaHa?pid=ImgDet&rs=1", "Salada Cobb", 11.5 });

            migrationBuilder.InsertData(
                table: "Sanduiches",
                columns: new[] { "Id", "CategoriaId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 1, 1, "pão de forma integral - pasta de ricota - alface - tomate -orégano - salsinha.", "https://i.pinimg.com/originals/dc/47/54/dc475498f5c9447b7835a4f14d091461.jpg", "sanduíche natural com pasta de ricota", 9.5 });

            migrationBuilder.InsertData(
                table: "Sanduiches",
                columns: new[] { "Id", "CategoriaId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 2, 1, "pão de forma integral - pasta de cottage - abobrinha - alface - orégano - salsinha.", "https://th.bing.com/th/id/OIP.gPV-cLEJjFP6GxpcocFvdgHaEz?pid=ImgDet&w=870&h=565&rs=1", "sanduíche natural com abobrinha", 9.5 });

            migrationBuilder.InsertData(
                table: "Sanduiches",
                columns: new[] { "Id", "CategoriaId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 3, 1, "pão de forma integral - queijo minas -peito de peru - alface - tomate - orégano - salsinha. ", "https://th.bing.com/th/id/OIP.5E5S3QnsSIeGBr-Xg0RSAQHaE8?pid=ImgDet&w=700&h=467&rs=1", "sanduíche natural com peito de peru ", 9.5 });

            migrationBuilder.InsertData(
                table: "Sanduiches",
                columns: new[] { "Id", "CategoriaId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 4, 1, "pão de forma integral - atum escorrido light - alface - tomate - orégano - salsinha.", "https://d37k6lxrz24y4c.cloudfront.net/v2/pt-br/e9dc924f238fa6cc29465942875fe8f0/9f0e0e13-00d5-4b58-a209-e01527581ea2-900.jpg", "sanduíche natural com atum", 9.5 });

            migrationBuilder.InsertData(
                table: "Sanduiches",
                columns: new[] { "Id", "CategoriaId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 5, 1, "pão de forma integral - cenoura ralada - ovo cozido - alface - orégano a gosto - salsinha.", "https://1.bp.blogspot.com/-KbFCmjqVtZM/WvmVHFZiMqI/AAAAAAAAXhw/PF_rF5C8-8g-tjPOVkqkBIltu3KJQlK1gCLcBGAs/s1600/Aprenda-7-receitas-de-sandu%25C3%25ADches-naturais-f%25C3%25A1ceis-e-saborosos-5.jpg", "sanduíche natural com cenoura e ovo", 9.5 });

            migrationBuilder.InsertData(
                table: "Sanduiches",
                columns: new[] { "Id", "CategoriaId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 6, 1, "pão de forma integral - patê de girassol - alface - tomate.", "https://i.pinimg.com/originals/aa/a6/c5/aaa6c5dc4d50d231ce78f9e591eb6867.jpg", "sanduíche natural com patê de girassol", 9.5 });

            migrationBuilder.InsertData(
                table: "Sanduiches",
                columns: new[] { "Id", "CategoriaId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 7, 1, "pão de forma integral - berinjela - alface - tomate - farinha de linhaça - orégano.", "https://i.pinimg.com/originals/57/17/ac/5717ac47ff81555e1dd51fb225b1d62e.jpg", "sanduíche natural com berinjela ", 9.5 });

            migrationBuilder.InsertData(
                table: "Sanduiches",
                columns: new[] { "Id", "CategoriaId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 8, 1, "pão de forma integral - queijo cottage - espinafre cozido - tomate - orégano - salsinha.", "https://th.bing.com/th/id/OIP.PZ3rsF75tOxYo0a8YAVVLgHaE7?pid=ImgDet&rs=1", "sanduíche natural com espinafre", 9.5 });

            migrationBuilder.InsertData(
                table: "Sanduiches",
                columns: new[] { "Id", "CategoriaId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 9, 1, "pão de forma integral - guacamole - alface - tomate - orégano - salsinha.", "https://i.pinimg.com/originals/85/ec/f1/85ecf102f9f31dca543a1ad9baf236e6.jpg", " sanduíche natural com guacamole", 9.5 });

            migrationBuilder.InsertData(
                table: "Sanduiches",
                columns: new[] { "Id", "CategoriaId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 10, 1, "pão de forma integral - queijo minas - peito de peru - picles - abacaxi picado - alface.", "https://th.bing.com/th/id/OIP.JIzaWWXB4QG7wq9NhhNaYQHaFL?pid=ImgDet&rs=1", "sanduíche natural com abacaxi", 9.5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bebidas");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Saladas");

            migrationBuilder.DropTable(
                name: "Sanduiches");
        }
    }
}

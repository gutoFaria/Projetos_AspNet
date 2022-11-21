using Cardapio.Models;
using Microsoft.EntityFrameworkCore;

namespace Cardapio.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {}

        public DbSet<Categoria> Categorias => Set<Categoria>();
        public DbSet<Sanduiche> Sanduiches => Set<Sanduiche>();
        public DbSet<Bebida> Bebidas => Set<Bebida>();
        public DbSet<Salada> Saladas => Set<Salada>();


         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().HasData(
                new 
                {
                    Id = 1,
                    Name = "Sanduiche"
                },
                new 
                {
                    Id = 2,
                    Name = "Bebida"
                },
                new 
                {
                    Id = 3,
                    Name = "Salada"
                }
            );

            modelBuilder.Entity<Sanduiche>().HasData(
                new Sanduiche
                {
                    Id = 1,
                    Name = "sanduíche natural com pasta de ricota",
                    ImageUrl = "https://i.pinimg.com/originals/dc/47/54/dc475498f5c9447b7835a4f14d091461.jpg",
                    Description = "pão de forma integral - pasta de ricota - alface - tomate -orégano - salsinha.",
                    Price = 9.50,
                    CategoriaId = 1
                    
                },
                new Sanduiche
                {
                    Id = 2,
                    Name = "sanduíche natural com abobrinha",
                    ImageUrl = "https://th.bing.com/th/id/OIP.gPV-cLEJjFP6GxpcocFvdgHaEz?pid=ImgDet&w=870&h=565&rs=1",
                    Description = "pão de forma integral - pasta de cottage - abobrinha - alface - orégano - salsinha.",
                    Price = 9.50,
                    CategoriaId = 1
                    
                },
                new Sanduiche
                {
                    Id = 3,
                    Name = "sanduíche natural com peito de peru ",
                    ImageUrl = "https://th.bing.com/th/id/OIP.5E5S3QnsSIeGBr-Xg0RSAQHaE8?pid=ImgDet&w=700&h=467&rs=1",
                    Description = "pão de forma integral - queijo minas -peito de peru - alface - tomate - orégano - salsinha. ",
                    Price = 9.50,
                    CategoriaId = 1
                    
                },
                new Sanduiche
                {
                    Id = 4,
                    Name = "sanduíche natural com atum",
                    ImageUrl = "https://d37k6lxrz24y4c.cloudfront.net/v2/pt-br/e9dc924f238fa6cc29465942875fe8f0/9f0e0e13-00d5-4b58-a209-e01527581ea2-900.jpg",
                    Description = "pão de forma integral - atum escorrido light - alface - tomate - orégano - salsinha.",
                    Price = 9.50,
                    CategoriaId = 1
                    
                },
                new Sanduiche
                {
                    Id = 5,
                    Name = "sanduíche natural com cenoura e ovo",
                    ImageUrl = "https://1.bp.blogspot.com/-KbFCmjqVtZM/WvmVHFZiMqI/AAAAAAAAXhw/PF_rF5C8-8g-tjPOVkqkBIltu3KJQlK1gCLcBGAs/s1600/Aprenda-7-receitas-de-sandu%25C3%25ADches-naturais-f%25C3%25A1ceis-e-saborosos-5.jpg",
                    Description = "pão de forma integral - cenoura ralada - ovo cozido - alface - orégano a gosto - salsinha.",
                    Price = 9.50,
                    CategoriaId = 1
                    
                },
                new Sanduiche
                {
                    Id = 6,
                    Name = "sanduíche natural com patê de girassol",
                    ImageUrl = "https://i.pinimg.com/originals/aa/a6/c5/aaa6c5dc4d50d231ce78f9e591eb6867.jpg",
                    Description = "pão de forma integral - patê de girassol - alface - tomate.",
                    Price = 9.50,
                    CategoriaId = 1
                    
                },
                new Sanduiche
                {
                    Id = 7,
                    Name = "sanduíche natural com berinjela ",
                    ImageUrl = "https://i.pinimg.com/originals/57/17/ac/5717ac47ff81555e1dd51fb225b1d62e.jpg",
                    Description = "pão de forma integral - berinjela - alface - tomate - farinha de linhaça - orégano.",
                    Price = 9.50,
                    CategoriaId = 1
                    
                },
                new Sanduiche
                {
                    Id = 8,
                    Name = "sanduíche natural com espinafre",
                    ImageUrl = "https://th.bing.com/th/id/OIP.PZ3rsF75tOxYo0a8YAVVLgHaE7?pid=ImgDet&rs=1",
                    Description = "pão de forma integral - queijo cottage - espinafre cozido - tomate - orégano - salsinha.",
                    Price = 9.50,
                    CategoriaId = 1
                    
                },
                new Sanduiche
                {
                    Id = 9,
                    Name = " sanduíche natural com guacamole",
                    ImageUrl = "https://i.pinimg.com/originals/85/ec/f1/85ecf102f9f31dca543a1ad9baf236e6.jpg",
                    Description = "pão de forma integral - guacamole - alface - tomate - orégano - salsinha.",
                    Price = 9.50,
                    CategoriaId = 1
                    
                },
                new Sanduiche
                {
                    Id = 10,
                    Name = "sanduíche natural com abacaxi",
                    ImageUrl = "https://th.bing.com/th/id/OIP.JIzaWWXB4QG7wq9NhhNaYQHaFL?pid=ImgDet&rs=1",
                    Description = "pão de forma integral - queijo minas - peito de peru - picles - abacaxi picado - alface.",
                    Price = 9.50,
                    CategoriaId = 1
                    
                }
            );

            modelBuilder.Entity<Bebida>().HasData(
                new Bebida
                {
                    Id = 1,
                    Name = "Suco de maçã",
                    ImageUrl = "https://www.mundoboaforma.com.br/wp-content/uploads/2017/09/suco-de-maca-1-620x330.jpg",
                    Price = 7.50,
                    CategoriaId = 2
                },
                new Bebida
                {
                    Id = 2,
                    Name = "Suco de laranja com morango",
                    ImageUrl = "https://th.bing.com/th/id/OIP.W6ZV25EGvJ3dx1lelLVAHQHaFD?pid=ImgDet&rs=1",
                    Price = 7.50,
                    CategoriaId = 2
                },
                new Bebida
                {
                    Id = 3,
                    Name = "Suco de limão de siciliano com hortelã",
                    ImageUrl = "https://www.tecnonutrireceitas.com.br/central/Content/handlers/Receita.ashx?id=82727&tipo=r&default=s",
                    Price = 7.50,
                    CategoriaId = 2
                },
                new Bebida
                {
                    Id = 4,
                    Name = "Suco de maracujá com creme de leite",
                    ImageUrl = "https://th.bing.com/th/id/OIP.2RlEdsGDOUkUH6bTTVYGywHaEd?pid=ImgDet&rs=1",
                    Price = 7.50,
                    CategoriaId = 2
                },
                new Bebida
                {
                    Id = 5,
                    Name = " Pink lemonade",
                    ImageUrl = "https://www.dessertnowdinnerlater.com/wp-content/uploads/2019/04/Strawberry-Agua-Fresca-3.jpg",
                    Price = 7.50,
                    CategoriaId = 2
                },
                new Bebida
                {
                    Id = 6,
                    Name = "Suco verde",
                    ImageUrl = "https://boaforma.abril.com.br/wp-content/uploads/sites/2/2017/11/suco-verde.jpg",
                    Price = 7.50,
                    CategoriaId = 2
                },
                new Bebida
                {
                    Id = 7,
                    Name = "Suco detox",
                    ImageUrl = "https://www.dicasdetreino.com.br/wp-content/uploads/2019/01/Receitas-de-Suco-Detox-para-Limpar-o-Organismo.jpg",
                    Price = 7.50,
                    CategoriaId = 2
                },
                new Bebida
                {
                    Id = 8,
                    Name = " Suco digestivo",
                    ImageUrl = "https://th.bing.com/th/id/OIP.d4KfVU9uxtnfnyjWMrzhywHaFf?pid=ImgDet&w=1200&h=889&rs=1",
                    Price = 7.50,
                    CategoriaId = 2
                },
                new Bebida
                {
                    Id = 9,
                    Name = "Suco frisante de lichia e framboesa",
                    ImageUrl = "https://th.bing.com/th/id/OIP.zUlgeMS7vrs1O3WRBfqQoQHaEe?pid=ImgDet&w=1800&h=1087&rs=1",
                    Price = 7.50,
                    CategoriaId = 2
                }
            );

            modelBuilder.Entity<Salada>().HasData(
                new Salada
                {
                    Id= 1,
                    Name = "Salada americana",
                    ImageUrl = "https://img.itdg.com.br/images/recipes/000/197/343/299262/299262_original.jpg",
                    Description = " milho, ervilha, pepino, frango, alface, cenoura, tomate, ovo e abacaxi",
                    Price = 11.50,
                    CategoriaId = 3
                },
                new Salada
                {
                    Id= 2,
                    Name = "Salada fatoush",
                    ImageUrl = "https://th.bing.com/th/id/OIP.p1rSlUHGreAK-lqo-sFmXwHaJQ?pid=ImgDet&rs=1",
                    Description = "alface, pepino, alface, rabanete e pão sírio.",
                    Price = 11.50,
                    CategoriaId = 3
                },
                new Salada
                {
                    Id= 3,
                    Name = "Salada russa",
                    ImageUrl = "https://th.bing.com/th/id/R.6eb407b09be8c0fce23592030dae609d?rik=iQbyd5l%2fS0XIZA&pid=ImgRaw&r=0",
                    Description = " batata, a ervilha, a maionese e a cenoura.",
                    Price = 11.50,
                    CategoriaId = 3
                },
                new Salada
                {
                    Id= 4,
                    Name = "Salada Waldorf",
                    ImageUrl = "https://th.bing.com/th/id/OIP.7MwHLJKBOg9N2MNI0E47CwHaFP?pid=ImgDet&w=3000&h=2122&rs=1",
                    Description = "leva maçã, nozes e um incrível milho de iogurte.",
                    Price = 11.50,
                    CategoriaId = 3
                },
                new Salada
                {
                    Id= 5,
                    Name = "Salada Cobb",
                    ImageUrl = "https://th.bing.com/th/id/OIP.2_K6rYsvrBOkQpBvevy4XgHaHa?pid=ImgDet&rs=1",
                    Description = "alface, agrião, frango assado ou grelhado, bacon, ovo cozido, abacate, queijo e cebolinha.",
                    Price = 11.50,
                    CategoriaId = 3
                }
            );
        }
    }
}
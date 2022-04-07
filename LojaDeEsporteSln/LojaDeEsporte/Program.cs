using LojaDeEsporte.Data;
using LojaDeEsporte.Repositorio;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Aicionar os serviços para a arquitetura MVC
builder.Services.AddControllersWithViews();

//Adicionar o serviço de contexto para acesso ao banco de dados
builder.Services.AddDbContext<LojaDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//adicionar a interface junto a sua implementação ao serviço
builder.Services.AddScoped<ILojaRepositorio, LojaRepositorio>();
var app = builder.Build();


//app.MapGet("/", () => "Hello World!");
//Devemos adicionar as configurações de rota padrão e a utilização de arquivos estáticos

app.UseStaticFiles();

app.MapControllerRoute("catpage",
    "{categoria}/Page{productPage:int}",
    new { Controller = "Home", action = "Index" });

app.MapControllerRoute("page", "Page{productPage:int}",
    new { Controller = "Home", action = "Index", productPage = 1 });

app.MapControllerRoute("category", "{category}",
    new { Controller = "Home", action = "Index", productPage = 1 });

app.MapControllerRoute("pagination",
    "Produtos/Page{productPage}",
    new { Controller = "Home", action = "Index" });
app.MapDefaultControllerRoute();

//iniciar seed 
//SeedData.PopularBanco(app);

app.Run();

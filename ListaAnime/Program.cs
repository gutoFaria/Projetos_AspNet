using ListaAnime.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

//adicionar base de dados com sqlite
//adicionar migratons "dotnet ef migrations add inicio"
//aplicar migraton "dotnet ef database update"
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlite("Data Source = ./Data/MangaDb.db"));
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.UseStaticFiles();
app.MapControllers();
app.MapControllerRoute("controllers",
    "controllers/{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

var context = app.Services.CreateScope().ServiceProvider.GetRequiredService<AppDbContext>();
SeedData.SeedDatabase(context);

app.Run();

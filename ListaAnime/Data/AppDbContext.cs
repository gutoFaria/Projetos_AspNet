using ListaAnime.Models;
using Microsoft.EntityFrameworkCore;


namespace ListaAnime.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {}

        public DbSet<Manga> Mangas => Set<Manga>();
        public DbSet<Autor> Autores => Set<Autor>();
        public DbSet<Genero> Generos => Set<Genero>();
    }
}
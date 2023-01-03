using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class QuizDbContext : DbContext
    {
        public QuizDbContext(DbContextOptions<QuizDbContext> options) : base(options)
        {
            
        }

        public DbSet<Materia> Materias => Set<Materia>();
        public DbSet<Tema> Temas => Set<Tema>();
        public DbSet<Pergunta> Perguntas => Set<Pergunta>();
    }
}
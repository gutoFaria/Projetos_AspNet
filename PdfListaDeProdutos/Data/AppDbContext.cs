using Microsoft.EntityFrameworkCore;
using PdfListaDeProdutos.Models;

namespace PdfListaDeProdutos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        
        public DbSet<Produto> Produtos => Set<Produto>();
    }
}
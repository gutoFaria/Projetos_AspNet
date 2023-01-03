using Microsoft.EntityFrameworkCore;
using Produto.Models;

namespace Produto.Repository
{
    public class ProdutoDbContext : DbContext
    {
        public ProdutoDbContext(DbContextOptions<ProdutoDbContext> options) : base(options)
        {}

        public DbSet<Product> Produtos => Set<Product>();
    }
}
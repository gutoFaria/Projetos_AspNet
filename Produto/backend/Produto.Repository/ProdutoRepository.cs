using Microsoft.EntityFrameworkCore;
using Produto.Models;
using Produto.Services;

namespace Produto.Repository
{
    public class ProdutoRepository : IProduto
    {
        private readonly ProdutoDbContext _context;

        public ProdutoRepository(ProdutoDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetProdutos()
        {
            return await _context.Produtos.ToListAsync();
        }
        

        public async Task DeleteProduto(int? Id)
        {
            var produto = await _context.Produtos.FindAsync(Id);
            if(produto != null)
            {
                _context.Produtos.Remove(produto);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Product> GetProduto(int? Id)
        {
            var produto = await _context.Produtos.FindAsync(Id);
            if(produto != null)
            {
                return produto;
            }

            return null!;
        }

        public async Task SaveProduto(Product produto)
        {
            if(produto.Id == 0)
            {
                await _context.Produtos.AddAsync(produto);
                await _context.SaveChangesAsync();
            }
            else if(produto.Id != 0)
            {
                var p = await _context.Produtos.FindAsync(produto.Id);
                if(p != null)
                {
                    p.Nome = produto.Nome;
                    p.ImageUrl = produto.ImageUrl;
                    p.Price = produto.Price;

                    await _context.SaveChangesAsync();
                }
               
            }
        }
    }
}
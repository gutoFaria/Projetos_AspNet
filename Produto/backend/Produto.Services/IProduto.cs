using Produto.Models;

namespace Produto.Services
{
    public interface IProduto
    {
        Task<Product> GetProduto(int? Id);
        Task<IEnumerable<Product>> GetProdutos();
        Task SaveProduto(Product produto);
        Task DeleteProduto(int? Id);
    }
}
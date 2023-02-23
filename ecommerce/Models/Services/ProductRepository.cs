using ecommerce.Data;
using ecommerce.Models.Interfaces;

namespace ecommerce.Models.Services
{
    public class ProductRepository : IProductRepository
    {
        private readonly EcommerceDbContext _db;

        public ProductRepository(EcommerceDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _db.Products.ToList();
        }

        public Product GetProductDetail(int id)
        {
            return _db.Products.FirstOrDefault(p => p.Id == id)!;
        }

        public IEnumerable<Product> GetTrendingProducts()
        {
            return _db.Products.Where(p => p.IsTrendingProduct);
        }
    }
}
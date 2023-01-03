namespace Produto.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Nome { get; set; } = String.Empty;
        public string ImageUrl { get; set; } = String.Empty;
        public double Price { get; set; }
    }
}
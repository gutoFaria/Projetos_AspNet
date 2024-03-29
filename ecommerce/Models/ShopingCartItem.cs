namespace ecommerce.Models
{
    public class ShopingCartItem
    {
        public int Id { get; set; }
        public Product? Product { get; set; }
        public int Qty { get; set; }
        public string ShoppingCartId { get; set; } = String.Empty;
    }
}
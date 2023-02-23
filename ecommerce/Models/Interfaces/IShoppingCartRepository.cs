namespace ecommerce.Models.Interfaces
{
    public interface IShoppingCartRepository
    {
        void AddToCart(Product product);
        int RemoveFromCart(Product product);

        List<ShopingCartItem> GetShopingCartItems();
        void ClearCart();
        decimal GetShopingCartTotal();
        public List<ShopingCartItem>? shopingCartItems { get; set; }

    }
}
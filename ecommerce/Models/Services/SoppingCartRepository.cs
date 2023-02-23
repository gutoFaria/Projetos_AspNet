using ecommerce.Data;
using ecommerce.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Models.Services
{
    public class SoppingCartRepository : IShoppingCartRepository
    {
        private readonly EcommerceDbContext _db;

        public SoppingCartRepository(EcommerceDbContext db)
        {
            _db = db;
        }
        public List<ShopingCartItem>? shopingCartItems { get ; set ; }
        public string? ShoppingCartId { get; set; }

        public static SoppingCartRepository GetCart(IServiceProvider services)
        {
            ISession? session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext?.Session;
            EcommerceDbContext context = services.GetService<EcommerceDbContext>() ?? throw new Exception("Error initializer ecommercedbcontext");
            string cartId = session?.GetString("CardId") ?? Guid.NewGuid().ToString();
            session?.SetString("CardId",cartId);
            return new SoppingCartRepository(context) { ShoppingCartId = cartId};
        }

        public void AddToCart(Product product)
        {
            var shopingCartItem =_db.ShopingCartItems.FirstOrDefault(s => s.Product!.Id == product.Id && s.ShoppingCartId == ShoppingCartId);
            if(shopingCartItem == null)
            {
                shopingCartItem = new ShopingCartItem
                {
                    ShoppingCartId = ShoppingCartId!,
                    Product = product,
                    Qty = 1
                };
                _db.ShopingCartItems.Add(shopingCartItem);
            }
            else
            {
                shopingCartItem.Qty++;
            }
            _db.SaveChanges();
        }

        public void ClearCart()
        {
            var cartItems =_db.ShopingCartItems.Where(s => s.ShoppingCartId == ShoppingCartId);
            _db.ShopingCartItems.RemoveRange(cartItems);
            _db.SaveChanges();
        }

        public List<ShopingCartItem> GetShopingCartItems()
        {
           return shopingCartItems ??=  _db.ShopingCartItems.Where(s => s.ShoppingCartId == ShoppingCartId).Include(p => p.Product).ToList();
        }

        public decimal GetShopingCartTotal()
        {
            var totalCost =_db.ShopingCartItems.Where(s => s.ShoppingCartId == ShoppingCartId).Select(s => s.Product!.Price * s.Qty).Sum();
            return totalCost;
        }

        public int RemoveFromCart(Product product)
        {
            var shopingCartItem =_db.ShopingCartItems.FirstOrDefault(s => s.Product!.Id == product.Id && s.ShoppingCartId == ShoppingCartId);
            var quantity = 0;
            if(shopingCartItem != null)
            {
                if(shopingCartItem.Qty > 1)
                {
                    shopingCartItem.Qty--;
                    quantity = shopingCartItem.Qty;
                }
                else
                {
                    _db.ShopingCartItems.Remove(shopingCartItem);
                }
            }
            _db.SaveChanges();
            return quantity;
        }
    }
}
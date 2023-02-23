using ecommerce.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
    public class ShoppingCartController : Controller
    {
        private IShoppingCartRepository _controller;
        private IProductRepository _repo;

        public ShoppingCartController(IShoppingCartRepository controller,IProductRepository repo)
        {
            _controller = controller;
            _repo = repo;
        }

        public IActionResult Index()
        {
            var items = _controller.GetShopingCartItems();
            _controller.shopingCartItems = items;
            return View(items);
        }

        public RedirectToActionResult AddShopingCart(int pId)
        {
            var product = _repo.GetAllProducts().FirstOrDefault(p => p.Id == pId);
            if(product !=null)
            {
                _controller.AddToCart(product);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShopingCart(int pId)
        {
            var product = _repo.GetAllProducts().FirstOrDefault(p => p.Id == pId);
            if(product !=null)
            {
                _controller.RemoveFromCart(product);
            }
            return RedirectToAction("Index");
        }
    }
}
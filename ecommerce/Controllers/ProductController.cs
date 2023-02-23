using ecommerce.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Shop()
        {
            return View(_productRepository.GetAllProducts());
        }

        public IActionResult Detail(int id)
        {
            var product = _productRepository.GetProductDetail(id);
            if(product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}
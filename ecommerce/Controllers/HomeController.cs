using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ecommerce.Models;
using ecommerce.Models.Interfaces;

namespace ecommerce.Controllers;

public class HomeController : Controller
{

    private IProductRepository _productRepository;

    public HomeController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public IActionResult Index()
    {
        return View(_productRepository.GetTrendingProducts());
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

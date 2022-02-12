using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Produtos.Models;

namespace Produtos.Controllers;

public class HomeController : Controller
{
   
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public ViewResult Cadastro()
    {
        return View();
    }

    [HttpPost]
    public ViewResult Cadastro(Produto produto )
    {
        if(ModelState.IsValid)
        {
            Service.AddProduto(produto);
            return View("Situacao",produto);
        }
        else
        {
            return View();
        }
    }

    public ViewResult ListaDeProdutos()
    {
        return View(Service.Produtos);
    }
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ConviteParaFesta.Models;

namespace ConviteParaFesta.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public ViewResult RsvpForm()
    {
        return View();
    }

    [HttpPost]
    public ViewResult RsvpForm(RespostaDoConvidado respostaDoConvidado)
    {
        if(ModelState.IsValid)
        {
            Repositorio.AAdicionaResposta(respostaDoConvidado);
            return View("Obrigado", respostaDoConvidado);
        }
        else
        {
            return View();
        }
        
    }

    public ViewResult ListaDeConvidados()
    {
        return View(Repositorio.Resposta.Where( r => r.IraComparecer == true));
    }
}

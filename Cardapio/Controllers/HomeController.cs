using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Cardapio.Models;
using Cardapio.Data;
using Microsoft.EntityFrameworkCore;

namespace Cardapio.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var data = await _context.Sanduiches.ToListAsync();
        return View(data);
    }

    // public async Task<IActionResult> Details(int? id)
    // {
    //     var data = await _context.Sanduiches.Where(x => x.Id == id).FirstOrDefaultAsync();
    //     if(data == null)
    //     {
    //         return NotFound();
    //     }
    //     return PartialView("Details",data);
    // }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

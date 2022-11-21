using Cardapio.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cardapio.Controllers
{
    public class SaladaController : Controller
    {
         private readonly AppDbContext _context;

        public SaladaController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _context.Saladas.ToListAsync();
            return View(data);
        }
    }
}
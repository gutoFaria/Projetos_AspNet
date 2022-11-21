using Cardapio.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cardapio.Controllers
{
    public class BebidaController : Controller
    {
        private readonly AppDbContext _context;

        public BebidaController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _context.Bebidas.ToListAsync();
            return View(data);
        }
    }
}
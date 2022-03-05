
using ListaAnime.Data;
using ListaAnime.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ListaAnime.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext context;

        public HomeController(AppDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index([FromQuery] string selecionaGenero)
        {
            return View
            (
                new MangaListViewModel
                {
                    Mangas = context.Mangas.Include(p => p.Autor).Include(p=>p.Genero),
                    Generos = context.Generos.Select(l => l.NomeGenero).Distinct(),
                    SelectedGenero = selecionaGenero 
                }
            );
        }
    }

    public class MangaListViewModel
    {
        public IEnumerable<Manga> Mangas { get; set; } = Enumerable.Empty<Manga>();
        public IEnumerable<string> Generos { get; set; } = Enumerable.Empty<string>();
        public string SelectedGenero { get; set; } = String.Empty;

        public string GetClass(string? genero) => SelectedGenero == genero ? "bg-info text-black": "";
    }
}
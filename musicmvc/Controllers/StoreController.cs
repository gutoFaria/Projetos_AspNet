using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using musicmvc.Data;
using musicmvc.Models;

namespace musicmvc.Controllers
{
    public class StoreController : Controller
    {
        private readonly MSContext _context;

        public StoreController(MSContext context)
        {
            _context = context;
        }
        //GET:/Store
        public async Task<IActionResult> Index()
        {
            var genres =await _context.Genres.ToListAsync();

            return View(genres);
        }

        //GET: /Store/Browse?genre=Disco
        public IActionResult Browse(string genre)
        {
            //var genreModel = new Genre { Name = genre};
            var genreModel = _context.Genres.Include("Albums").Single(g => g.Name == genre);
            return View(genreModel);
        }

        //GET: /Store/Details/5
        public IActionResult Details(int id)
        {
            //var album = new Album{Title = "Album" + id};
            var album = _context.Albums.Find(id);
            return View(album);
        }
    }
}
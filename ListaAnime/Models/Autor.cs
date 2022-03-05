using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaAnime.Models
{
    public class Autor
    {
        public long AutorId { get; set; }
        public string NomeAutor { get; set; } = String.Empty;
        public IEnumerable<Manga>? Mangas { get; set; }
    }
}
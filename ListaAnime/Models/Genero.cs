using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaAnime.Models
{
    public class Genero
    {
        public long GeneroId { get; set; }
        public string NomeGenero { get; set; } = String.Empty;
        public IEnumerable<Manga>? Mangas { get; set; }
    }
}
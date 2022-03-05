using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaAnime.Models
{
    public class Manga
    {
        public long MangaId { get; set; }
        public string NomeManga { get; set; } = String.Empty;

        public long AutorId { get; set; }
        public long GeneroId { get; set; }
        public Autor? Autor { get; set; }
        public Genero? Genero { get; set; }
    }
}
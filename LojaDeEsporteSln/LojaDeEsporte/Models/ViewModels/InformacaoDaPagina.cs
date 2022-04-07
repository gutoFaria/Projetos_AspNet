using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaDeEsporte.Models.ViewModels
{
    public class InformacaoDaPagina
    {
        public int TotalItems { get; set; }
        public int ItemsPorPagina { get; set; }
        public int PaginaAtual { get; set; }

        public int PaginaTotal =>
            (int)Math.Ceiling((decimal)TotalItems/ItemsPorPagina);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaDeEsporte.Models.ViewModels
{
    public class ListaDeProdutos
    {
        public IEnumerable<Produto> Produtos { get; set; }
            = Enumerable.Empty<Produto>();
        public InformacaoDaPagina InformacaoDaPagina { get; set; } = new();
        //saber em qual categoria o produto se encontra
        public string? CategoriaAtual { get; set; }
    }
}
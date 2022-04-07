using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LojaDeEsporte.Models
{
    public class Produto
    {
        public long? ProdutoId { get; set; }
        public string Nome { get; set; } = String.Empty;
        public string ImagemUrl { get; set; } = String.Empty;
        public string Descricao { get; set; } = String.Empty;
        [Column(TypeName="decimal(8,2)")]
        public decimal Preco { get; set; }
        public string Categoria { get; set; } = String.Empty;
    }
}
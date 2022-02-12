using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Produtos.Models
{
    public class Produto
    {
        [Required(ErrorMessage="Campo nome obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage="Campo quantidade obrigatório!")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage ="Campo de preço obrigatório!")]
        public int Preco { get; set; }
    }
}
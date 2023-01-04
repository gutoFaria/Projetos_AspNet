using System.ComponentModel.DataAnnotations;

namespace PdfListaDeProdutos.Models
{
    public class Produto
    {
        [Key]
        public int Cod { get; set; }
        public string Nome { get; set; } = String.Empty;
        public int Qtd { get; set; }
        public float Preco { get; set; }
    }
}
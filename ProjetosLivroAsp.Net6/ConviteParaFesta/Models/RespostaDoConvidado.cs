using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConviteParaFesta.Models
{
    public class RespostaDoConvidado
    {
        [Required(ErrorMessage ="Campo Obrigatório!")]
        public string Nome { get; set; } = String.Empty;
        [Required(ErrorMessage ="Campo Obrigatório!")]
        [EmailAddress]
        public string Email { get; set; } = String.Empty;
        [Required(ErrorMessage ="Campo Obrigatório!")]
        public string Telefone { get; set; } = String.Empty;
        [Required(ErrorMessage ="Campo Obrigatório!")]
        public bool IraComparecer { get; set; }
    }
}
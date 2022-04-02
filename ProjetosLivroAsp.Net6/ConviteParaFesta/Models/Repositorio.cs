using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConviteParaFesta.Models
{
    public class Repositorio
    {
        private static List<RespostaDoConvidado> respostas = new();

        public static IEnumerable<RespostaDoConvidado> Resposta => respostas;

        public static void AAdicionaResposta(RespostaDoConvidado resposta)
        {
            Console.WriteLine(resposta);
            respostas.Add(resposta);
        }
    }
}
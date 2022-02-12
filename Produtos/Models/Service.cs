using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produtos.Models
{
    public class Service
    {
        private static List<Produto> produtos = new List<Produto>();
        public static IEnumerable<Produto> Produtos => produtos;

        public static void AddProduto(Produto produto)
        {
            produtos.Add(produto);
        }
    }
}
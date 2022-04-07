using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaDeEsporte.Models;

namespace LojaDeEsporte.Repositorio
{
    public interface ILojaRepositorio
    {
        //para obter a sequência de produtos
        IQueryable<Produto> Produtos {get;}
    }
}
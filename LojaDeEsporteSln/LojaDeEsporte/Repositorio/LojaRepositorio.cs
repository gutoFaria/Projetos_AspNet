using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaDeEsporte.Data;
using LojaDeEsporte.Models;

namespace LojaDeEsporte.Repositorio
{
    public class LojaRepositorio : ILojaRepositorio
    {
        // utilizar o contexto
        private LojaDbContext context;

        public LojaRepositorio(LojaDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Produto> Produtos => context.Produtos;
    }
}
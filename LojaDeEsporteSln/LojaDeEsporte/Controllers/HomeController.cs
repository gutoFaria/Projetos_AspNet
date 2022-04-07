
using LojaDeEsporte.Models.ViewModels;
using LojaDeEsporte.Repositorio;
using Microsoft.AspNetCore.Mvc;


namespace LojaDeEsporte.Controllers
{
    public class HomeController : Controller
    {
        //adicionar o repositorio
        private ILojaRepositorio repositorio;
        //quantidade de produtos na página
        public int TamanhoPagina = 4;
        public HomeController(ILojaRepositorio repo)
        {
            repositorio = repo;
        }

        //retorna uma lista de produtos para a View
        public ViewResult Index(string? categoria,int productPage = 1)
            => View(new ListaDeProdutos{
                Produtos = repositorio.Produtos
                    .Where(p => categoria == null || p.Categoria == categoria)
                    .OrderBy(p => p.ProdutoId)
                    .Skip((productPage - 1) * TamanhoPagina)
                    .Take(TamanhoPagina),
                    InformacaoDaPagina = new InformacaoDaPagina {
                        PaginaAtual = productPage,
                        ItemsPorPagina = TamanhoPagina,
                        TotalItems = repositorio.Produtos.Count()
                    },
                    CategoriaAtual = categoria
            });
    }
}
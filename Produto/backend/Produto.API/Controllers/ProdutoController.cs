using Microsoft.AspNetCore.Mvc;
using Produto.Models;
using Produto.Services;

namespace Produto.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProduto _db;

        public ProdutoController(IProduto db)
        {
            _db = db;
        }

        [HttpPost]
        public async Task<IActionResult> SaveAsync([FromBody] Product data)
        {
            if(data ==null)
                return BadRequest();
            
            await _db.SaveProduto(data);

            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduto(int? id)
        {
            Product data = await _db.GetProduto(id);
            if(data == null)
                return BadRequest();
            
            return Ok(data);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProdutos()
        {
            IEnumerable<Product> data = await _db.GetProdutos();
            if(data == null)
                return BadRequest();
            
            return Ok(data);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProduto(int? id)
        {
            await _db.DeleteProduto(id);
            return Ok();
        }
    }
}
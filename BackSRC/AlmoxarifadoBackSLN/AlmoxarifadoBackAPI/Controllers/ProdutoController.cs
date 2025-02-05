using AlmoxarifadoBackAPI.DTO;
using AlmoxarifadoBackAPI.Models;
using AlmoxarifadoBackAPI.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly lProdutoRepositorio _db;
        public ProdutoController(lProdutoRepositorio db)
        {
            _db = db;

        }

        [HttpGet("/lista")]
        public IActionResult listaProduto()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/produto")]
        public IActionResult listaProduto(ProdutoDTO categoria)
        {
            return Ok(_db.GetAll().Where(x => x.IdProd == categoria.IdProd));
        }

        [HttpPost("/criarProduto")]
        public IActionResult criarProduto(ProdutoCadastroDTO produto)
        {

            var novoProduto = new Produto()
            {
                DescProd = produto.DescProd
            };
            _db.Add(novoProduto);
            return Ok("Cadastro com Sucesso");
        }
    }
}

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

        [HttpGet("/listaProduto")]
        public IActionResult listaProduto()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/produto")]
        public IActionResult listaProduto(ProdutoDTO produto)
        {
            return Ok(_db.GetAll().Where(x => x.IdProd == produto.IdProd));
        }

        [HttpPost("/criarProduto")]
        public IActionResult criarProduto(ProdutoCadastroDTO produto)
        {

            var novoProduto = new Produto()
            {
                DescricaoProd = produto.DescricaoProd,
                UnidadeDeMedida = produto.UnidadeDeMedida,
                EstoqueAtual = produto.EstoqueAtual,
                EPermanente = produto.EPermanente,
                IdCategoria = produto.IdCategoria

            };
            _db.Add(novoProduto);
            return Ok("Cadastro com Sucesso");
        }
    }
}

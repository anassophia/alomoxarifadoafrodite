using AlmoxarifadoBackAPI.DTO;
using AlmoxarifadoBackAPI.Models;
using AlmoxarifadoBackAPI.Repositorio;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepositorio _db;
        public ProdutoController(IProdutoRepositorio db)
        {
            _db = db;

        }


        [HttpGet("/listaprodutos")]
        public IActionResult listaProdutos()
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
                Codigo = produto.Codigo

            };
            _db.Add(novoProduto);
            return Ok("Cadastro com Sucesso");
        }


    }
}

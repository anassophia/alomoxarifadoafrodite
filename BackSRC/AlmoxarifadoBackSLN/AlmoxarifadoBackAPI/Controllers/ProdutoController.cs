using AlmoxarifadoBackAPI.DTO;
using AlmoxarifadoBackAPI.Models;
using AlmoxarifadoBackAPI.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Controllers
{
<<<<<<< HEAD
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
=======
    [Route("[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepositorio _db;
        public ProdutoController(IProdutoRepositorio db)
        {
            _db =db;
      
        }

        [HttpGet("/listaprodutos")]
        public IActionResult listaProdutos()
>>>>>>> upstream/feature/entrada
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/produto")]
<<<<<<< HEAD
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
=======
        public IActionResult listaProdutos(ProdutoDTO categoria)
        {
            return Ok(_db.GetAll().Where(x=>x.Codigo==categoria.Codigo));
        }

        [HttpPost("/criarproduto")]
        public IActionResult criarProduto(ProdutoCadastroDTO produto)
        {

            var novaProduto = new Produto()
            {               
                Descricao = produto.Descricao,
                UnidadeMedida = produto.UnidadeMedida,
                EstoqueAtual = produto.EstoqueAtual,
                Epermanente = produto.Epermanente,
                CodigoCategoria = produto.CodigoCategoria,

            };
            //_categorias.Add(novaProduto);
            _db.Add(novaProduto);
            return Ok("Cadastro com Sucesso");
        }



>>>>>>> upstream/feature/entrada
    }
}

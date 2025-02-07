using AlmoxarifadoBackAPI.DTO;
using AlmoxarifadoBackAPI.Models;
using AlmoxarifadoBackAPI.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {
        private readonly IFornecedorRepositorio _db;
        public FornecedorController (FornecedorRepositorio db)
        {
            _db = db;

        }

        [HttpGet("/listaFornecedor")]
        public IActionResult listaFornecedor()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/fornecedor")]
        public IActionResult listaFornecedor(FornecedorDTO fornecedor)
        {
            return Ok(_db.GetAll().Where(x => x.IdForn == fornecedor.IdForn));
        }

        [HttpPost("/criarFornecedor")]
        public IActionResult criarFornecedor(FornecedorCadastroDTO fornecedor)
        {

            var novoFornecedor = new Fornecedor()
            {
                Nome = fornecedor.Nome,
                Endereço = fornecedor.Endereço,
                Bairro = fornecedor.Bairro,
                Cidade = fornecedor.Cidade,
                Estado = fornecedor.Estado,
                Telefone = fornecedor.Telefone,
                CNPJ = fornecedor.CNPJ
            };
            _db.Add(novoFornecedor);
            return Ok("Cadastro com Sucesso");
        }
    
    }
}

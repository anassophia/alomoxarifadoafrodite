using AlmoxarifadoBackAPI.DTO;
using AlmoxarifadoBackAPI.Models;
using AlmoxarifadoBackAPI.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItenSaidaController : ControllerBase
    {
        private readonly IItenSaidaRepositorio _db;
        public ItenSaidaController (IItenSaidaRepositorio db)
        {
            _db = db;

        }

        [HttpGet("/listaItenSaida")]
        public IActionResult listaItenSaida()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/itenSaida")]
        public IActionResult listaItenSaida(ItenSaidaDTO itenSaida)
        {
            return Ok(_db.GetAll().Where(x => x.IdItenSaida == itenSaida.IdItenSaida));
        }

        [HttpPost("/criarItenSaida")]
        public IActionResult criarItenSaida(ItenSaidaCadastroDTO itenSaida)
        {

            var novoItenSaida = new ItenSaida()
            {
                IdSaid = itenSaida.IdSaid,
                IdProd = itenSaida.IdProd,
                quantidade = itenSaida.quantidade,
                preco = itenSaida.preco,
                total = itenSaida.total
            };
            _db.Add(novoItenSaida);
            return Ok("Cadastro com Sucesso");
        }
    }
}

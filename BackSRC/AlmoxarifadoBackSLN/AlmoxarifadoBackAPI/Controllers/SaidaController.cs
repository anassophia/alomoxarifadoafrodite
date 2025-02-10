using AlmoxarifadoBackAPI.DTO;
using AlmoxarifadoBackAPI.Models;
using AlmoxarifadoBackAPI.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaidaController : ControllerBase
    {
        private readonly ISaidaRepositorio _db;
        public SaidaController(ISaidaRepositorio db)
        {
            _db = db;

        }

        [HttpGet("/listasaida")]
        public IActionResult listasaida()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/saida")]
        public IActionResult listasaida(SaidaDTO saida)
        {
            return Ok(_db.GetAll().Where(x => x.IdSaid == saida.IdSaid));
        }

        [HttpPost("/criarsaida")]
        public IActionResult criarsaida(SaidaCadastroDTO saida)
        {

            var novaSaida = new Saida()
            {
                IdSec = saida.IdSec,
                DataSaida = saida.DataSaida,
                obs = saida.obs
            };
            _db.Add(novaSaida);
            return Ok("Cadastro com Sucesso");
        }
    }
}


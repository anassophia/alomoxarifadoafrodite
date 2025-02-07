using AlmoxarifadoBackAPI.DTO;
using AlmoxarifadoBackAPI.Models;
using AlmoxarifadoBackAPI.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecretariaController : ControllerBase
    {
        private readonly ISecretariaRepositorio _db;
        public SecretariaController (SecretariaRepositorio db)
        {
            _db = db;

        }

        [HttpGet("/listaSecretaria")]
        public IActionResult listaSecretaria()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/secretaria")]
        public IActionResult listaSecretaria(SecretariaDTO secretaria)
        {
            return Ok(_db.GetAll().Where(x => x.IdSec == secretaria.IdSec));
        }

        [HttpPost("/criarSecretaria")]
        public IActionResult criarSecretaria(SecretariaCadastroDTO secretaria)
        {

            var novaSecretaria = new Secretaria()
            {
                NomeSec = secretaria.NomeSec,
                EndereçoSec = secretaria.EndereçoSec,
                BairroSec = secretaria.BairroSec,
                CidadeSec = secretaria.CidadeSec,
                EstadoSec = secretaria.EstadoSec,
                TelefoneSec = secretaria.TelefoneSec,
                CNPJSec = secretaria.CNPJSec
               
            };
            _db.Add(novaSecretaria);
            return Ok("Cadastro com Sucesso");
        }
  

    }
}

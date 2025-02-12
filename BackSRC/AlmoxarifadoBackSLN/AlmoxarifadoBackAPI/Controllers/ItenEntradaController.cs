using AlmoxarifadoBackAPI.DTO;
using AlmoxarifadoBackAPI.Models;
using AlmoxarifadoBackAPI.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItenEntradaController : ControllerBase
    {
        private readonly IItenEntradaRepositorio _db;
        public ItenEntradaController(IItenEntradaRepositorio db)
        {
            _db = db;

        }

        [HttpGet("/listaItenEntrada")]
        public IActionResult listaItenEntrada()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/itenentrada")]
        public IActionResult listaItenEntrada(ItenEntradaDTO itenentrada)
        {
            return Ok(_db.GetAll().Where(x => x.IdIEnt == itenentrada.IdIEnt));
        }

        [HttpPost("/criaritenentrada")]
        public IActionResult criaritenentrada(ItenEntradaCadastroDTO itenentrada)
        {

            var novoItenEntrada = new ItenEntrada()
            {
                IdEnt = itenentrada.IdEnt,
                IdProd = itenentrada.IdProd,
                quantidade = itenentrada.quantidade,
                preco = itenentrada.preco,
                total = itenentrada.total
            };
            _db.Add(novoItenEntrada);
            return Ok("Cadastro com Sucesso");
        }

    }
   
}

using AlmoxarifadoBackAPI.Models;

namespace AlmoxarifadoBackAPI.Repositorio
{
    public interface IItenEntradaRepositorio
    {
        void Add(ItenEntrada itenEntrada);

        List<ItenEntrada> GetAll();
    }
}

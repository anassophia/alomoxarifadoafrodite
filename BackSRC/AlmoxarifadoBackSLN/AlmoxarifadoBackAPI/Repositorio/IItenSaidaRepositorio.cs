using AlmoxarifadoBackAPI.Models;

namespace AlmoxarifadoBackAPI.Repositorio
{
    public interface IItenSaidaRepositorio
    {
        void Add(ItenSaida itenSaida);

        List<ItenSaida> GetAll();
    }
}

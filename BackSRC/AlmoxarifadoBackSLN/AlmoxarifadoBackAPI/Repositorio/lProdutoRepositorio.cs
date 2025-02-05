using AlmoxarifadoBackAPI.Models;

namespace AlmoxarifadoBackAPI.Repositorio
{
    public interface lProdutoRepositorio
    {
        void Add(Produto categoria);

        List<Produto> GetAll();
    }
}

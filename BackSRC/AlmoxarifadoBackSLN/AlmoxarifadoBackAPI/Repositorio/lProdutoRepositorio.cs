using AlmoxarifadoBackAPI.Models;
using Microsoft.AspNetCore;


namespace AlmoxarifadoBackAPI.Repositorio
{
    public interface lProdutoRepositorio
    {
        void Add(Produto obj);

        List<Produto> GetAll();
    }
}

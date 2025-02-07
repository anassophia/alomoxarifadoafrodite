using AlmoxarifadoBackAPI.Models;
using Microsoft.AspNetCore;


namespace AlmoxarifadoBackAPI.Repositorio
{
    public interface lProdutoRepositorio
    {
        void Add(Produto produto);

        List<Produto> GetAll();
    }
}

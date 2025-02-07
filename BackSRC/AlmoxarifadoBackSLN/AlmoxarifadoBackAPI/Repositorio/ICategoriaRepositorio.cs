using AlmoxarifadoBackAPI.Models;
using Microsoft.AspNetCore;


namespace AlmoxarifadoBackAPI.Repositorio
{
    public interface ICategoriaRepositorio
    {
        void Add(Categoria categoria);

        List<Categoria> GetAll();

        
    }
}

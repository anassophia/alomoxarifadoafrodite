using AlmoxarifadoBackAPI.Models;
using Microsoft.AspNetCore;


namespace AlmoxarifadoBackAPI.Repositorio
{
    public interface ICategoriaRepositorio
    {
        void Add(Categoria obj);

        List<Categoria> GetAll();

        
    }
}

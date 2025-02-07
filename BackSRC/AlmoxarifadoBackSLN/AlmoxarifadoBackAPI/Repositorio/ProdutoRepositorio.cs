using AlmoxarifadoBackAPI.Models;
using Microsoft.AspNetCore;

namespace AlmoxarifadoBackAPI.Repositorio
{
    public class ProdutoRepositorio : lProdutoRepositorio
    {
        private readonly Context _db;

        public ProdutoRepositorio(Context db)
        {
            _db = db;
        }

        public void Add(Produto produto)
        {

            _db.Produto.Add(produto);
            _db.SaveChanges();
        }

        public List<Produto> GetAll()
        {
            return _db.Produto.ToList();
        }

      
    }
}

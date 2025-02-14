using AlmoxarifadoBackAPI.Models;
<<<<<<< HEAD
using Microsoft.AspNetCore;

namespace AlmoxarifadoBackAPI.Repositorio
{
    public class ProdutoRepositorio : lProdutoRepositorio
=======

namespace AlmoxarifadoBackAPI.Repositorio
{
    public class ProdutoRepositorio : IProdutoRepositorio
>>>>>>> upstream/feature/entrada
    {
        private readonly Context _db;

        public ProdutoRepositorio(Context db)
        {
            _db = db;
        }

<<<<<<< HEAD
        public void Add(Produto produto)
        {

            _db.Produto.Add(produto);
            _db.SaveChanges();
        }

        public List<Produto> GetAll()
        {
            return _db.Produto.ToList();
        }

      
=======
        public void Add(Produto obj)
        {
            
            _db.Produto.Add(obj);
            _db.SaveChanges();
        }

        public List<Produto> GetAll() { 
          return _db.Produto.ToList();
        }

>>>>>>> upstream/feature/entrada
    }
}

using AlmoxarifadoBackAPI.Models;

namespace AlmoxarifadoBackAPI.Repositorio
{
    public class ProdutoRepositorio
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

        public List<Categoria> GetAll()
        {
            return _db.Categoria.ToList();
        }
    }
}

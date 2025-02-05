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

        public void add(Produto produto)
        {

            _db.Produto.add(produto);
            _db.SaveChanges();
        }

        public List<Produto> Getall()
        {
            return _db.Produto.tolist();
        }
    }
}

using AlmoxarifadoBackAPI.Models;

namespace AlmoxarifadoBackAPI.Repositorio
{
    public class ItenSaidaRepositorio : IItenSaidaRepositorio
    {
        private readonly Context _db;

        public ItenSaidaRepositorio (Context db)
        {
            _db = db;
        }

        public void Add(ItenSaida itenSaida)
        {

            _db.ItenSaida.Add(itenSaida);
            _db.SaveChanges();
        }

        public List<ItenSaida> GetAll()
        {
            return _db.ItenSaida.ToList();
        }


    }
}

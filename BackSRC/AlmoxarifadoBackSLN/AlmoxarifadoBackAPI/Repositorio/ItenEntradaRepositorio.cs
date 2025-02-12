using AlmoxarifadoBackAPI.Models;

namespace AlmoxarifadoBackAPI.Repositorio
{
    public class ItenEntradaRepositorio : IItenEntradaRepositorio
    {

        private readonly Context _db;

        public ItenEntradaRepositorio(Context db)
        {
            _db = db;
        }

        public void Add(ItenEntrada itenEntrada)
        {

            _db.ItenEntrada.Add(itenEntrada);
            _db.SaveChanges();
        }

        public List<ItenEntrada> GetAll()
        {
            return _db.ItenEntrada.ToList();
        }


    }
}

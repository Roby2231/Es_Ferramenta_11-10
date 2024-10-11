using Task_Ferramenta.Models;

namespace Task_Ferramenta.Repos
{
    public class RepartoRepo : IRepo<Reparto>
    {
        private readonly AELez03FerramentaContext _context;
        public RepartoRepo(AELez03FerramentaContext context)
        {
            _context = context;
        }

        public bool Create(Reparto entity)
        {
            bool risultato = false;
            try
            {
                _context.Repartos.Add(entity);
                _context.SaveChanges();

                risultato = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return risultato;
        }

        public bool Delete(Reparto entity)
        {
            throw new NotImplementedException();
        }

        public Reparto? Get(int id)
        {
            return _context.Repartos.Find(id);
        }
        public Reparto? GetByCodice(string cod)
        {
            return _context.Repartos.FirstOrDefault(r => r.RepartoCOD == cod);
        }

        public IEnumerable<Reparto> GetAll()
        {
            return _context.Repartos.ToList();
        }

        public bool Update(Reparto entity)
        {
            throw new NotImplementedException();
        }
    }
}

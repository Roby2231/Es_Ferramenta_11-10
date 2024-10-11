using Task_Ferramenta.Models;

namespace Task_Ferramenta.Repos
{
    public class ProdottoRepo : IRepo<Prodotto>
    {
        private readonly AELez03FerramentaContext _context;
        public ProdottoRepo (AELez03FerramentaContext context)
        {
            _context = context;
        }
        public bool Create(Prodotto entity)
        {
            bool risultato = false;
            try
            {
                _context.Prodottos.Add(entity);
                _context.SaveChanges();

                risultato = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return risultato;
        }
        public bool Delete(Prodotto entity)
        {
            throw new NotImplementedException();
        }

        public Prodotto? Get(int id)
        {
            return _context.Prodottos.Find(id);
        }
        public Prodotto? GetByCodice(string cod)
        {
            return _context.Prodottos.FirstOrDefault(p => p.CodiceBarre == cod);
        }

        public IEnumerable<Prodotto> GetAll()
        {
            return _context.Prodottos.ToList();
        }

        public bool Update(Prodotto entity)
        {
            throw new NotImplementedException();
        }
    }
}

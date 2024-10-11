using Task_Ferramenta.Models;
using Task_Ferramenta.Repos;

namespace Task_Ferramenta.Services
{
    public class RepartoServices : IServices<RepartoDTO>
    {
        private readonly RepartoRepo _repository;

        public RepartoServices(RepartoRepo repository)
        {
            _repository = repository;
        }

        public RepartoDTO? Cerca(string varCod)
        {
            {
                RepartoDTO? risultato = null;

                Reparto? rep = _repository.GetByCodice(varCod);
                if (rep is not null)
                {
                    risultato = new RepartoDTO()
                    {
                        Cod = rep.RepartoCOD,
                        Nom = rep.Nome,
                        Fil = rep.Fila
                    };
                }

                return risultato;
            }
        }

        public IEnumerable<RepartoDTO> Lista()
        {
            throw new NotImplementedException();
        }
    }
}

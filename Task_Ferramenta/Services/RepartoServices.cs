using Microsoft.IdentityModel.Tokens;
using Task_Ferramenta.Controllers;
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
            var repDTOS = new List<RepartoDTO>();
            IEnumerable<Reparto> elenco = _repository.GetAll();
            foreach (var rep in elenco)
            {
                RepartoDTO temp = new RepartoDTO()
                {
                    Cod = rep.RepartoCOD,
                    Nom = rep.Nome,
                    Fil = rep.Fila
                };
                repDTOS.Add(temp);
            }

            return repDTOS;
        }
        public bool InserisciReparto(RepartoDTO repDTO)
        {
            bool risultato = false;
         
            if (!string.IsNullOrWhiteSpace(repDTO.Nom) && !string.IsNullOrWhiteSpace(repDTO.Fil))
            {
                Reparto rep = new Reparto()
                {
                    RepartoCOD = repDTO.Cod is not null ? repDTO.Cod : Guid.NewGuid().ToString().ToUpper(),
                    Nome = repDTO.Nom,
                    Fila = repDTO.Fil
                };

                return risultato = _repository.Create(rep);
            }

            return risultato;
        }
    }
    }

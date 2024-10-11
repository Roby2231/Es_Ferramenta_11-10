using Task_Ferramenta.Models;
using Task_Ferramenta.Repos;

namespace Task_Ferramenta.Services
{
    public class ProdottoServices : IServices<ProdottoDTO>
    {
        private readonly ProdottoRepo _repository;

        public ProdottoServices(ProdottoRepo repository)
        {
            _repository = repository;
        }
        public ProdottoDTO? Cerca(string varCod)
        {
            ProdottoDTO? risultato = null;

            Prodotto? pro = _repository.GetByCodice(varCod);
            if (pro is not null)
            {
                risultato = new ProdottoDTO()
                {
                    CodBa = pro.CodiceBarre,
                    Nom = pro.Nome,
                    Des = pro.Descrizione,
                    Pre = pro.Prezzo,
                    Quan = pro.Quantita,
                    RepRif = pro.RepartoRIF

                };
            }

            return risultato;
        }

        public IEnumerable<ProdottoDTO> Lista()
        {
            {
                var proDTOS = new List<ProdottoDTO>();
                IEnumerable<Prodotto> elenco = _repository.GetAll();
                foreach (var pro in elenco)
                {
                    ProdottoDTO temp = new ProdottoDTO()
                    {
                        CodBa = pro.CodiceBarre,
                        Nom = pro.Nome,
                        Des = pro.Descrizione,
                        Pre = pro.Prezzo,
                        Quan = pro.Quantita,
                        RepRif = pro.RepartoRIF
                    };

                    proDTOS.Add(temp);
                }

                return proDTOS;
            }
        }
    }
}

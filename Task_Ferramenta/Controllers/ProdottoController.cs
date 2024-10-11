using Microsoft.AspNetCore.Mvc;
using Task_Ferramenta.Models;
using Task_Ferramenta.Services;

namespace Task_Ferramenta.Controllers
{
    [ApiController]
    [Route("api/Prodotto")]
    public class ProdottoController : Controller
    {
        private readonly ProdottoServices _services;

        public ProdottoController(ProdottoServices services)
        {
            _services = services;
        }

        [HttpGet("{varCod}")]
        public ActionResult<ProdottoDTO?> CercaPerCodice(string varCod)
        {
            if (string.IsNullOrWhiteSpace(varCod))
                return BadRequest();

            ProdottoDTO? risultato = _services.Cerca(varCod);
            if (risultato is not null)
                return Ok(risultato);

            return NotFound();

        }
        [HttpGet("ElencoPro")]
        public ActionResult<List<ProdottoDTO>> ElencoProdotti()
        {
            var prodotti = _services.Lista();
            if (prodotti is not null)
                return Ok(prodotti);
            else return BadRequest();
        }
    }
}


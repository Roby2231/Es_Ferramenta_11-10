using Microsoft.AspNetCore.Mvc;
using Task_Ferramenta.Models;
using Task_Ferramenta.Services;

namespace Task_Ferramenta.Controllers
{
    [ApiController]
    [Route("api/Reparto")]
    public class RepartoController : Controller
    {
        private readonly RepartoServices _services;

        public RepartoController(RepartoServices services)
        {
            _services = services;
        }

        [HttpGet("{varCod}")]
        public ActionResult<RepartoDTO?> CercaPerCodice(string varCod)
        {
            if (string.IsNullOrWhiteSpace(varCod))
                return BadRequest();

            RepartoDTO? risultato = _services.Cerca(varCod);
            if (risultato is not null)
                return Ok(risultato);

            return NotFound();

        }
    }
}

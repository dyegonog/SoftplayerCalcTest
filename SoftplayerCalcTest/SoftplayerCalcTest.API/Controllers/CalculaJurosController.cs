using Microsoft.AspNetCore.Mvc;
using SoftplayerCalcTest.API.Controllers._Base;
using SoftplayerCalcTest.Aplicacao._Base;
using SoftplayerCalcTest.Aplicacao.Juros;

namespace SoftplayerCalcTest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculaJurosController : BaseController
    {
        private readonly CommandHandler<CalcularJuros, NewResourceResponse> _calcularJuros;

        public CalculaJurosController(CommandHandler<CalcularJuros, NewResourceResponse> calcularJuros)
        {
            _calcularJuros = calcularJuros;
        }

        [HttpGet]
        public IActionResult CalcularJuros([FromQuery] CalcularJuros cmd)
        {
            return OkResponse(cmd, _calcularJuros);
        }
    }
}
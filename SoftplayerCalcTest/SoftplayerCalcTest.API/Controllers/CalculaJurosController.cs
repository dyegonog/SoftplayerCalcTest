using System;
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
        private readonly CommandHandler<JurosCommandBase, NewResourceResponse> _calcularJuros;

        public CalculaJurosController(CommandHandler<JurosCommandBase, NewResourceResponse> calcularJuros)
        {
            _calcularJuros = calcularJuros;
        }

        [HttpGet]
        public IActionResult CalcularJuros([FromQuery] JurosCommandBase cmd)
        {
          
            return OkResponse(cmd, _calcularJuros);
        }
    }
}
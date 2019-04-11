using System;
using Microsoft.AspNetCore.Mvc;

namespace SoftplayerCalcTest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculaJurosController : Controller
    {
        private const decimal Precisao = 100;
        private const double Juros = 0.01;

        [HttpGet]
        public decimal CalcularJuros([FromQuery] decimal valor, int tempo)
        {
            var jurosTempo = (decimal)Math.Pow(Juros + 1.0, tempo);
            var resultado = valor * jurosTempo;

            var resultadoTruncado = string.Format("{0:0.00}", resultado);

            return decimal.Parse(resultadoTruncado);
        }
    }
}
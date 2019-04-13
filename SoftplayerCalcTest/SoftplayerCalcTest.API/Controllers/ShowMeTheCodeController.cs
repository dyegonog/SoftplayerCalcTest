using Microsoft.AspNetCore.Mvc;

namespace SoftplayerCalcTest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowMeTheCodeController : Controller
    {
        [HttpGet]
        public string ObterCodigoFonte()
        {
            return "https://github.com/dyegonog/SoftplayerCalcTest";
        }
    }
}
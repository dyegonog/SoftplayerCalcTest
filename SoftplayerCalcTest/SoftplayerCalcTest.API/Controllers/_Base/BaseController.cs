using Microsoft.AspNetCore.Mvc;
using SoftplayerCalcTest.Aplicacao._Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftplayerCalcTest.API.Controllers._Base
{
    public class BaseController : Controller
    {
        public IActionResult OkResponse<TCommand, TResponse>(TCommand command, CommandHandler<TCommand, TResponse> commandHandler)
            where TCommand : Command
            where TResponse : HandlerResponse
        {
            if (!command.IsValid()) return CreateBadRequestForInvalidInput(command);

            var response = commandHandler.Executar(command);

            return Ok(response);
        }

        private BadRequestObjectResult CreateBadRequestForInvalidInput(Command command)
        {
            return BadRequest(new BadRequestValue("Algumas informações estão com valores inválidos", command.Notifications));
        }
    }
}

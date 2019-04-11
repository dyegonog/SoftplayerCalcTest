using SoftplayerCalcTest.Aplicacao._Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftplayerCalcTest.API.Controllers._Base
{
    public class BadRequestValue
    {
        public string Mensagem { get; }
        public IReadOnlyCollection<Notification> Erros { get; }

        public BadRequestValue(string mensagem)
        {
            Mensagem = mensagem;
        }

        public BadRequestValue(string mensagem, IReadOnlyCollection<Notification> erros) : this(mensagem)
        {
            Erros = erros;
        }
    }
}

using SoftplayerCalcTest.Aplicacao._Base;
using System.Collections.Generic;

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
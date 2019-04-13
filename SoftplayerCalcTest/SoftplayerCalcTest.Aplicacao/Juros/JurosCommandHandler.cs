using SoftplayerCalcTest.Aplicacao._Base;
using SoftplayerCalcTest.Dominio;

namespace SoftplayerCalcTest.Aplicacao.Juros
{
    public class JurosCommandHandler : CommandHandler<CalcularJuros, NewResourceResponse>
    {
        public NewResourceResponse Executar(CalcularJuros cmd)
        {
            var juros = new JurosDomain(cmd.Tempo, cmd.ValorInicial);
            return NewResourceResponse.CreateSuccess(juros.Calcular());
        }
    }
}
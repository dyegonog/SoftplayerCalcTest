using SoftplayerCalcTest.Aplicacao._Base;

namespace SoftplayerCalcTest.Aplicacao.Juros
{
    public class JurosCommandHandler : CommandHandler<CalcularJuros, NewResourceResponse>
    {
        public NewResourceResponse Executar(CalcularJuros cmd)
        {
            var juros = new Dominio.Juros(cmd.Tempo, cmd.ValorInicial);
            return NewResourceResponse.CreateSuccess(juros.Calcular());
        }
    }
}
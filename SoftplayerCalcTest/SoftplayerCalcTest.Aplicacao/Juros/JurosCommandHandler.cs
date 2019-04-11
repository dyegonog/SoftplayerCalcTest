using SoftplayerCalcTest.Aplicacao._Base;

namespace SoftplayerCalcTest.Aplicacao.Juros
{
    public class JurosCommandHandler : CommandHandler<CalcularJuros, NewResourceResponse>
    {
        public NewResourceResponse Executar(CalcularJuros cmd)
        {
            return NewResourceResponse.CreateSuccess(cmd.Calcular());
        }
    }
}
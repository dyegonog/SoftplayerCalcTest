using SoftplayerCalcTest.Aplicacao._Base;

namespace SoftplayerCalcTest.Aplicacao.Juros
{
    public class JurosCommandHandler : CommandHandler<CalcularJuros, NewResourceResponse>
    {
        private readonly IJuros _juros;

        public JurosCommandHandler(IJuros juros)
        {
            _juros = juros;
        }

        public NewResourceResponse Executar(CalcularJuros cmd)
        {
            return NewResourceResponse.CreateSuccess(_juros.Calcular(cmd));
        }
    }
}
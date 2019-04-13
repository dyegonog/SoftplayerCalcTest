using SoftplayerCalcTest.Dominio;

namespace SoftplayerCalcTest.TestesDeUnidade.Dominio
{
    public class JurosBuilder
    {
        private int _tempo;
        private decimal _valorInicial;

        public static JurosBuilder Novo()
        {
            return new JurosBuilder();
        }

        public JurosBuilder ComTempo(int tempo)
        {
            _tempo = tempo;
            return this;
        }

        public JurosBuilder ComValorInicial(decimal valorInicial)
        {
            _valorInicial = valorInicial;
            return this;
        }

        public JurosDomain Build()
        {
            return new JurosDomain(_tempo, _valorInicial);
        }
    }
}
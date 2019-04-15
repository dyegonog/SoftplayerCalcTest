using SoftplayerCalcTest.Dominio;

namespace JurosDomainTeste
{
    public class JurosDomainBuilder
    {
        private int _tempo;
        private decimal _valorInicial;

        public static JurosDomainBuilder Novo()
        {
            return new JurosDomainBuilder();
        }

        public JurosDomainBuilder ComTempo(int tempo)
        {
            _tempo = tempo;
            return this;
        }

        public JurosDomainBuilder ComValorInicial(decimal valorInicial)
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
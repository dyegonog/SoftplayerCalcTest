using NUnit.Framework;

namespace JurosDomainTeste
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DeveCalcularJuros()
        {
            var jurosDomain = JurosDomainBuilder.Novo().ComTempo(5).ComValorInicial(100).Build();

            var esperado = 105.10;

            Assert.AreEqual(esperado, jurosDomain.Calcular());
        }
    }
}
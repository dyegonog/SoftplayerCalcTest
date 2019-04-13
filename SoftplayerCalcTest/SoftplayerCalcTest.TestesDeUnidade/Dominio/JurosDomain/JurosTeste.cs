using Xunit;

namespace SoftplayerCalcTest.TestesDeUnidade.Dominio.Juros.Domain
{
    public class JurosTeste
    {
        [Theory]
        [InlineData(100, 5)]
        public void Deve_Calcula_Juros(decimal valorEsperado, int tempo)
        {
            var juros = JurosBuilder.Novo().ComValorInicial(valorEsperado).ComTempo(tempo).Build();

            var esperado = (decimal)105.10;
            Assert.Equal(esperado, juros.Calcular());
        }
    }
}

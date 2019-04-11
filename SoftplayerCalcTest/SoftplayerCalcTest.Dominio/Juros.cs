using SoftplayerCalcTest.Aplicacao.Juros;
using System;

namespace SoftplayerCalcTest.Dominio
{
    public class Juros : IJuros
    {
        private const double PorcentagemDoJuros = 0.01;

        public decimal Calcular(CalcularJuros cmd)
        {
            var jurosTempo = (decimal)Math.Pow(PorcentagemDoJuros + 1.0, cmd.Tempo);
            var valorFinal = cmd.ValorInicial * jurosTempo;

            var valorFinalTruncado = string.Format("{0:0.00}", valorFinal);

            return decimal.Parse(valorFinalTruncado);
        }
    }
}

using System;

namespace SoftplayerCalcTest.Dominio
{
    public class Juros
    {
        private const double PorcentagemDoJuros = 0.01;
        public int Tempo { get; set; }
        public decimal ValorInicial { get; set; }

        public Juros(int tempo, decimal valorInicial)
        {
            Tempo = tempo;
            ValorInicial = valorInicial;
        }

        public decimal Calcular()
        {
            var jurosTempo = (decimal)Math.Pow(PorcentagemDoJuros + 1.0, Tempo);
            var valorFinal = ValorInicial * jurosTempo;

            var valorFinalTruncado = string.Format("{0:0.00}", valorFinal);

            return decimal.Parse(valorFinalTruncado);
        }
    }
}
﻿using SoftplayerCalcTest.Aplicacao._Base;
using System;
using System.Collections.Generic;

namespace SoftplayerCalcTest.Aplicacao.Juros
{
    public class JurosCommandBase : Notifiable, Command
    {
        public decimal ValorInicial { get; set; }
        public int Tempo { get; set; }
        private const double Juros = 0.01;

        public IReadOnlyCollection<Notification> Notificacoes => Notifications;

        public bool IsValid()
        {
            AddNotification(Assertion.IsGreaterThan(0, ValorInicial, nameof(ValorInicial)));
            AddNotification(Assertion.IsGreaterThan(0, Tempo, nameof(Tempo)));

            return !HasNotifications();
        }

        public decimal Calcular()
        {
            var jurosTempo = (decimal)Math.Pow(Juros + 1.0, Tempo);
            var resultado = ValorInicial * jurosTempo;

            var resultadoTruncado = string.Format("{0:0.00}", resultado);

            return decimal.Parse(resultadoTruncado);
        }
    }
}
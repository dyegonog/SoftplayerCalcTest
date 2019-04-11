using SoftplayerCalcTest.Aplicacao._Base;
using System;
using System.Collections.Generic;

namespace SoftplayerCalcTest.Aplicacao.Juros
{
    public class CalcularJuros : Notifiable, Command
    {
        public decimal ValorInicial { get; set; }
        public int Tempo { get; set; }

        public IReadOnlyCollection<Notification> Notificacoes => Notifications;

        public bool IsValid()
        {
            AddNotification(Assertion.IsGreaterThan(0, ValorInicial, nameof(ValorInicial)));
            AddNotification(Assertion.IsGreaterThan(0, Tempo, nameof(Tempo)));

            return !HasNotifications();
        }
    }
}
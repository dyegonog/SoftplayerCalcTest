using System.Collections.Generic;

namespace SoftplayerCalcTest.Aplicacao._Base
{
    public interface Command
    {
        bool IsValid();
        IReadOnlyCollection<Notification> Notifications { get; }
    }
}
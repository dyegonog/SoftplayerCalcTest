using System.Collections.Generic;

namespace SoftplayerCalcTest.Aplicacao._Base
{
    public abstract class Notifiable
    {
        private readonly List<Notification> _notifications = new List<Notification>();
        public IReadOnlyCollection<Notification> Notifications => _notifications;

        protected void AddNotification(Notification notification)
        {
            if (notification == null) return;
            _notifications.Add(notification);
        }

        protected void AddNotificationIf(bool condition, Notification notification)
        {
            if (condition) AddNotification(notification);
        }

        protected bool HasNotifications()
        {
            return _notifications.Any();
        }
    }
}

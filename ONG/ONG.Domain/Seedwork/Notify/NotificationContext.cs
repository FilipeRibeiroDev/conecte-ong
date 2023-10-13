using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONG.Domain.Seedwork.Notify
{
    public class NotificationContext
    {
        private readonly List<string> _notifications;
        public IReadOnlyCollection<string> Notifications => _notifications;
        public bool HasNotifications => _notifications.Any();

        public NotificationContext()
        {
            _notifications = new List<string>();
        }

        public void AddNotification(string message)
        {
            _notifications.Add(message);
        }
    }
}

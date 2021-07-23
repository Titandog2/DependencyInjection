using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class NotificationBL : INotificationBL
    {
        public NotificationBL(INotify notify)
        {
            Notify = notify;
        }
        INotify Notify;

        public void EnviarNotificacion(string User, string Email)
        {
            Notify.EnviarMensaje(User, Email);
        }
    }

    public interface INotificationBL
    {
        void EnviarNotificacion(string User, string Email);
    }
}

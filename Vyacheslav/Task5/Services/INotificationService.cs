using Vyacheslav.Task5.Privileges;

namespace Vyacheslav.Task5.Services
{
    public interface INotificationService  
    {
        public void SendNotification(string text, string recepient, Privilege privilege);
    }
}
using Vyacheslav.Task5.Privileges;

namespace Vyacheslav.Task5.Services
{
    public class NotificationService : INotificationService
    {
        private ILoggingService _loggingService;

        public NotificationService(ILoggingService loggingService) 
        {
            _loggingService = loggingService;
        }

        public void SendNotification(string text, string recipient, Privilege priority)
        {
            _loggingService.Log(text, recipient, priority);
        }
    }
}
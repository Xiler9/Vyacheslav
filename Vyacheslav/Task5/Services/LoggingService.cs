using Vyacheslav.Task5.Privileges;

namespace Vyacheslav.Task5.Services
{
    public class LoggingService : ILoggingService
    {
        private IPriorityService _priorityService;

        public LoggingService(IPriorityService priorityService)
        {
            _priorityService = priorityService;
        }

        public void Log(string text, string recepient, Privilege privilege)
        {
            Thread.Sleep(_priorityService.GetDelayByProperty(privilege));
            Console.WriteLine(LogLevel.Debug + $" Dear {recepient}: {text}");
        }
    }
}
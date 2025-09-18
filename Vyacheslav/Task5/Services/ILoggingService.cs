using Vyacheslav.Task5.Privileges;

namespace Vyacheslav.Task5.Services
{
    public interface ILoggingService
    {
        public void Log(string text, string recepient, Privilege privilege);
    }
}
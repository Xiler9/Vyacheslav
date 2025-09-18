using Vyacheslav.Task5.Privileges;

namespace Vyacheslav.Task5.Services
{
    public interface IPriorityService
    {
        public TimeSpan GetDelayByProperty(Privilege priority);
    }
}
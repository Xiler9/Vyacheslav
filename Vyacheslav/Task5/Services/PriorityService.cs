using Vyacheslav.Task5.Privileges;

namespace Vyacheslav.Task5.Services
{
    public class PriorityService : IPriorityService
    {
        public TimeSpan GetDelayByProperty(Privilege priority)
        {
            switch (priority)
            {
                case Privilege.low:
                    return TimeSpan.FromSeconds(5);
                case Privilege.medium: 
                    return TimeSpan.FromSeconds(2);
                case Privilege.high:
                    return TimeSpan.FromSeconds(0);
            }
            return default(TimeSpan);
        }
    }
}
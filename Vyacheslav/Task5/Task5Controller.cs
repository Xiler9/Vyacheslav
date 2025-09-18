using Microsoft.AspNetCore.Mvc;
using Vyacheslav.Task5.Models;
using Vyacheslav.Task5.Services;

namespace Vyacheslav.Task5
{
    [Route("api")]
    [ApiController]
    public class Task5Controller : ControllerBase
    {
        private INotificationService _notificationService;

        public Task5Controller(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpPost("notification")]
        public void SendNotification([FromBody] Request request)
        {
            _notificationService.SendNotification(request.Text, request.Recepient, request.Privilege);
        }
    }
}
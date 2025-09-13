using Microsoft.AspNetCore.Mvc;

namespace Vyacheslav.Controllers
{
    [ApiController]
    [Route("api/area")]
    public class AreaController
    {
        [HttpPost("rectangle")]
        public float GetRectangleArea([FromBody] Rectangle rectangle) => rectangle.heigh * rectangle.width;

        [HttpPost("circle")]
        public double GetCircleArea([FromBody] Circle circle) => Math.PI * Math.Pow(circle.radius, 2);

        [HttpPost("triangle")]
        public float GetTriangleArea([FromBody] Triangle triangle) => (triangle.foundation * triangle.heigh) / 2;
    }
}

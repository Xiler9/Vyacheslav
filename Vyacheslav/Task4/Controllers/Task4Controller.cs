using Microsoft.AspNetCore.Mvc;
using Vyacheslav.Task4.Services;

namespace Vyacheslav.Task4.Controller
{
    [Route("api")]
    [ApiController]
    public class Task4Controller : ControllerBase
    {
        private ICurrencyConverterService _currencyConverterService;

        public Task4Controller(ICurrencyConverterService currencyConverterService)
        {
            _currencyConverterService = currencyConverterService;
        }

        [HttpGet("currency/convert")]
        public IActionResult Convert(double amount, string from, string to)
        {
            return Ok(_currencyConverterService.Convert(amount, from, to));
        }
    }
}
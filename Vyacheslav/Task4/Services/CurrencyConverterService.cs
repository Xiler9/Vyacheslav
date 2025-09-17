namespace Vyacheslav.Task4.Services
{
    public class CurrencyConverterService : ICurrencyConverterService
    {
        private ICurrencyRateService _currencyRateService;

        public CurrencyConverterService(ICurrencyRateService currencyRateService)
        {
            _currencyRateService = currencyRateService;
        }

        public double Convert(double amount, string from, string to)
        {
            return amount * _currencyRateService.GetRate(from, to);
        }
    }
}
using Vyacheslav.Task4.Models;

namespace Vyacheslav.Task4.Services
{
    public class CurrencyRateService : ICurrencyRateService
    {
        private CurrencyRate _currencyRate;

        public CurrencyRateService()
        {
            _currencyRate = new CurrencyRate();
        }

        public double GetRate(string from, string to)
        {
            _currencyRate.From = from;
            _currencyRate.To = to;
            return _currencyRate.GetCurrencyRate();
        }
    }
}
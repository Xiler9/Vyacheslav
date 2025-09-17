namespace Vyacheslav.Task4.Services
{
    public interface ICurrencyRateService
    {
        public double GetRate(string from, string to);
    }
}
namespace Vyacheslav.Task4.Services
{
    public interface ICurrencyConverterService
    {
        public double Convert(double amount, string from, string to);
    }
}
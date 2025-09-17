namespace Vyacheslav.Task4.Models
{
    public class CurrencyRate
    {
        public string From { get; set; }
        public string To { get; set; }

        public double GetCurrencyRate()
        {
            switch (From)
            {
                case "RUB":
                    switch (To)
                    {
                        case "USD":
                            return 0.011;
                        case "EUR":
                            return 0.009;
                    }
                    break;
                case "USD":
                    switch (To)
                    {
                        case "RUB":
                            return 86;
                        case "EUR":
                            return 0.92;
                    }
                    break;
                case "EUR":
                    switch (To)
                    {
                        case "RUB":
                            return 93;
                        case "USD":
                            return 1.1;
                    }
                    break;
            }
            return 0;
        }
    }
}
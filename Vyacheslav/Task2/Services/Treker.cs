namespace Vyacheslav.Task2.Services
{
    public class Treker : ITreker
    {
        public int Count { get; set; }

        public string AddVisiting()
        {
            Count++;
            return "Успешно добавлено посещение!";
        }
        public int ReturnCount()
        {
            return Count;
        }
    }
}
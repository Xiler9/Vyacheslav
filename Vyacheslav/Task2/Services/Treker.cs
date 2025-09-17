namespace Vyacheslav.Task2.Services
{
    public class Treker : ITreker
    {
        private int _count;

        public string AddVisiting()
        {
            _count++;
            return "Успешно добавлено посещение!";
        }
        public int ReturnCount()
        {
            return _count;
        }
    }
}
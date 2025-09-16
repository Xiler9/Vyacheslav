namespace Vyacheslav.Task3.Classes
{
    public class Note
    {
        private static int _globalId;
        public int Id { get; private set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }

        public Note(string title, string content)
        {
            Id = _globalId;
            _globalId++;
            Title = title;
            Content = content;
            CreatedAt = DateTime.Now;
        }
    }
}
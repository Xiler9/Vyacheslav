using Vyacheslav.Task3.Classes;

namespace Vyacheslav.Task3.Services
{
    public interface INoteService
    {
        public string AddNote(string title, string content);
        public string DeleteNote(int id);
        public Note GetNote(int id);
        public List<Note> GetAllNotes();
    }
}
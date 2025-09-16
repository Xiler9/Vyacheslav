using Vyacheslav.Task3.Classes;

namespace Vyacheslav.Task3.Services
{
    public class NoteService : INoteService
    {
        private List<Note> _notes = new List<Note>();

        public string AddNote(string title, string content)
        {
            Note note = new Note(title, content);
            _notes.Add(note);
            return $"Запись успешно сохранена, ваш Id:  {note.Id}";
        }

        public string DeleteNote(int id)
        {
            _notes.RemoveAll(x => x.Id == id);
            return "Запись успешно удалена!";
        }

        public Note GetNote(int id)
        {
            return _notes.FirstOrDefault(note => note.Id == id);
        }

        public List<Note> GetAllNotes()
        {
            return _notes;
        }
    }
}
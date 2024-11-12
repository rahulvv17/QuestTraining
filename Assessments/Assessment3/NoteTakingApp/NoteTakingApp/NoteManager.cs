using System;
using log4net;

namespace NoteTakingApp
{
    public class NoteManager
    {
        private readonly NoteRepository _noteRepository;
        private static readonly ILog log = LogManager.GetLogger(typeof(NoteManager));

        public NoteManager(NoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        public void CreateNote()
        {
            try
            {
                Console.Write("Enter note title: ");
                string title = Console.ReadLine();
                Console.Write("Enter note content: ");
                string content = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(content))
                {
                    Console.WriteLine("Title and content cannot be empty.");
                    log.Warn("Attempted to create a note with empty title or content.");
                    return;
                }

                var note = new Note
                {
                    Title = title,
                    Content = content,
                    CreatedAt = DateTime.Now
                };

                _noteRepository.Create(note);
                Console.WriteLine("Note created successfully.");
                log.Info("Note created successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while creating the note.");
                log.Error("Error creating note", ex);
            }
        }

        public void ViewAllNotes()
        {
            try
            {
                var notes = _noteRepository.GetAll();

                foreach (var note in notes)
                {
                    Console.WriteLine($"ID: {note.Id}, Title: {note.Title}, CreatedAt: {note.CreatedAt}");
                    Console.WriteLine($"Content Snippet: {note.Content.Substring(0, Math.Min(note.Content.Length, 20))}");
                    Console.WriteLine();
                }

                log.Info("Viewed all notes successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving notes.");
                log.Error("Error retrieving notes", ex);
            }
        }

        public void UpdateNote()
        {
            try
            {
                Console.Write("Enter the ID of the note to update: ");
                if (!int.TryParse(Console.ReadLine(), out int id))
                {
                    Console.WriteLine("Invalid ID.");
                    log.Warn("Invalid ID entered for note update.");
                    return;
                }

                var notes = _noteRepository.GetAll();
                var note = notes.Find(n => n.Id == id);

                if (note == null)
                {
                    Console.WriteLine("Note not found.");
                    log.Warn($"Note with ID {id} not found.");
                    return;
                }

                Console.Write("Enter new title: ");
                string newTitle = Console.ReadLine();
                Console.Write("Enter new content: ");
                string newContent = Console.ReadLine();

                note.Title = string.IsNullOrWhiteSpace(newTitle) ? note.Title : newTitle;
                note.Content = string.IsNullOrWhiteSpace(newContent) ? note.Content : newContent;
                note.UpdatedAt = DateTime.Now;

                _noteRepository.Update(note);
                Console.WriteLine("Note updated successfully.");
                log.Info($"Note with ID {id} updated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while updating the note.");
                log.Error("Error updating note", ex);
            }
        }

        public void DeleteNote()
        {
            try
            {
                Console.Write("Enter the ID of the note to delete: ");
                if (!int.TryParse(Console.ReadLine(), out int id))
                {
                    Console.WriteLine("Invalid ID.");
                    log.Warn("Invalid ID entered for note deletion.");
                    return;
                }

                _noteRepository.Delete(id);
                Console.WriteLine("Note deleted successfully.");
                log.Info($"Note with ID {id} deleted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while deleting the note.");
                log.Error("Error deleting note", ex);
            }
        }
    }
}

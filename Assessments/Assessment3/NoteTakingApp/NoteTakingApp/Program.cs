using log4net;
using log4net.Config;
using NoteTakingApp;
using System;
using System.IO;
using System.Reflection;

class Program
{
    private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
    private static NoteRepository _noteRepository;

    static void Main()
    {
        XmlConfigurator.Configure(new FileInfo("log4net.config"));

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Rahul vv\\Documents\\NoteTakingApp.mdf\";Integrated Security=True;";
        _noteRepository = new NoteRepository(connectionString);

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\n1. Create a new note");
            Console.WriteLine("2. View all notes");
            Console.WriteLine("3. Update a note");
            Console.WriteLine("4. Delete a note");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            try
            {
                switch (choice)
                {
                    case "1":
                        CreateNote();
                        break;
                    case "2":
                        ViewAllNotes();
                        break;
                    case "3":
                        UpdateNote();
                        break;
                    case "4":
                        DeleteNote();
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
            catch (Exception ex)
            {
                log.Error("An error occurred in the main menu", ex);
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }

    static void CreateNote()
    {
        Console.Write("Enter note title: ");
        string title = Console.ReadLine();
        Console.Write("Enter note content: ");
        string content = Console.ReadLine();

        var note = new Note
        {
            Title = title,
            Content = content,
            CreatedAt = DateTime.Now
        };

        _noteRepository.Create(note);
        log.Info("New note created.");
    }

    static void ViewAllNotes()
    {
        var notes = _noteRepository.GetAll();
        foreach (var note in notes)
        {
            Console.WriteLine($"{note.Id} - {note.Title} - {note.CreatedAt}: {note.Content.Substring(0, Math.Min(note.Content.Length, 20))}...");
        }
    }

    static void UpdateNote()
    {
        Console.Write("Enter note ID to update: ");
        int id = int.Parse(Console.ReadLine());

        var note = new Note
        {
            Id = id,
            Title = Console.ReadLine(),
            Content = Console.ReadLine(),
            UpdatedAt = DateTime.Now
        };

        _noteRepository.Update(note);
        log.Info("Note updated.");
    }

    static void DeleteNote()
    {
        Console.Write("Enter note ID to delete: ");
        int id = int.Parse(Console.ReadLine());

        _noteRepository.Delete(id);
        log.Info("Note deleted.");
    }
}

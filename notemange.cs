using System;

public static class NoteManager
{
    public static void CreateNewNote(User user)
    {
        Console.WriteLine("Titel för ny anteckning:");
        string title = Console.ReadLine();

        Console.WriteLine("Innehåll för ny anteckning:");
        string content = Console.ReadLine();

        // Alternativ logik för att hantera ogiltig inmatning
        if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(content))
        {
            Console.WriteLine("Ogiltig inmatning, titel och innehåll kan inte vara tomma.");
            return;
        }

        Note newNote = new Note
        {
            Title = title,
            Content = content,
            CreationDate = DateTime.Now,
            LastModifiedDate = DateTime.Now
        };

        user.AddNote(newNote);
        Console.WriteLine("Anteckningen har skapats.");
    }
}

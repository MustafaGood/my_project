using System;
using System.Collections.Generic;

public class User
{
    public string Email { get; set; } = string.Empty; // Initialisera för att undvika null
    public string Password { get; set; } = string.Empty; // Initialisera för att undvika null
    private List<Note> Notes { get; } = new List<Note>();

    // Dina andra metoder...
    public void AddNote(Note note)
    {
        if (note == null)
        {
            throw new ArgumentNullException(nameof(note), "Note cannot be null.");
        }

        Notes.Add(note);
    }

    // ... resten av dina metoder ...
}

public class Note
{
    public string Title { get; set; } = string.Empty; 
    public string Content { get; set; } = string.Empty; 
    public DateTime CreationDate { get; set; }
    public DateTime LastModifiedDate { get; set; }
}

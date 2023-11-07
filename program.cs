using System;

class Program
{
    static void Main(string[] args)
    {
        User currentUser = new User(); // Lägg till din logik för att skapa eller hämta en befintlig användare.
        NoteManager.CreateNewNote(currentUser);
        // Eventuell ytterligare logik kan köras här.
    }
}

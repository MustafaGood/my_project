using System;
using System.IO;

namespace MyApplication
{
    public class NoteManager
    {
        public void SaveNote(string noteContent, string filePath)
        {
            // Kontrollerar om katalogen för filen existerar, om inte skapa den.
            var directory = Path.GetDirectoryName(filePath);
            if (!string.IsNullOrWhiteSpace(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            // Använda StreamWriter för att skriva texten till filen.
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(noteContent);
            }
        }
    }
}
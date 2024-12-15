using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private static List<Scripture> _scriptures;

    static void Main(string[] args)
    {
        LoadScripturesFromFile("scriptures.txt");
        var random = new Random();
        var currentScripture = _scriptures[random.Next(_scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(currentScripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input?.ToLower() == "quit")
                break;

            if (!currentScripture.IsCompletelyHidden())
            {
                currentScripture.HideRandomWords(3);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("All words are hidden!");
                Console.WriteLine(currentScripture.GetDisplayText());
                break;
            }
        }

    }
                    private static void LoadScripturesFromFile(string filePath)
        {
            _scriptures = new List<Scripture>();
            try
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 2)
                    {
                        var referenceParts = parts[0].Split(':');
                        string book = referenceParts[0];
                        var verseParts = referenceParts[1].Split('-');
                        int chapter = int.Parse(verseParts[0].Split('.')[0]);
                        int startVerse = int.Parse(verseParts[0].Split('.')[1]);

                        if (verseParts.Length > 1)
                        {
                            int endVerse = int.Parse(verseParts[1]);
                            _scriptures.Add(new Scripture(new Reference(book, chapter, startVerse, endVerse), parts[1]));
                        }
                        else
                        {
                            _scriptures.Add(new Scripture(new Reference(book, chapter, startVerse), parts[1]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading scriptures: {ex.Message}");
            }
        }
}

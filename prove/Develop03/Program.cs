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
}
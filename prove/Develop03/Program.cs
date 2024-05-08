using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ScriptureReference reference = new ScriptureReference("John ", 3, 16);
            Scripture scripture = new Scripture(reference, "For God so loved the world,[a] that he gave his only Son, that whoever believes in him should not perish but have eternal life.");

            Console.WriteLine("Complete Scripture:");
            scripture.Display();

            Console.WriteLine("\nPress Enter to hide words or type 'exit' to exit.");
            while (!scripture.AllWordsHidden())
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "exit")
                {
                    break;
                }
                else
                {
                    int numWordsToHide = new Random().Next(1, 5); 
                    scripture.HideWords(numWordsToHide);

                    Console.Clear();
                    Console.WriteLine("\nScripture with hidden words:");
                    scripture.Display();
                }
            }
        }
    }
}

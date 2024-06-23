using System;

//Added a ScriptureLibrary class and randomly selects a scripture and its reference from this library for the exercise
class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary scriptureLibrary = new ScriptureLibrary();

        Random random = new Random();

        int scriptureIndex = random.Next(0, scriptureLibrary.GetCount());
        
        Scripture scripture = scriptureLibrary.GetAllScriptures()[scriptureIndex];
        
        Console.WriteLine(scripture.GetDisplayText());
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("\nPress enter to hide more words...");
            Console.ReadLine();

            scripture.HideRandomWords(3);

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
        }
    }
}
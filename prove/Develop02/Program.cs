using System;
using System.Collections.Generic;
using System.IO;

//No Additional creativity added
class Program
{
    static void Main(string[] args)
    {
        Journal newJournal = new Journal();
        PromptGenerator newPrompt = new PromptGenerator();
        int userSelection;

        Console.WriteLine("Welcome to your journal.\nPlease select from the following options using the associated number (ex. 1, 2, 3).");
        Console.WriteLine("1. Open journal\n2. New Journal\nTo close the program enter 10");

        do
        {
            userSelection = int.Parse(Console.ReadLine());
            if (userSelection == 1)
            {
                OpenJournal(newJournal, newPrompt);
            }
            else if (userSelection == 2)
            {
                CreateNewJournal(newJournal, newPrompt);
            }
            else
            {
                Console.WriteLine("Please select an option from the menu.");
                Console.WriteLine("1. Open journal\n2. New Journal\nTo close the program enter 10");

            }
        } while (userSelection != 10);
    }

    static void OpenJournal(Journal newJournal, PromptGenerator newPrompt)
    {
        Console.WriteLine("Please enter the name of the journal you wish to open:");
        string userJournal = Console.ReadLine();
        string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string journalDirectory = Path.Combine(documentsFolder, "MyJournalApp", "Journals");

        if (!Directory.Exists(journalDirectory))
        {
            Directory.CreateDirectory(journalDirectory);
        }

        string journalFile = Path.Combine(journalDirectory, userJournal + ".json");

        newJournal.LoadFromFile(journalFile);

        DisplayJournalMenu(newJournal, newPrompt, journalFile);
    }

    static void CreateNewJournal(Journal newJournal, PromptGenerator newPrompt)
    {
        Console.WriteLine("Please enter a name for your new journal:");
        string userJournal = Console.ReadLine();
        string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string journalDirectory = Path.Combine(documentsFolder, "MyJournalApp", "Journals");

        if (!Directory.Exists(journalDirectory))
        {
            Directory.CreateDirectory(journalDirectory);
        }
        string journalFile = Path.Combine(journalDirectory, userJournal + ".json");

        DisplayJournalMenu(newJournal, newPrompt, journalFile);
    }

    static void DisplayJournalMenu(Journal newJournal, PromptGenerator newPrompt, string journalFile)
    {
        int userSelection;
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        do
        {
            Console.WriteLine("Please select from the following options using the associated number (ex. 1, 2, 3).");
            Console.WriteLine("1. Display all entries\n2. Add new entry\n3. Save journal\nTo return to the main menu enter 9");

            userSelection = int.Parse(Console.ReadLine());

            if (userSelection == 1)
            {
                newJournal.DisplayAll();
            }
            else if (userSelection == 2)
            {
                Console.WriteLine("Using the following prompt, write a brief entry.");
                string journalPrompt = newPrompt.GetRandomPrompt();
                Console.WriteLine(journalPrompt);
                
                Entry entry = new Entry
                {
                    _entryDate = dateText,
                    _entryPrompt = journalPrompt,
                    _entryContent = Console.ReadLine()
                };
                newJournal.AddEntry(entry);
            }
            else if (userSelection == 3)
            {
                newJournal.SaveToFile(journalFile);
            }
            else
            {
                Console.WriteLine("Please select an option from the menu.");
                Console.WriteLine("1. Open journal\n2. New Journal\nTo close the program enter 10");

            }
        } while (userSelection != 9);
    }
}




















































// using System;
// using System.Collections.Generic;
// using System.IO;

// class Program
// {
//     static void Main(string[] args)
//     {

//         Journal newJournal = new Journal();
//         Entry entry1 = new Entry();
//         PromptGenerator newPrompt = new PromptGenerator();
//         int userSelection;
//         string userJournal;
//         string journalFile;
//         DateTime theCurrentTime = DateTime.Now;
//         string dateText = theCurrentTime.ToShortDateString();

//         Console.WriteLine("Welcome to your journal.\nPlease select from the following options using the associated number (ex. 1, 2, 3).");
//         Console.WriteLine("1. Open journal\n2. New Journal\nTo close the program enter 10");
//         do
//         {
//             userSelection = int.Parse(Console.ReadLine());
//             if (userSelection == 1)
//             {
//                 Console.WriteLine("Please enter the name of the journal you wish to open.");
//                 userJournal = Console.ReadLine();
//                 journalFile = @"C:\Users\chris\OneDrive\Documents\GitHub\cse210\prove\Develop02\" + userJournal;
//                 userSelection = 0;

//                 newJournal.LoadFromFile(journalFile);

//                 Console.WriteLine("Please select from the following options using the associated number (ex. 1, 2, 3).");
//                 Console.WriteLine("1. Display all entries\n2. Add new entry\n 3. Save journal");
//                 userSelection = int.Parse(Console.ReadLine());
//                 do
//                 {
//                     if (userSelection == 1)
//                     {
//                         newJournal.DisplayAll(newJournal._entries);
//                         userSelection = 0;
//                     }
//                     if (userSelection == 2)
//                     {
//                         Console.WriteLine("Using the following prompt, write a brief entry.");
//                         string journalPrompt = newPrompt.GetRandomPrompt();
//                         Console.WriteLine(journalPrompt);
//                         entry1._entryDate = dateText;
//                         entry1._entryPrompt = journalPrompt;
//                         entry1._entryContent = Console.ReadLine();
//                         newJournal.AddEntry(entry1);
//                         userSelection = 0;
//                     }
//                     if (userSelection == 3)
//                     {
//                         newJournal.SaveToFile();
//                         userSelection = 0;
//                     }
//                     else
//                     {
//                         Console.WriteLine("Please select an option from the menu.");
//                         userSelection = 0;
//                     }
//                 } while (userSelection != 9);

//             }
//             else if (userSelection == 2)
//             {
//                 Console.WriteLine("Please select from the following options using the associated number (ex. 1, 2, 3).");
//                 Console.WriteLine("1. Display all entries\n2. Add new entry\n 3. Save journal");
//                 userSelection = int.Parse(Console.ReadLine());
//                 do
//                 {
//                     if (userSelection == 1)
//                     {
//                         newJournal.DisplayAll(newJournal._entries);
//                         userSelection = 0;
//                     }
//                     if (userSelection == 2)
//                     {
//                         Console.WriteLine("Using the following prompt, write a brief entry.");
//                         string journalPrompt = newPrompt.GetRandomPrompt();
//                         Console.WriteLine(journalPrompt);
//                         entry1._entryDate = dateText;
//                         entry1._entryPrompt = journalPrompt;
//                         entry1._entryContent = Console.ReadLine();
//                         newJournal.AddEntry(entry1);
//                         userSelection = 0;
//                     }
//                     if (userSelection == 3)
//                     {
//                         newJournal.SaveToFile();
//                         userSelection = 0;
//                     }
//                     else
//                     {
//                         Console.WriteLine("Please select an option from the menu.");
//                         userSelection = 0;
//                     }
//                 } while (userSelection != 9);

//             }
//             else
//             {
//                 Console.WriteLine("Please select an option from the menu.");
//                 userSelection = 0;
//             }
//         } while (userSelection != 10);

//     }
// }



/*        entry1._entryDate = dateText;
        entry1._entryPrompt = "Did you play today?";
        entry1._entryContent = "I played in the grass with my son";
        Entry entry2 = new Entry();
        entry2._entryDate = dateText;
        entry2._entryPrompt = "Did you work?";
        entry2._entryContent = "I unloaded the dishwasher and made dinner";

        newJournal.AddEntry(entry1);
        newJournal.AddEntry(entry2);*/
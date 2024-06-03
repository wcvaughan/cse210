using System;

class Program
{
    static void Main(string[] args)
    {
        /*Prompt the user for their first name. Then, prompt them for their last name. 
        Display the text back all on one line saying, "Your name is last-name, first-name, last-name"*/

        Console.WriteLine("What is your first name?");
        string f_name = Console.ReadLine();
        Console.WriteLine("What is your last name?");
        string l_name = Console.ReadLine();

        Console.WriteLine($"Your name is {l_name}, {f_name} {l_name}");
        Console.ReadLine();
    }
}
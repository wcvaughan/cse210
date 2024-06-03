using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userFavNum = PromptUserNumber();
        int numSquared = SquareNumber(userFavNum);
        DisplayResult(userName, numSquared);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("What is your name?");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number?");
        int userFavNum = int.Parse(Console.ReadLine());
        return userFavNum;
    }
    static int SquareNumber(int number)
    {
        int numSquared = number * number;
        return numSquared;
    }
    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"Senor {name}, the square of your number is {number}");
    }
}
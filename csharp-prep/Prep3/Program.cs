using System;

class Program
{
    static void Main(string[] args)
    {
        /*Start by asking the user for the magic number. (In future steps, 
        we will change this to have the computer generate a random number, 
        but to get started, we'll just let the user decide what it is.)

        Ask the user for a guess.

        Using an if statement, determine if the user needs to guess 
        higher or lower next time, or tell them if they guessed it.

        At this point, you won't have any loops.*/
        Random randomGenerator = new Random();
        int userGuess;
        int magicNum = randomGenerator.Next(1, 100);
        do
        {
            Console.WriteLine("What is your guess?");
            userGuess = int.Parse(Console.ReadLine());
            if (userGuess < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else if (userGuess > magicNum)
            {
                Console.WriteLine("Lower");
            }
        } while (userGuess != magicNum);
        Console.WriteLine("You guessed it!");
    }
}
using System;
using System.Threading;

//Added unique breathing animation to breathing exercise
//Listed back to user their responses in the listing activity
//Added functionality to allow user to access other activities after completing one
class Program
{
    static void Main(string[] args)
    {
        bool quitRequested = false;

        while (!quitRequested)
        {
            Console.WriteLine("~Welcome to your daily mindfulness practice~");
            Thread.Sleep(500);
            Console.WriteLine("Please choose from the following options.");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflection Activity");
            Console.WriteLine("4. Quit");
            int userSelection = int.Parse(Console.ReadLine());
            switch (userSelection)
            {
                case 1:
                    BreathingActivity newBreathingActivity = new BreathingActivity();
                    newBreathingActivity.Run();
                    break;
                case 2:
                    ListingActivity newListingActivity = new ListingActivity();
                    newListingActivity.Run();
                    break;
                case 3:
                    ReflectionActivity newReflectionActivity = new ReflectionActivity();
                    newReflectionActivity.Run();
                    break;
                case 4:
                    quitRequested = true;
                    Console.WriteLine("Thank you for taking time to act mindfully. Breathe easier!");
                    break;
                default:
                    Console.WriteLine("Please select from one of the options");
                    Thread.Sleep(5000);
                    break;
            }
        }
    }
}
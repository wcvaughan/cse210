using System;

class Program
{
    static void Main(string[] args)
    {
        bool quitRequested = false;

        while (!quitRequested)
        {
            Console.WriteLine("~Welcome to your daily exercise~");
            Thread.Sleep(500);
            Console.WriteLine("Please choose from the following options.");
            Console.WriteLine("1. Running");
            Console.WriteLine("2. Swimming");
            Console.WriteLine("3. Cycling");
            Console.WriteLine("4. Quit");
            int userSelection = int.Parse(Console.ReadLine());
            switch (userSelection)
            {
                case 1:
                    Running newRun = new Running();
                    newRun.Run();
                    break;
                case 2:
                    Swimming newSwim = new Swimming();
                    newSwim.Run();
                    break;
                case 3:
                    Cycling newCycle = new Cycling();
                    newCycle.Run();
                    break;
                case 4:
                    quitRequested = true;
                    Console.WriteLine("way to go! Keep recording your exercises and you'll go farther.");
                    break;
                default:
                    Console.WriteLine("Please select from one of the options");
                    Thread.Sleep(5000);
                    break;
            }
        }
    }
}
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;
        int sum = 0;
        double numbersAve;
        int largestNum = 0;
        do
        {
            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        } while (number != 0);
        foreach (int num in numbers)
        {
            sum += num;
            if (num > largestNum)
            {
                largestNum = num;
            }
        }
        numbersAve = sum / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {numbersAve}");
        Console.WriteLine($"The largest number is: {largestNum}");
    }
}
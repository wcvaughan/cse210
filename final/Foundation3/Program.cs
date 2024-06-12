using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("163 Romaguera Union", "Boganmouth", "NM", "USA", 20907-8183);
        Lectures newlecture = new Lectures("Radiation Protection Rules", "A gripping lecture on the dangers and safety of proper radiation use.", "August 5th, 1899", "6:00 pm", lectureAddress, "Nicola Tesla", 150);
        Console.WriteLine(newlecture.DisplayEventDetails());
        Console.WriteLine();
        Console.WriteLine(newlecture.DisplayStandardDetails());
        Console.WriteLine();
        Console.WriteLine(newlecture.DisplayShortDescription());
        Console.WriteLine();

        Address outdoorGatheringAddress = new Address("6384 Marty Lock", "Lake Shenikaview", "ND", "USA", 39154-2069);
        OutdoorGatherings newOutdoorGathering = new OutdoorGatherings("Colony Days", "Annual celebration of the colonist origins of our home valley.", "June 9, 2024", "9 am - 7 pm", outdoorGatheringAddress, "rain and wind");
        Console.WriteLine(newOutdoorGathering.DisplayEventDetails());
        Console.WriteLine();
        Console.WriteLine(newOutdoorGathering.DisplayStandardDetails());
        Console.WriteLine();
        Console.WriteLine(newOutdoorGathering.DisplayShortDescription());
        Console.WriteLine();

        Address receptionAddress = new Address("405 Lehner Hill", "Belenmouth", "HI", "USA", 43448);
        Receptions newReception = new Receptions("A celebration of Sonic the Hedgehog", "Let us gather and remember the good times with the original Sega.", "January 1st, 2000", "9:00 am", receptionAddress, "sonicRulez2001@hotmail.com");
        Console.WriteLine(newReception.DisplayEventDetails());
        Console.WriteLine();
        Console.WriteLine(newReception.DisplayStandardDetails());
        Console.WriteLine();
        Console.WriteLine(newReception.DisplayShortDescription());
    }
}
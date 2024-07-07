using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

public class ListingActivity : Activity
{

    private List<string> _prompts { get; set; } = new List<string> {
        "Who are people that you appreciate?", 
        "What are personal strengths of yours?", 
        "Who are people that you have helped this week?", 
        "When have you felt the Holy Ghost this month?", 
        "Who are some of your personal heroes?"
        };
    private List<string> userList = new List<string>();
    public ListingActivity()
     : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 50)
    {
    }
    public void Run()
    {
        DisplayStartingMessage();
        Thread.Sleep(3000);

        ShowCountDown();
        Console.Clear();

        DisplayPrompt();
        Thread.Sleep(3000);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(ActivityDuration);
        while (DateTime.Now < endTime)
        {
            GetListFromUser();
        }
        Console.Clear();
        Console.WriteLine("User responses: ");
        int i = 0;
        foreach(string s in userList)
        {
            Console.WriteLine(s);
            i++;
        }
        Console.WriteLine($"{i} responses");
        Thread.Sleep(9000);
        DisplayEndingMessage();

    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int ranNum = random.Next(0, _prompts.Count());
        string randomPrompt = _prompts[ranNum];
        return randomPrompt;
    }
    public void DisplayPrompt()
    {
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine(randomPrompt);
    }
    public List<string> GetListFromUser()
    {
        string userInput = Console.ReadLine();
        userList.Add(userInput);

        return userList;
    }
}
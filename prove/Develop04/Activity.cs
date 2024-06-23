using System.Diagnostics;

public class Activity
{
    protected string _activityName { get; set;}
    protected string _activityDescription { get; set;}
    protected int _activityDuration { get; set;}

    public Activity(string activityName, string activityDescription, int activityDuration)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
        SetActivityDuration(_activityDuration);

    }
    public void SetActivityDuration(int activityDuration)
    {
        _activityDuration = activityDuration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName} activity.");
        Console.WriteLine(_activityDescription);
        Thread.Sleep(5000);
        Console.WriteLine("How long do you want to practice this mindful activity?");
        SetActivityDuration(int.Parse(Console.ReadLine()));
        Console.WriteLine($"This activity will last for {_activityDuration} seconds.");
    }
    public void DisplayEndingMessage()
    {
        Console.Clear();
        Console.WriteLine("Hoping this mindfulness activity provides some peace and healing today.");
    }
    public void ShowSpinner()
    {

    }
    public void ShowCountDown()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}
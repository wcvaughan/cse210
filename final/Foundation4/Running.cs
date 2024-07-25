public class Running : Activity
{
    public Running(int distance, int duration, string date) : base(distance, duration, date)
    {
        distance = GetDistance();
    }
    public void Run()
    {
        Console.WriteLine("");
    }
    public override int GetDistance()
    {
        return base.GetDistance();
    }
}
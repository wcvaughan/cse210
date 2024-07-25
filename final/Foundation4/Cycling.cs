public class Cycling : Activity
{
    public Cycling(int distance, int duration, string date) : base(distance, duration, date)
    {

    }

    public void Run()
    {
        
    }
    public override int GetSpeed(int distance, int duration)
    {
        return base.GetSpeed(distance, duration);
    }
}
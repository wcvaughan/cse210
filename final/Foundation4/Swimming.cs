public class Swimming : Activity
{
    private int _lapCount;
    public Swimming(int distance, int duration, string date, int lapCount) 
        : base(distance, duration, date)
    {
        _lapCount = lapCount;
    }

    public void Run()
    {
        
    }
    public override int GetDistance()
    {
        return base.GetDistance();
    }
}
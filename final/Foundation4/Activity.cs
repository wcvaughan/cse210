public class Activity
{
    private int _distance;
    private int _duration;
    private string _date;
    public Activity(int distance, int duration, string date)
    {
        _distance = distance;
        _duration = duration;
        _date = date;
    }
    public virtual int GetDistance()
    {
        return _distance;
    }
    public virtual int GetSpeed(int distance, int duration)
    {
        int speed = distance / duration * 60;
        return speed;
    }
    public virtual int GetPace(int duration, int distance)
    {
        int pace = duration / distance;
        return pace;
    }
    public virtual string GetSummary()
    {
        return "";
    }
}
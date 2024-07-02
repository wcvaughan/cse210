public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points)
     : base("Eternal Goal", description, points)
    {

    }
    public void RecordEvent()
    {

    }
    public bool IsComplete()
    {
        return false;
    }
    public string GetStringRepresentation()
    {
        return "";
    }
}
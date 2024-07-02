public class SimpleGoal : Goal
{
    public bool _isComplete;
    public SimpleGoal(string name, string description, string points, bool isComplete)
     : base("Simple Goal", description, points)
    {
        _isComplete = isComplete;
    }
    public void RecordEvent()
    {

    }
    public bool IsComplete()
    {
        return _isComplete;
    }
    public string GetStringRepresentation()
    {
        return $"";
    }
}
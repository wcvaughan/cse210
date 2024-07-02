public class ChecklistGoal : Goal
{
    public int _amountCompleted;
    public int _target;
    public int _bonus;
    public ChecklistGoal(string name, string description, string points, int target, int bonus)
     : base("Checklist Goal", description, points)
     {
        _target = target;
        _bonus = bonus;
     }
     public void RecordEvent()
     {

     }
     public bool IsComplete()
     {
        return false;
     }
     public string GetDetailsString()
     {
        return "";
     }
     public string GetStringRepresentation()
     {
        return "";
     }

}
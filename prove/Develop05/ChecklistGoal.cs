using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

public class ChecklistGoal : Goal
{
    public int AmountCompleted { get; private set; }
    public int Target { get; }
    public int Bonus { get; }
    
    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        Target = target;
        Bonus = bonus;
        AmountCompleted = 0;
    }

    public override void RecordEvent()
    {
        AmountCompleted++;
        if (IsComplete())
        {
            Console.WriteLine($"Congratulations! You've completed the checklist goal and earned {Points} points plus a bonus of {Bonus} points.");
        }
        else
        {
            Console.WriteLine($"Progress made on checklist goal: {AmountCompleted}/{Target}.");
        }
    }
     public override bool IsComplete()
     {
        return AmountCompleted >= Target;
     }
     public override string GetDetailsString()
     {
        return $"{ShortName}: {Description}, Points: {Points}, Completed: {AmountCompleted}/{Target}, Bonus: {Bonus}";
     }
     public override string GetStringRepresentation()
     {
        return $"ChecklistGoal,{ShortName},{Description},{Points},{Target},{Bonus},{AmountCompleted}";
     }

}
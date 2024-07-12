using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }
    public override void RecordEvent()
    {
        Console.WriteLine("Progress recorded for eternal goal. Keep it up!");
    }
    public override bool IsComplete()
    {
        return false; //never complete
    }
    public override string GetDetailsString()
    {
        return $"{ShortName}: {Description}, Points: {Points} (Eternal)";
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal,{ShortName},{Description},{Points}";
    }
}
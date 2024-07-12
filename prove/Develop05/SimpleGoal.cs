using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
public class SimpleGoal : Goal
{
    public bool IsCompleted { get; set; } // Renamed property to avoid conflict

    public SimpleGoal(string shortName, string description, int points, bool isCompleted)
     : base(shortName, description, points)
    {
        ShortName = shortName;
        Description = description;
        Points = points;
        IsCompleted = isCompleted;
    }

    public override void RecordEvent()
    {
        IsCompleted = true;
    }

    public override bool IsComplete() => IsCompleted;

    public override string GetDetailsString()
    {
        return $"[Simple Goal] {ShortName}: {Description} - {Points} points - Completed: {IsCompleted}";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{ShortName}|{Description}|{Points}|{IsCompleted}";
    }
}
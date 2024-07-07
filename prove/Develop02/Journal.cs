using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    public List<Entry> _entries { get; private set; }

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._entryDate}");
            Console.WriteLine($"Prompt: {entry._entryPrompt}");
            Console.WriteLine($"Content: {entry._entryContent}");
            Console.WriteLine();
        }
    }
    public void SaveToFile(string filename)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(_entries, options);
        File.WriteAllText(filename, jsonString);
        Console.WriteLine($"Journal saved to {filename}");
        Console.WriteLine($"Journal saved to {filename}");
    }
    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        if (File.Exists(filename))
        {
            string jsonString = File.ReadAllText(filename);
            _entries = JsonSerializer.Deserialize<List<Entry>>(jsonString);
            Console.WriteLine($"Journal loaded from {filename}");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
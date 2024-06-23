using System;
using System.Collections.Generic;
using System.IO;

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
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // Write the header line
            outputFile.WriteLine("Date,Prompt,Content");
            foreach (Entry entry in _entries)
            {
                // Write each entry as a CSV line
                string csvLine = $"{entry._entryDate},{entry._entryPrompt},{entry._entryContent}";
                outputFile.WriteLine(csvLine);
            }
        }
        Console.WriteLine($"Journal saved to {filename}");
    }
    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            for (int i = 1; i < lines.Length; i++) // Start from 1 to skip the header
            {
                string[] parts = lines[i].Split(',');

                // Handle potential issues with CSV parsing (e.g., commas within fields)
                if (parts.Length == 3)
                {
                    Entry entry = new Entry
                    {
                        _entryDate = parts[0],
                        _entryPrompt = parts[1],
                        _entryContent = parts[2]
                    };
                    _entries.Add(entry);
                }
            }

            Console.WriteLine($"Journal loaded from {filename}");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
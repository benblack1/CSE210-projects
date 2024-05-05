using System;
using System.Xml.Linq;
using System.IO;
using System.Text.Json;


public class Journal{
    public List<Entry> Entries = new List<Entry>();



    public void AddEntry(Entry entry)
    {
        Entries.Add(entry);
    }


    public void DisplayAll()
    {
        foreach(Entry entry in Entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        //And this is where we save the list of entries to a file
        string jsonString = JsonSerializer.Serialize(Entries);
        File.WriteAllText(filename, jsonString);

    }

    public void LoadFromFile(string filename)
    {
        //And this is where we save the file as a list called entries
        string fileContent = File.ReadAllText(filename);

        List<Entry> entries = JsonSerializer.Deserialize<List<Entry>>(fileContent);
        
        Entries.AddRange(entries);
    }
}
using System;
using System.Xml.Linq;

public class Journal{
    public List<Entry> Entries = new List<Entry>();

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
    }

    public void AddEntry(Entry entry)
    {
        Entries.Add(entry);
    }

    public void LoadFromFile(string filename)
    {
        //And this is where we save the file as a list called entries
    }
}
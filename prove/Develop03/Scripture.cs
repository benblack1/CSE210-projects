using System;

public class Scripture
{
    public Reference _reference;

    public Verse _verse;

    public Scripture(Reference reference, Verse verse)
    {
        _reference = reference;
        _verse = verse;
    }

    public Scripture(string reference, string verse)
    {
        _reference = new Reference(reference);
        _verse = new Verse(verse);
    }

    public void HideRandomVerses()
    {
        _verse.HideRandomVerses();
        Console.Clear();
        DisplayScripture();
    }

    public void DisplayScripture()
    {
        Console.Write(_reference.GetDisplayText() + " " + _verse.GetDisplayText());
    }
}
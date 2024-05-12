using System;
using System.Text.RegularExpressions;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public Reference(string reference)
    {
        var match = Regex.Match(reference, @"^(?<book>\D+)\s(?<chapter>\d+):(?<startVerse>\d+)(-(?<endVerse>\d+))?$");

        _book = match.Groups["book"].Value;
        _chapter = int.Parse(match.Groups["chapter"].Value);
        _verse = int.Parse(match.Groups["startVerse"].Value);
        var endVerseGroup = match.Groups["endVerse"];
        if (endVerseGroup.Success)
        {
            _endVerse = int.Parse(endVerseGroup.Value);
        }
        else
        {
            _endVerse = 0;
        }
    }
    public string GetDisplayText()
    {
        if (_endVerse != 0)
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}  :";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}  :";
        }
    }
}
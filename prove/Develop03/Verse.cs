using System;

public class Verse
{
    public List<Word> _words;

    public Verse(List<Word> words)
    {
        _words = words;
    }

    public Verse(string words)
    {
        _words = words.Split(' ').Select(w => new Word(w)).ToList();
    }

    public string GetDisplayText()
    {
        return $"\"{string.Join(" ", _words.Select(w => w.GetDisplayText()))}\"";
    }

    public void HideRandomVerses()
    {
        Random random = new Random();
        List<Word> randomWords = _words.Where(x => !x.IsHidden()).OrderBy(x => random.Next()).Take(2).ToList();

        foreach (Word word in randomWords)
        {
            word.Hide();
        }
    }
}

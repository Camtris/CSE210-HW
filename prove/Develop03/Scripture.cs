using System.ComponentModel.DataAnnotations;
using System.Data;

class Scripture
{
    private string _verse;
    private List<Word> _verseList;
    private int _displayCount;
    private Reference _reference;

    public Scripture(Reference reference, string verse)
    {
        _reference = reference;
        _verseList = new List<Word>();
        _displayCount = 0;
        _verse = verse;
        string[] verseWords = verse.Split(" ");
        foreach(string word in verseWords)
        {
            _verseList.Add(new Word(word));
            _displayCount += 1;
        }
    }
    public string GetVerse()
    {
        return _verse;
    }
    public int GetDisplayCount()
    {
        return _displayCount;
    }

    public string ChangeVerse()
    {
        bool repeat = true;
        int i;
        int len;

        Random random = new();

        if (_displayCount > 0)
        {
            while (repeat == true)
            {
                len = _verseList.Count();
                i = random.Next(len);



                if (_verseList[i].GetWord() == new string('-', _verseList[i].GetWord().Length))
                {
                    repeat = true;
                }
                else
                {
                    _verseList[i].HideWord();
                    _displayCount -= 1;
                    repeat = false;
                }
            }
        }

        _verse = "";
        foreach (Word word in _verseList)
        {
            _verse += word.GetWord() + " ";
        }
        _verse.Trim();
        return _verse;
    }
    public void Display()
    {
        Console.WriteLine($"{_reference.GetReference()} {_verse}");
    }
}
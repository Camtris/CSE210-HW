using System.ComponentModel.DataAnnotations;
using System.Data;

class Scripture
{
    private string _verse;
    private List<Word> _verseList;
    private int _displayCount;
    private Reference _reference;

    // Constructor
    public Scripture(Reference reference, string verse)
    {
        _reference = reference;
        _verseList = new List<Word>();
        _displayCount = 0;
        _verse = verse;
        string[] verseWords = verse.Split(" ");
        foreach (string word in verseWords)
        {
            _verseList.Add(new Word(word));
            _displayCount += 1;
        }
    }
    // Getters
    public string GetVerse()
    {
        return _verse;
    }
    public int GetDisplayCount()
    {
        return _displayCount;
    }
    // Allows the verse to be changed and returned
    public string ChangeVerse()
    {
        bool repeat = true;
        int i;
        int len;

        Random random = new();

        // Creates an exit condition for the loop to end
        if (_displayCount > 0)
        {
            while (repeat == true)
            {
                // Getting a random index to be hidden
                len = _verseList.Count();
                i = random.Next(len);

                // If the word is already hidden then we will restart the loop and get a new index
                if (_verseList[i].GetWord() == new string('_', _verseList[i].GetWord().Length))
                {
                    repeat = true;
                }
                // If the word isn't hidden then we will hide it and end the loop
                else
                {
                    _verseList[i].HideWord();
                    _displayCount -= 1;
                    repeat = false;
                }
            }
        }

        // With the new hidden word we need to update our verse string to be able to display the change
        _verse = "";
        foreach (Word word in _verseList)
        {
            _verse += word.GetWord() + " ";
        }
        _verse.Trim();
        return _verse;
    }
    // Displays our reference and verse together
    public void Display()
    {
        Console.WriteLine($"{_reference.GetReference()} {_verse}");
    }
}
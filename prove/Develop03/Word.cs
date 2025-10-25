class Word
{
    private string _word;

    // Constructor
    public Word(string word)
    {
        _word = word;
    }
    // Getter
    public string GetWord()
    {
        return _word;
    }
    // Finds the length of the word and replaces the entire length with "_"
    public void HideWord()
    {
        int len;
        len = _word.Length;
        _word = new string('_', len);
    }
}
class Word
{
    private string _word;

    public Word(string word)
    {
        _word = word;
    }
    public string GetWord()
    {
        return _word;
    }

    public void HideWord()
    {
        int len;
        len = _word.Length;
        _word = new string('-', len);
    }
}
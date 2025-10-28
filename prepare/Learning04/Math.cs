class Math : Assignment
{
    private string _textbookSection;
    private string _problems;

    public Math(string name, string topic, string section, string problems) : base(name, topic)
    {
        _textbookSection = section;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return "Section: " + _textbookSection + " Problems " + _problems;
    }
}
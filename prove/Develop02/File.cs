class File
{
    public string _fileName;
    public void Save(List<string> list)
    {
        Console.WriteLine("What file would you like to save your journal to? ");
        _fileName = Console.ReadLine();
        using (StreamWriter file = new StreamWriter(_fileName))
        {
            foreach (string journal in list)
            {
                file.WriteLine($"{journal}");
            }
        }
    }

    public List<string> Load(List<string> list)
    {
        Console.WriteLine("What is the name of the file you would like to load? ");
        _fileName = Console.ReadLine();
        string[] entries = System.IO.File.ReadAllLines(_fileName);

        foreach (string entry in entries)
        {
            list.Add(entry);
        }
        return list;
    }
}
public class Resume
{
    public string _name;
    public List<Jobs> _jobs = new List<Jobs>();
    public void Display()
    {
        Console.WriteLine($"Resume of {_name}");
        foreach (Jobs job in _jobs)
        {
            Console.WriteLine($"{job._jobTitle} ({job._company}) {job._startYear}-{job._endYear}");
        }
    }
}
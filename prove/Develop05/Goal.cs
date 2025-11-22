using System.Security.Cryptography.X509Certificates;

abstract class Goal
{
    private string _type;
    private string _name;
    private string _description;
    private int _pts;
    private bool _done;
    public Goal(string type, string name, string description, int pts, bool done)
    {
        _type = type;
        _name = name;
        _description = description;
        _pts = pts;
        _done = done;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public void SetPts(int pts)
    {
        _pts = pts;
    }
    public void SetDone(bool done)
    {
        _done = done;
    }
    public string GetGoalType()
    {
        return _type;
    }
    public bool GetDone()
    {
        return _done;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPts()
    {
        return _pts;
    }
    public abstract void CreateGoal();
    public abstract void Record();
}
class Bin
{
    private string _denomination;

    // Decimal and double do the same but decimal is more precise
    private decimal _value;
    private int _count;

    //Behaviors
    public Bin(string d, decimal v, int c)
    {
        _denomination = d;
        _value = v;
        _count = c;
    }
    // modifier method "Alter" method
    public void Alter(int delta)
    {
        // If we are depositing 3 dollars then delta will = +3
        // If we take 3 dollars out then delta will = -3
        _count += delta;
    }
    public string GetDenomination()
    {
        return _denomination;
    }
    public int GetCount()
    {
        return _count;
    }
}
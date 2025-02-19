public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }

    public abstract void RecordEvent(ref int score);

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string mark = IsComplete() ? "X" : " ";

        return $"[{mark}] {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();
}
public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
        _activity = "Swimming";
    }

    public override double GetDistance()
    {
        return _laps * 0.05;
    }

    public override double GetSpeed()
    {
        return 60 * GetDistance() / _minutes;
    }

    public override double GetPace()
    {
        return _minutes / GetDistance();
    }

    public override double GetCaloriesBurned()
    {
        double MET = 7.0;
        return (MET * 70 * _minutes) / 60;
    }

}
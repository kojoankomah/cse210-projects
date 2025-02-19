public abstract class Activity
{
    protected string _date ;
    protected double _minutes;
    protected string _activity;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
        _activity = "Activity";
    }

    public abstract double GetDistance();

    public abstract double GetCaloriesBurned();

    public abstract double GetSpeed();

    public abstract double GetPace();


    public virtual string GetSummary()
    {
        return $" >> {_date} {_activity} ({_minutes} min) - Distance: {Math.Round(GetDistance(), 2)} km, Speed: {Math.Round(GetSpeed(), 2)} kph, Pace: {Math.Round(GetPace(), 2)} min per km" +
        $"Speed: {Math.Round(GetSpeed(), 2)} kph, Pace: {Math.Round(GetPace(), 2)} min per km, " +
        $"Calories Burned: {Math.Round(GetCaloriesBurned(), 2)} kcal"; ;
    }

}
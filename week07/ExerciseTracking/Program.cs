using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> act = new List<Activity>();

        Running run1 = new Running("22 Feb 2025", 40, 5.5);
        Swimming swim1 = new Swimming("15 Feb 2025", 60, 30);
        Cycling bike1 = new Cycling("10 Feb 2025", 50, 18);
        Running run2 = new Running("22 Feb 2025", 80, 15);
        Swimming swim2 = new Swimming("15 Feb 2025", 60, 30);
        Cycling bike2 = new Cycling("10 Feb 2025", 65, 15);



        act.Add(run1);
        act.Add(swim1);
        act.Add(bike1);
        act.Add(run2);
        act.Add(swim2);
        act.Add(bike2);

        foreach (Activity activity in act)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine("                        =====================================             \n");
        }

        Console.WriteLine();
    }
}
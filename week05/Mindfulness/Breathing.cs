public class Breathing : Activity
{


    public Breathing() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing",10)
    {
        
    }

    public override void Run()
    {
        DisplayStartingMessage();
        DateTime startingTime = DateTime.Now;
        DateTime endingTime = startingTime.AddSeconds(_duration);

        while(DateTime.Now < endingTime)
        {
            Console.WriteLine("Breathe in.... ");
            ShowCountDown(4);
            Console.WriteLine("Breathe Out....");
            ShowCountDown(4);
            Console.Write("\r");
            Console.WriteLine(" ");
        }

        DisplayEndingMessage();

    }
}
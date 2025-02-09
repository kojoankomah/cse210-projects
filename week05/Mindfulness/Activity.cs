public class Activity
{
    private string _name = "";
    private string _description = "";
    protected int _duration = 0;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\nHi! You are welcome to the {_name} activity\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long will you like this session to last?  ");
        _duration = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("All set, get ready...");
        ShowSpinner(4);
        Console.Write("\r");
        Console.WriteLine("");


    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("");
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds");
        Console.WriteLine($"\nGreate Work!");
        ShowCountDown(4);
        Console.Write("\r");
        Console.WriteLine(" ");
    }
    
    public void ShowSpinner(int seconds)
    {
        List<string> animation = new List<string> {"4", "3", "2", "1" };
        for (int x = 0; x < seconds; x++)
        {
            Console.Write(animation[x % animation.Count]);
            Thread.Sleep(1000);
            Console.Write("\b");
        }
        Console.Write("\b");
        Console.Write("");
    }

    public void ShowCountDown(int seconds)
    {
        for(int x = seconds; x >0; x--)
        {
            Console.Write(x);
            Thread.Sleep(1000);
            Console.Write("\r");
            Console.Write("");

        }
    }
    public virtual void Run()
    {
        Console.WriteLine("This activity has no specific implementation.");
    }
}
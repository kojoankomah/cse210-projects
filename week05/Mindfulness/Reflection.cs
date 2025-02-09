public class Reflection : Activity
{

    public Reflection() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",10)
    {

    }
    public override void Run()
    {
        DisplayStartingMessage();
        DateTime startingTime = DateTime.Now;
        DateTime endingTime = startingTime.AddSeconds(_duration);

        List<string> _prompts1 = new List<string>
        {
            "-----What is something you are worried about?",
            "-----Who has had a positive impact on your life recently?",
            "-----What is a challenge you overcame recently?",
            "-----If you could give advice to your past self, what would it be?",
            "-----What is a small moment today that brought you joy?",
            "-----What does success mean to you?",
            "-----How do you usually handle stress, and is there a better way?",
            "-----What is something you want to improve about yourself?",
            "-----If you could relive one day from your past, which day would it be and why?",
            "-----What is a mistake you’ve made that taught you something valuable?",
            "-----What qualities do you value most in a friend?",
            "-----What motivates you to keep going during difficult times?",
            "-----What’s a personal goal you are working toward?",
            "-----How do you want to be remembered?"
        };

        List<string> _prompts2 = new List<string>
        {
            "-----Who can you talk to about this concern?",
            "-----How can you pay this positivity forward to someone else?",
            "-----What did you learn from this experience?",
            "-----What advice would your future self give you now?",
            "-----How can you create more moments like this in the future?",
            "-----Do you feel you are currently on a path to success?",
            "-----What is one habit you could develop to better handle stress?",
            "-----Why do you want to improve this?",
            "-----If you could recreate that experience, how would you do it?",
            "-----If given a chance, would you avoid making that mistake?",
            "-----Has your view on friendship changed over time?",
            "-----Who or what has been a consistent source of encouragement for you?",
            "-----Who can support or guide you in reaching this goal?",
            "-----If someone described you in one sentence, what would you want them to say?"
        };

        List<string> responses = new List<string>();


        while (DateTime.Now < endingTime)
        {
            Console.WriteLine("\nConsider the following prompt: \n");
            Random random = new Random();
            int indexOf = random.Next(_prompts1.Count);
            Console.WriteLine(_prompts1[indexOf]);
            
            Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
            Console.ReadKey();
            Console.WriteLine($"Now ponder on each of the following questions as they related to this experience.\nYou may begin in:");
            // ShowCountDown(5);

            Console.Clear();

            if(DateTime.Now < endingTime)
            {
                while(DateTime.Now < endingTime && _prompts2.Count > 0)
                {
                    indexOf = random.Next(_prompts2.Count);
                    Console.WriteLine(_prompts2[indexOf]);
                    string response = Console.ReadLine();

                    _prompts2.RemoveAt(indexOf);
                    // ShowSpinner(5);
                    responses.Add(response);


                }
            }
        }
        Console.WriteLine($"\nYou gave \"{responses.Count}\" responses");

        DisplayEndingMessage();
    }

}
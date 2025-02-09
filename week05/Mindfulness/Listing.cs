public class Listing : Activity
{
    public Listing() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",10)
    {

    }

    public override void Run()
    {
        DisplayStartingMessage();
        DateTime startingTime = DateTime.Now;
        DateTime endingTime = startingTime.AddSeconds(_duration);

        List <string> questions = new List<string>
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

        List <string> thoughts = new List<string>();

        while (DateTime.Now < endingTime)
        {
            Console.WriteLine("\nConsider the following prompt: \n");
            Random random = new Random();

            int indexOf = random.Next(questions.Count);
            Console.WriteLine(questions[indexOf]);
            Console.WriteLine("");
            Console.WriteLine("List as many responses as you can to the following prompt: \n");

            while (DateTime.Now < endingTime)
            {
                {
                    thoughts.Add(Console.ReadLine());
                    
                }
            }

        }
        Console.WriteLine($"\nYou gave \"{thoughts.Count}\" responses");
        DisplayEndingMessage();

    }
}
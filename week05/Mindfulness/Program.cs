using System;
// To show creativity I added a feature to keep track of how many times an activity was performed
// I also received responses for the reflection activity

class Program
{
    static void Main(string[] args)
    {
        int option = 0;

        do{
            Console.Clear();
            Console.WriteLine("------>>>>TOP<<<<-------\n");
            Console.WriteLine("MENU OPTIONS \n");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflective Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Enter an Option number:  ");
            Console.WriteLine("\n");
            option = Convert.ToInt32(Console.ReadLine());
            Activity selectedActivity = option switch{
                1 => new Breathing(),
                2 => new Listing(),
                3 => new Reflection(),
                _ => null
            };
            if(selectedActivity != null)
            {
                selectedActivity.Run();
            }
        }while(option !=4);
    
    }
}
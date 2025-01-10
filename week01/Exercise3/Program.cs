using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("The magic number is a number between 1 and 100");

        string replay;

        do{
            Random number = new Random();

            int magicNumber = number.Next(1, 100);
            Console.Write("What is your guess?  ");
            string guess = Console.ReadLine();

            int guessCount = 1;

            int guessNumber = int.Parse(guess);

            // Console.WriteLine(magicNumber);


            if(guessNumber == magicNumber){
                Console.WriteLine("You guessed it! ");
                Console.WriteLine($"You made a total guess of {guessCount}");
                Console.Write("Do you want to play again? "); 
                replay = Console.ReadLine().ToLower();
            }
            else{
                while(guessNumber != magicNumber){
                    if(guessNumber < magicNumber)
                    {
                        Console.WriteLine("Higher");
                        Console.Write("What is your guess?  ");
                        guess = Console.ReadLine();
                        guessNumber = int.Parse(guess);

                        guessCount++;


                    }
                    else if(guessNumber > magicNumber)
                    {
                        Console.WriteLine("Lower ");
                        Console.Write("What is your guess?  ");
                        guess = Console.ReadLine();
                        guessNumber = int.Parse(guess);

                        guessCount++;

                    }
                
            }
                Console.WriteLine("You guessed it! ");
                Console.WriteLine($"You made a total guess of {guessCount}");

                Console.Write("Do you want to play again? "); 
                replay = Console.ReadLine().ToLower();
                
            }
        }while(replay == "yes");

    }
}
using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squred = SquareNumber(userNumber);

        DisplayResult(userName, squred);

    }
            static void DisplayWelcome(){
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName(){
            Console.Write("Enter your name : ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber(){
            Console.Write("Enter your favorite number : ");
            int favNumber = int.Parse(Console.ReadLine());
            return favNumber;
        }

        static int SquareNumber(int number){
            int numberSquared =  number*number;
            return numberSquared;
        }
        static void DisplayResult(string name , int numberSquared){
            Console.WriteLine($"{name}, the square of your number is {numberSquared} ");
        }
}
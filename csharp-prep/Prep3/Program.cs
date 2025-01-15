using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {   
        string user_play = "yes";
        while (user_play == "yes" || user_play == "Yes")
        {
            int guess = -1;
            //int secret = 10;
            Random randomGenerator = new Random();
            int secret = randomGenerator.Next(1, 101);
            while (guess != secret)
            {
                Console.WriteLine("Guess a number from 1 - 100");
                Console.Write("Guess: ");
                guess = int.Parse(Console.ReadLine());
                if (guess > secret)
                {
                    Console.WriteLine("too big.");
                }
                else if (guess < secret )
                {
                    Console.WriteLine("too small.");
                }
                else 
                {
                    Console.WriteLine("Great job!!");
                }
            }


        Console.WriteLine("Would you like to play again? Type yes or no");
        user_play = Console.ReadLine();

        }
    }
}
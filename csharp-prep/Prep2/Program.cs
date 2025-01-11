using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please input your final grade: ");
        int grade = int.Parse(Console.ReadLine());//reads input from user and converts to int
        string letter; 


        //conditional logic to determine letter grade
        if (grade <= 100 && grade >= 90)
        {
            letter = "A";
        }
        else if (grade < 90 && grade >= 80)
        {
            letter = "B";
        }
        else if (grade < 80 && grade >= 70)
        {
            letter = "C";
        }
        else if (grade < 70 && grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60 && grade >= 0)
        {
            letter = "F";
        }
        else
        {
            Console.WriteLine("Invalid Score");
            letter = "Z";
            
        }
        if (letter != "Z")
        {
        Console.WriteLine($"You recieved a {letter} in the course!");
        }
        
        //Conditional logic to determine pass/fail
        if (grade >= 70 && grade <= 100)
        {
            Console.WriteLine("Congratualtions! You passed the course!");
        }
        else if (grade < 70 && grade > 0)
        {
            Console.WriteLine("You did not pass the course. Study hard and you'll get it next time!");
        }

    }
}
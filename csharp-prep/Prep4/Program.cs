using System.Collections.Generic;
using System;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a List of numbers, enter 0 to quit.");
        int user_num = -1;
        int sum = 0;
        int largest_num = -500000000;
        while (user_num != 0)
        {
            user_num = int.Parse(Console.ReadLine());
            if (user_num != 0)
            {
                Console.Write("Enter a number:");
                numbers.Add(user_num);
            }
        }
        for (int i = 0; i < numbers.Count; i++)
        {
            sum = sum + numbers[i];
            //Console.WriteLine(sum);
            if (numbers[i]> largest_num)
            {
                largest_num = numbers[i];
            }
        }
        Console.WriteLine($"The total is {sum}");
        Console.WriteLine($"The average is {sum/numbers.Count}");
        Console.WriteLine($"The largest number is {largest_num}");

    }
}
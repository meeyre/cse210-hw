using System;

class Program
{

    static void print_wel()
    {
        Console.WriteLine("WELCOME TO THE PROGRAM!");
    }

    static string get_name()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        return name;
    }

    static int get_fav_num()
    {
        Console.WriteLine("What is your favorite number??");
        int num = int.Parse(Console.ReadLine());
        return num;
    }

    static void print_name_y_sqnum(string name, int number)
    {
        Console.WriteLine($"Hello {name}, your squared number is {number*number}");
    }

    static void Main(string[] args)
    {
        print_wel();
        print_name_y_sqnum(get_name(), get_fav_num());
    }

}
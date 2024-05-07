using System;

class Program
{
    static void Main(string[] args)
    {
        // User is been ask of there name 
        Console.Write("What is your first name? ");
        String first = Console.ReadLine();

        Console.Write("What is your last name? ");
        String last = Console.ReadLine();

        Console.WriteLine($"Your name is {first} {last}");

        
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        /*This is prep 2. 
        With the conditional statement*/

        {
            Console.Write("What is your grade percentage? ");
            string userAnswer = Console.ReadLine();
            int percentage = int.Parse(userAnswer);

            string letter = "";
            
            if ( percentage >= 100)
            {
                letter = "A+"
            }
            else if (percentage >= 95)
            {
                letter = "A-"
            }
            else if (percentage >= 90)
            {
                letter = "A";

            }
            else if (percentage >= 80)
            {
                letter = "B";
            }
            else if (percentage >= 70)
            {
                letter = "c";
            }
            else if (percentage >= 60)
            {
                letter = "D";
            }
            else 
            {
                letter = "F";
            }

            {
                Console.WriteLine($"Your grade is letter: {letter}");

                if (percentage >= 70)
                {
                    Console.WriteLine(" Congrtulation! You passed");
                } 
                else
                {
                    Console.WriteLine("Best of luck next time");
                }
            }
        



        



            
        }
        


        
    }
}
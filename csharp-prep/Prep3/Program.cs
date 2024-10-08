using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)

    {
        string decision = "yes";
       
        int guess = -1;
        while (decision == "yes" )
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            while (guess != number)
            {
                Console.Write("What is the magic number?");
                string sAttempt = Console.ReadLine();
                int attempt = int.Parse(sAttempt);
                if (attempt > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (attempt < number)

                {
                    Console.WriteLine("Higher)");
                   
                }
                else
                {
                    Console.WriteLine(" You guessed it!");
                    Console.WriteLine("Do you want to keep playing?");
                    decision = Console.ReadLine();
                    break;
                }
            }




        }
    }

}
using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the percentage of the note?");
        string porcen = Console.ReadLine();
        int porcenIn = int.Parse(porcen);

        string letter = "";

        string sinal = "";
        if (porcenIn >= 90)
        {
            letter = "A";
        }
        else if (porcenIn >= 80 && porcenIn < 90)
        {
            letter = "B";
        }
        else if (porcenIn >= 70 && porcenIn < 80)
        {
            letter = "C";
        }
        else if (porcenIn >= 60 && porcenIn < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string textVersion = porcenIn.ToString();
        string help = textVersion.Substring(1, 1);
        int secon = int.Parse(help);
        int porcenTotal = int.Parse(textVersion);

        if (porcenTotal > 60 && porcenTotal < 90)
        {
            if (secon >= 7)
            {
                sinal = "+";

            }
            else if (secon < 3)
            {
                sinal = "-";
            }
            else
            {
                sinal = "";

            }
        }

        if (porcenTotal >= 70)
        {
            Console.WriteLine($"Congratulations, you've passed your grade:{letter}{sinal}");
        }
        else
        {
            Console.WriteLine($"your grade is:{letter}");
        }
    }
}


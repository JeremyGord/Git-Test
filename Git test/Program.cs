//Jeremy Gordon
//1/18/2023
//CW2 getting into git
//Classwork to practice using git pushing and pulling repositories.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_test
{
    class Program
    {
        static void Main(string[] args)
        {
                       Console.Write("Input the First Number: ");
            int StartingNumb = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Second Number: ");
            int EndNumber = Convert.ToInt32(Console.ReadLine());

            while (StartingNumb >= EndNumber - 1)
            {
                Console.Write("Please select another starting number. The starting Number can't be greater than or equal to the ending number - 1: ");
                StartingNumb = Convert.ToInt32(Console.ReadLine());
                Console.Write("The ending Number can't be less than the starting number: ");
                EndNumber = Convert.ToInt32(Console.ReadLine());
            }

            int RndmNUM = new Random().Next(StartingNumb + 1, EndNumber - 1);
            int NmbOfAttempts = 1;
            Console.WriteLine("Please enter a number from " + StartingNumb + " to " + EndNumber);
            int guess = GetGuess();
            string choice = "";


            while (guess != RndmNUM)
            {
                NmbOfAttempts++;

                if (guess > RndmNUM)
                {
                    Console.WriteLine("Your guess is too high");
                    Console.WriteLine("Please enter a number from " + StartingNumb + " to " + EndNumber);
                    guess = GetGuess();
                }

                if (guess < RndmNUM)
                {
                    Console.WriteLine("Your guess is too low");
                    Console.WriteLine("Please enter a number from " + StartingNumb + " to " + EndNumber);
                    guess = GetGuess();
                }
            }
            Console.WriteLine($"Number of Attempts: {NmbOfAttempts}");
            Console.WriteLine("Your guess is Right!");
            while (choice == "")
            {
                Console.WriteLine("Enter any key to exit");
                choice = Convert.ToString(Console.ReadLine());
            }
        }


        private static int GetGuess()
        {
            int guess = 0;
            guess = Convert.ToInt32(Console.ReadLine());
            return guess;
        }
    }
}

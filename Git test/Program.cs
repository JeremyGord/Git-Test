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

            int RndmNUM = new Random().Next(StartingNumb, EndNumber);
            int NmbOfAttempts = 0;
            Console.WriteLine("Please enter a number from " + StartingNumb + " to " + EndNumber);

            while (true)
            {
                int guess = GetGuess();
                NmbOfAttempts++;
                if (guess == RndmNUM)
                {
                    Console.WriteLine($"Number of Attempts: {NmbOfAttempts}");
                    Console.WriteLine("Your guess is Right!");
                    System.Threading.Thread.Sleep(2300);
                    break;

                }
                if (guess > RndmNUM)
                {
                    Console.WriteLine("Your guess is too high");
                }
                if (guess < RndmNUM)
                {
                    Console.WriteLine("Your  guess is too low");
                }

            }
        }


        private static int GetGuess()
        {
            int guess = 0;
            try
            {
                guess = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please Enter a whole number between 1 and 100");
                GetGuess();
            }
            return guess;

        }
    }
}

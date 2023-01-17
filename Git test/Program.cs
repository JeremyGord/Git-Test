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
            int RndmNUM = new Random().Next(0, 100);
            Console.Write("I am thinking of a number between 0 and 100");
            int NmbOfAttempts = 0;

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

using System;
using System.Diagnostics.Metrics;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MySolution();
            if (IsPrimeNumber(11))
            {
                Console.WriteLine("Number is prime");
            }
            else
            {
                Console.WriteLine("Number is not prime");
            }
        }

        private static bool IsPrimeNumber(int number) 
        {
            for (int i = 2; i < number-1; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true; 
        }

        private static void MySolution()
        {
            int sayi = 11;
            int counter = 0;
            for (int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    counter++;
                }
            }

            if (counter == 2)
            {
                Console.WriteLine("sayı asal.");
            }
            else
            {
                Console.WriteLine("sayı asal değil.");
            }
        }
    }
}
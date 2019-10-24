using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int numberOfFibonacciNumbers = random.Next(1, 100);
            Console.WriteLine("Количество чисел: " + numberOfFibonacciNumbers);

            long[] FibonacciNumbers = new long[numberOfFibonacciNumbers];
            FibonacciNumbers[0] = 0;
            FibonacciNumbers[1] = 1;

            for (int i = 2; i < numberOfFibonacciNumbers; i++)
            {
                FibonacciNumbers[i] = FibonacciNumbers[i - 2] + FibonacciNumbers[i - 1];
            }

            for (int i = 0; i < numberOfFibonacciNumbers; i++)
            {
                Console.Write(FibonacciNumbers[i] + "  ");
            }
            Console.WriteLine();
        }
    }
}

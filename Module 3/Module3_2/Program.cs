using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int numberOfNaturalNumbers = random.Next(1, 100);
            Console.WriteLine("Число: " + numberOfNaturalNumbers);

            int[] evenNaturalNumbers = new int[numberOfNaturalNumbers / 2 + 1];

            Console.Write("Четные натуральные числа: ");

            for (int number = 0, i = 0; number < numberOfNaturalNumbers + 1; number++)
            {
                if (number % 2 == 0)
                {
                    evenNaturalNumbers[i] = number;
                    Console.Write(evenNaturalNumbers[i] + " ");
                    i++;
                }
            }
            Console.WriteLine();
        }
    }
}

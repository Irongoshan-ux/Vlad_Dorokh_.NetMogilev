using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int arrayLength = int.Parse(Console.ReadLine());

            int[] arrayOfNumbers = new int[arrayLength];

            Random random = new Random();

            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] = random.Next(-1000, 1000);
                Console.Write(arrayOfNumbers[i] + " ");
            }

            Console.WriteLine("\n\nЧисла, большие стоящих перед ними:");

            for (int i = 1; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] > arrayOfNumbers[i - 1])
                {
                    Console.Write(arrayOfNumbers[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}

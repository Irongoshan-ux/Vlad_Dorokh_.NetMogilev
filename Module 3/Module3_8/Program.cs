using System;

namespace Module3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTask();
            SecondTask();
        }

        static double Function(double x)
        {
            return Math.Pow(x, 3) - Math.Cos(x);
        }

        static void FirstTask()
        {
            double accuracy = 0.0001;
            double a = 0.5, b = 1;

            Console.WriteLine($"Концы отрезков: {a}; {b}");
            Console.WriteLine("Значение точности: " + accuracy);

            double x;
            do
            {
                x = (a + b) / 2;
                if (Function(x) * Function(a) > 0)
                {
                    a = x;
                }
                else
                {
                    b = x;
                }
            }
            while ((b - a) > accuracy);

            Console.WriteLine("Решение уравнения: " + x + "\n");
        }
        static void SecondTask()
        {
            Console.Write("Введите размерность массива NxN: ");
            int arrayLength = int.Parse(Console.ReadLine());

            int i = 0, j, k = 0, number = 1;

            int[,] arrayOfNumbers = new int[arrayLength, arrayLength];

            while (i < arrayOfNumbers.Length)
            {
                for (j = k; j < arrayLength - k; j++)
                {
                    i++;
                    arrayOfNumbers[k, j] = number;
                    number++;
                }

                for (j = k + 1; j < arrayLength - k; j++)
                {
                    i++;
                    arrayOfNumbers[j, arrayLength - k - 1] = number;
                    number++;
                }

                for (j = arrayLength - k - 2; j >= k; j--)
                {
                    i++;
                    arrayOfNumbers[arrayLength - k - 1, j] = number;
                    number++;
                }

                for (j = arrayLength - k - 2; j > k; j--)
                {
                    i++;
                    arrayOfNumbers[j, k] = number;
                    number++;
                }

                k++;
            }

            for (i = 0; i < arrayLength; i++)
            {
                for (j = 0; j < arrayLength; j++)
                {
                    Console.Write("{0,6} ", arrayOfNumbers[i, j]);
                }

                Console.WriteLine();
            }
        }

    }
}
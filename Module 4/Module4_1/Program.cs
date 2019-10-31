using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] values = new int[10];

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = random.Next(-100, 100);
                Console.Write(values[i] + " ");
            }

            int maxValue = FindMaxValueOfArray(values);
            int minValue = FindMinValueOfArray(values);
            int sum = FindSumOfArrayValues(values);
            int differenceOfMaxAndMinValues = FindDifferenceOfMaxAndMinArrayValues(values);

            Console.WriteLine($"\nМаксимум: {maxValue}\nМинимум: {minValue}\nСумма всех элементов: {sum}\nРазность максимального и минимального: {differenceOfMaxAndMinValues}");

            ChangeValuesOfArrayToMaxAndMin(values);

            Console.WriteLine("Массив после увеличения четных элементов на максимум и уменьшения нечетных на минимум:");

            for (int i = 0; i < values.Length; i++)
            {
                Console.Write(values[i] + " ");
            }

            Console.WriteLine();
        }

        static void ChangeValuesOfArrayToMaxAndMin(int[] array)
        {
            int max = FindMaxValueOfArray(array);
            int min = FindMinValueOfArray(array);

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    array[i] += max;
                }
                else if (array[i] % 2 != 0)
                {
                    array[i] -= min;
                }
            }
        }

        static int FindDifferenceOfMaxAndMinArrayValues(int[] array)
        {
            return FindMaxValueOfArray(array) - FindMinValueOfArray(array);
        }

        static int FindSumOfArrayValues(int[] array)
        {
            int sum = 0;

            for(int i=0; i<array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        static int FindMaxValueOfArray(int[] array)
        {
            int max = array[0];

            for (int i=1; i<array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        static int FindMinValueOfArray(int[] array)
        {
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }
    }
}

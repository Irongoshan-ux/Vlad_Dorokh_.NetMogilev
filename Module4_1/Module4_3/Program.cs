using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] values = new int[10];

            Console.Write("Values of array: ");
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = random.Next(-10, 10);
                Console.Write(values[i] + " ");
            }

            FindMinAndMaxValuesOfArrayAndSumOfArrayElements(values, out int maxValue, out int minValue, out int sumOfArrayElements);

            Console.WriteLine($"\n Max value: {maxValue} \n Min value: {minValue} \n Sum of array elements: {sumOfArrayElements}");

            int firstValue = random.Next(-10, 10), secondValue = random.Next(-10, 10), thirdValue = random.Next(-10, 10);

            IncreaseValuesByTen(ref firstValue, ref secondValue, ref thirdValue);

            double radius = 2 * Math.PI;

            GetSquareAndLengthOfCircle(radius, out double circleSquare, out double circleLength);

            Console.WriteLine($"Values after adding ten: {firstValue}, {secondValue}, {thirdValue}");
            Console.WriteLine($"Square and length of circle: {circleSquare}, {circleLength}");
        }

        static void IncreaseValuesByTen(ref int firstValue, ref int secondValue, ref int thirdValue)
        {
            firstValue += 10;
            secondValue += 10;
            thirdValue += 10;
        }

        static void GetSquareAndLengthOfCircle(double radius, out double square, out double length)
        {
            square = Math.PI * Math.Pow(radius, 2);
            length = 2 * Math.PI * radius;
        }

        static void FindMinAndMaxValuesOfArrayAndSumOfArrayElements(int[] array, out int maxValue, out int minValue, out int sum)
        {
            maxValue = array[0];
            minValue = array[0];
            sum = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }

                if (array[i] < minValue)
                {
                    minValue = array[i];
                }

                sum += array[i];
            }
        }
    }
}
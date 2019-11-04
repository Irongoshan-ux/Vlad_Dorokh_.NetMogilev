using System;

namespace Module4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindMaxAndMinValuesOfArrayAndSumOfArrayElements(new int[] { 3, 4, 8, 0 }));

            var (square, length) = GetSquareAndLengthOfCircle(2 * Math.PI);

            Console.WriteLine($"Площадь и длина круга: {square}; {length}");

            var (firstValue, secondValue, thirdValue) = IncreaseValuesByTen(19, -18, 108);

            Console.WriteLine($"Значения после увеличения их на десять: {firstValue}, {secondValue}, {thirdValue}");
        }

        static (int, int, int) FindMaxAndMinValuesOfArrayAndSumOfArrayElements(int[] array)
        {
            int maxValue = array[0];
            int minValue = array[0];
            int sum = 0;

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

            return (minValue, maxValue, sum);
        }

        static (double, double) GetSquareAndLengthOfCircle(double radius)
        {
            double square = Math.PI * Math.Pow(radius, 2);
            double length = 2 * Math.PI * radius;

            var result = (square, length);
            return result;
        }

        static (int, int, int) IncreaseValuesByTen(int firstValue, int secondValue, int thirdValue)
        {
            var result = (firstValue += 10, secondValue += 10, thirdValue += 10);
            return result;
        }
    }
}
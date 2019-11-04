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
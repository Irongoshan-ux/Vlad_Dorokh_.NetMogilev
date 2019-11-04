using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] firstArray = new int[10];
            int[] secondArray = new int[15];

            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = random.Next(-10, 10);
                Console.Write(firstArray[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = random.Next(-10, 10);
                Console.Write(secondArray[i] + " ");
            }

            Console.WriteLine();

            int[] sumOfArrays = AddTwoArrays(firstArray, secondArray);

            for (int i = 0; i < sumOfArrays.Length; i++)
            {
                Console.Write(sumOfArrays[i] + " ");
            }
        }

        static int[] AddTwoArrays(int[] firstArray, int[] secondArray)
        {
            if (firstArray.Length > secondArray.Length)
            {
                int[] sumOfArrays = new int[firstArray.Length];

                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (i < secondArray.Length)
                    {
                        sumOfArrays[i] = firstArray[i] + secondArray[i];
                    }
                    else if (i >= secondArray.Length)
                    {
                        sumOfArrays[i] = firstArray[i];
                    }
                }

                return sumOfArrays;
            }

            else if (firstArray.Length < secondArray.Length)
            {
                int[] sumOfArrays = new int[secondArray.Length];

                for (int i = 0; i < secondArray.Length; i++)
                {
                    if (i < firstArray.Length)
                    {
                        sumOfArrays[i] = firstArray[i] + secondArray[i];
                    }
                    else if (i >= firstArray.Length)
                    {
                        sumOfArrays[i] = secondArray[i];
                    }
                }

                return sumOfArrays;
            }

            else return firstArray;
        }

        static string AddTwoStringValues(string firstValue, string secondValue)
        {
            return firstValue + secondValue;
        }

        double AddThreeDoubleValues(double firstValue, double secondValue, double thirdValue)
        {
            return firstValue + secondValue + thirdValue;
        }

        static int AddTwoIntValues(int firstValue, int secondValue)
        {
            return firstValue + secondValue;
        }

        static int AddThreeIntValues(int firstValue, int secondValue, int thirdValue)
        {
            return firstValue + secondValue + thirdValue;
        }
    }
}

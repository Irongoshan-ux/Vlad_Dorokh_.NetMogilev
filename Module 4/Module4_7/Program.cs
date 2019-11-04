using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            bool choiceOfSortDirection;

            if (random.Next(100) <= 50)
            {
                choiceOfSortDirection = true;
                Console.WriteLine("Сортировка по возрастанию");
            }
            else
            {
                choiceOfSortDirection = false;
                Console.WriteLine("Сортировка по убыванию");
            }

            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-20, 20);
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

            SortArray(numbers, choiceOfSortDirection);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }

        static void SortArray(int[] array, bool inAscendingOrder)
        {
            if (inAscendingOrder == true)
            {
                int temp;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] > array[j])
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
            }
            else if (inAscendingOrder == false)
            {
                int temp;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] < array[j])
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество чисел в массиве: ");
            int arrayLength = int.Parse(Console.ReadLine());

            Random random = new Random();

            int[] array = new int[arrayLength];

            Console.WriteLine("Исходный массив: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-1000, 1000);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\n\nПосле изменения знаков:");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= -1;

                Console.Write(array[i] + " ");
            }
        }
    }
}

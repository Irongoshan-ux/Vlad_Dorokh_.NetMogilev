﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] values = new int[random.Next(5, 15)];

            Console.Write("Элементы массива: ");
            for(int i=0; i < values.Length; i++)
            {
                values[i] = random.Next(-10, 10);
                Console.Write(values[i] + " ");
            }

            Console.Write("\nЭлементы массива, увеличенные на пять: ");

            EncreaseArrayElementsByFive(values);

            for (int i = 0; i < values.Length; i++)
            {
                Console.Write(values[i] + " ");
            }
        }

        static void EncreaseArrayElementsByFive(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 5;
            }
        }
    }
}

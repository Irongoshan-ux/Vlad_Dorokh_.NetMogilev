using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string value = Console.ReadLine();

            double invertedNumber;

            if ((double.TryParse(value, out double number)) && (number >= 0))
            {
                invertedNumber = FlipNumber(value);

                Console.WriteLine("Перевернутое число: " + invertedNumber);
            }
            else if (number < 0)
            {
                value = Math.Abs(number).ToString();

                invertedNumber = FlipNumber(value) * -1;

                Console.WriteLine("Перевернутое число: " + invertedNumber);
            }
            else
            {
                Console.WriteLine("Ошибка ввода.");
            }
        }

        static double FlipNumber(string value)
        {
            StringBuilder reverseDigitsOfNumber = new StringBuilder
            {
                Length = value.Length
            };

            for (int i = 0; i < value.Length; i++)
            {
                reverseDigitsOfNumber[i] = value[value.Length - 1 - i];
            }

            return double.Parse(reverseDigitsOfNumber.ToString());
        }
    }
}
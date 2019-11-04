using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            do
            {
                Console.Write("Введите натуральное число: ");
                number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    Console.WriteLine("Введено ненатуральное число");
                    continue;
                }
            }
            while (number < 0);

            int[] numberInDigits = GetDigitsArrayFromNumber(number);

            for (int i = 0; i < numberInDigits.Length; i++)
            {
                Console.Write(numberInDigits[i] + "");
            }

            Console.WriteLine();

            int deleteNumber;
            do
            {
                Console.Write("Введите цифру, которую необходимо удалить из числа: ");
                deleteNumber = int.Parse(Console.ReadLine());

                if ((deleteNumber < 0) || (deleteNumber > 9))
                {
                    Console.WriteLine("Введена неверная цифра.");
                }
            }
            while ((deleteNumber < 0) || (deleteNumber > 9));

            int[] newNumber = new int[numberInDigits.Length];

            int countOfDeleteDigitsFromNumber = 0;

            for (int i = 0; i < numberInDigits.Length; i++)
            {
                if (numberInDigits[i] == deleteNumber)
                {
                    countOfDeleteDigitsFromNumber++;
                }
            }

            if (countOfDeleteDigitsFromNumber > 0)
            {
                Console.Write("Полученное число: ");
                for (int i = 0, j = 0; i < newNumber.Length; i++)
                {
                    if (numberInDigits[i] == deleteNumber)
                    {
                        continue;
                    }
                    else
                    {
                        newNumber[j] = numberInDigits[i];
                        Console.Write(newNumber[j]);
                        j++;
                    }
                }
                Console.WriteLine();
            }
            else Console.WriteLine("Число не содержит удаляемую цифру.");
        }

        static int[] GetDigitsArrayFromNumber(int number)
        {
            int lengthOfNumber = number.ToString().Length;

            int[] numbers = new int[lengthOfNumber];

            for (int i = 0; i < lengthOfNumber; i++)
            {
                numbers[i] = number % 10;
                number /= 10;
            }

            for (int i = 0, j = lengthOfNumber - 1; i < j; i++, j--)
            {
                int temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;
            }

            return numbers;
        }
    }
}

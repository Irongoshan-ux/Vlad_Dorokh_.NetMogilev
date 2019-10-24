using System;
using System.Globalization;

namespace Module2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] resultsOfConversion = new bool[2] { false, false };
            double firstNumber, secondNumber;
            
            do
            {
                Console.Write("Введите первое число: ");
                resultsOfConversion[0] = TryGetDouble(Console.ReadLine(), out firstNumber);

                Console.Write("Введите второе число: ");
                resultsOfConversion[1] = TryGetDouble(Console.ReadLine(), out secondNumber);

                if ((resultsOfConversion[0] == false) || (resultsOfConversion[1] == false))
                {
                    Console.WriteLine("Ошибка ввода.");
                    continue;
                }                
            }
            while ((resultsOfConversion[0] == false) || (resultsOfConversion[1] == false));

            SwapTwoValues(ref firstNumber, ref secondNumber);

            Console.WriteLine(firstNumber + ", " + secondNumber);
        }

        public static void SwapTwoValues(ref double firstNumber, ref double secondNumber)
        {
            firstNumber += secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber -= secondNumber;
        }

        public static bool TryGetDouble(string value, out double number)
        {
            value = value.Trim(new char[] { '(', ')', ' ' });

            NumberFormatInfo userFormatSettings = new NumberFormatInfo();

            if (!double.TryParse(value, NumberStyles.Float, userFormatSettings, out number))
            {
                if (userFormatSettings.NumberDecimalSeparator == ",")
                {
                    userFormatSettings.NumberDecimalSeparator = ".";
                }

                else if (userFormatSettings.NumberDecimalSeparator == ".")
                {
                    userFormatSettings.NumberDecimalSeparator = ",";
                }

                if (!double.TryParse(value, NumberStyles.Float, userFormatSettings, out number))
                {
                    return false;
                }
                else return true;
            }
            else return true;
        }
    }
}

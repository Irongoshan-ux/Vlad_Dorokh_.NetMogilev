using System;

namespace Module3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int firstNumber = random.Next(-10000, 10000);
            int secondNumber = random.Next(-10000, 10000);

            Console.WriteLine($"Перемножаемые числа: {firstNumber}, {secondNumber}");

            Console.WriteLine("Результат умножения: " + MultiplyTwoNumbers(firstNumber, secondNumber));
        }

        static int MultiplyTwoNumbers(int firstNumber, int secondNumber)
        {
            int resultOfMultiplication = 0;

            if ((firstNumber < 0) && (secondNumber > 0))
            {
                for (int i = 0; i < secondNumber; i++)
                {
                    resultOfMultiplication += firstNumber;
                }
            }

            if ((firstNumber > 0) && (secondNumber < 0))
            {
                for (int i = 0; i < firstNumber; i++)
                {
                    resultOfMultiplication += secondNumber;
                }
            }

            if (((firstNumber > 0) && (secondNumber > 0)) || ((firstNumber < 0) && (secondNumber < 0)))
            {
                for (int i = 0; i < Math.Abs(secondNumber); i++)
                {
                    resultOfMultiplication += Math.Abs(firstNumber);
                }
            }

            if ((firstNumber == 0) || (secondNumber == 0))
            {
                resultOfMultiplication = 0;
            }

            return resultOfMultiplication;
        }
    }
}

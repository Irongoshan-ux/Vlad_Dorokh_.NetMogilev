using System;
using System.Globalization;

namespace Module2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool resultOfConversion;
            int numberOfCompanies, earningOfCompany = 500;
            double percentageOfStateTax = 0;

            do
            {
                resultOfConversion = TryIntParse("Введите количество компаний: ", out numberOfCompanies);
                if (resultOfConversion == false)
                {
                    Console.WriteLine("Введено неверное количество компаний.");
                    continue;
                }

                resultOfConversion = TryDoubleParse("Введите значение государственного налога: ", out percentageOfStateTax);
                if (resultOfConversion == false)
                {
                    Console.WriteLine("Введено неверное значение государственного налога.");
                    continue;
                }
            }
            while ((resultOfConversion == false) || (numberOfCompanies < 0) || (percentageOfStateTax < 0));

            Console.WriteLine("Суммарный налог государству: " + CalculateStateTax(numberOfCompanies, earningOfCompany, percentageOfStateTax));
        }

        public static bool TryDoubleParse(string message, out double value)
        {
            bool resultOfParse;

            Console.WriteLine(message);

            resultOfParse = double.TryParse(Console.ReadLine(), out value);

            if (resultOfParse == false)
            {
                Console.WriteLine("Ошибка ввода.");
                return false;
            }
            else return true;
        }

        public static bool TryIntParse(string message, out int value)
        {
            bool resultOfParse;

            Console.WriteLine(message);

            resultOfParse = int.TryParse(Console.ReadLine(), out value);

            if (resultOfParse == false)
            {
                Console.WriteLine("Ошибка ввода.");
                return false;
            }
            else return true;
        }

        static double CalculateStateTax(int numberOfCompanies, int earningOfCompany, double percentageOfStateTax)
        {
            return numberOfCompanies * earningOfCompany * percentageOfStateTax / 100;
        }
    }
}

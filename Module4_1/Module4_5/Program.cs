using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Математическая операция: " + MathOperation(-4, 14, MathematicalOperation.Add));

            Console.WriteLine($"Количество дней в месяце {Months.February} 2020 года: {GetDaysOfMonth(Months.February, 2020)}");
        }

        static int GetDaysOfMonth(Months month, int year)
        {
            int MonthNumber = (int)month;
            int leap = (1 - (year % 4 + 2) % (year % 4 + 1)) * ((year % 100 + 2) % (year % 100 + 1)) + (1 - (year % 400 + 2) % (year % 400 + 1));

            return 28 + ((MonthNumber + (MonthNumber / 8)) % 2) + 2 % MonthNumber + ((1 + leap) / MonthNumber) + (1 / MonthNumber) - (leap / MonthNumber);
        }

        static double MathOperation(double firstValue, double secondValue, MathematicalOperation operation)
        {
            double result = 0.0;

            if (operation == MathematicalOperation.Add)
            {
                result = firstValue + secondValue;
            }
            else if (operation == MathematicalOperation.Subtract)
            {
                result = firstValue - secondValue;
            }
            else if (operation == MathematicalOperation.Multiply)
            {
                result = firstValue * secondValue;
            }
            else if (operation == MathematicalOperation.Divide)
            {
                result = firstValue / secondValue;
            }

            return result;
        }
    }

    enum MathematicalOperation
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }

    enum Months
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
}
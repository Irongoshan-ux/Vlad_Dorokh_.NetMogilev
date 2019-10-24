using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool result = false;

            do
            {
                Console.Write("Введите целое число N: ");
                result = int.TryParse(Console.ReadLine(), out number);

                if (result == false)
                {
                    Console.WriteLine("Введено не целое число.");
                }
            }
            while (!result);

            if ((number >= 18) && (CheckParity(number) == 0))
            {
                Console.WriteLine("Поздравляем с совершеннолетием!");
            }
            else if ((number > 13) && (number < 18) && (CheckParity(number) == 1))
            {
                Console.WriteLine("Поздравляем с переходом в старшую школу!");
            }
            else Console.WriteLine("Простите, для Вас пока ничего нет :(");            
        }        

        static int CheckParity(int number)
        {
            return number % 2;
        }
    }
}

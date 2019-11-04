using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DividingSegmentInHalf(0.5, 1, 0.0001));
        }
        static double Function(double x)
        {
            return Math.Pow(x, 3) - Math.Cos(x);
        }

        static double DividingSegmentInHalf(double a, double b, double accuracy)
        {
            double x = (a + b) / 2;

            if ((Function(b) - Function(a) <= accuracy) || (Math.Abs(Function(x)) <= accuracy))
            {
                return (a + b) / 2;
            }
            if (Function(a) * Function(x) > 0)
            {
                return DividingSegmentInHalf(x, b, accuracy);
            }
            else
            {
                return DividingSegmentInHalf(a, x, accuracy);
            }
        }
    }
}

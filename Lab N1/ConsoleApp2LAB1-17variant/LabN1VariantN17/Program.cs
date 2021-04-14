using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabN1VariantN17
{
    class Program
    {
        static void Main(string[] args)
        {
            double ans = Calculate(0.000001d, 64, 4);
            Console.WriteLine($"{ans}");
            Console.ReadLine();
        }

        static double Calculate(double precision, double a, int n)
        {
            double xk = a / 3d;
            double xk1;
            do
            {
                xk1 = 1d / n * ((n - 1) * xk + a / Math.Pow(xk, n - 1));
                xk = xk1;
            }
            while (Math.Abs(Math.Pow(xk1, n) - a) > precision);
            return xk1;
        }

    }
}

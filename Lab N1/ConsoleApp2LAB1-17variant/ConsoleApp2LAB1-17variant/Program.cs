using System;

namespace ConsoleApp2LAB1_17variant
{
    class Program
    {
        static decimal Fact (decimal value)
        {
            return (value == 0) ? 1 : value * Fact(value - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите значение k");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("Укажите значение x");
            double x = double.Parse(Console.ReadLine());
            double result = 0;

            for (int n = 0; n <= k; n++)
                
                result += Math.Pow(-1, n) * Math.Pow(x, (4 * n) + 3) / ((2 * n) + 1) * ((4 * n) + 3);


            Console.WriteLine("Результат = {0}", result.ToString());
            Console.ReadKey();
        }
    }
}

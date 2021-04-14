using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB317
{
    class Rectangle // Класс в котором мы объявляем переменные A и В 
    {
        double a;
        double b;
        public Rectangle(double a = 0, double b = 0)
        {
            this.a = a;
            this.b = b;
           
        }
        public double Perimetr() // Формула периметра 
        {
            double perimeter = a * 2 + b * 2;
            return perimeter;
        }
        public double Ploshad() // Формула площади
        {
            double ploshad = a * b;
            return ploshad;
        }

        
    }
    class Program     // Стандартный класс для ввода и вывода на консоль
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Введите длинну стороны A: ");
            double a = Int32.Parse(Console.ReadLine());
            Console.Write("Введите длинну сторону B: ");
            double b = Int32.Parse(Console.ReadLine());
            Rectangle rect = new Rectangle(a, b);
            Console.WriteLine();

            Console.WriteLine("Периметр = {0}", rect.Perimetr());
            Console.WriteLine("Площадь = {0}", rect.Ploshad());
            Console.WriteLine();

            Console.WriteLine("Так выглядит наш прямоугольник:");
            Console.WriteLine();

            for (int j = 0; j < a; j++) // Рисует прямоугольник из символов ) 
            {
                for (int i = 0; i < b; i++)
                {
                    Console.Write("†");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

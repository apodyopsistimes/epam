using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LAB4VECTOR3D
{
    public class Program
    {
        static void Main(string[] args) 
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Vector3d a = new Vector3d(EnterValuesForVector3D());
            Vector3d b = new Vector3d(EnterValuesForVector3D());
            Vector3d sum = a + b;
            Vector3d minus = a - b;
            Vector3d multiplication = a * b;
            print("Сложение: ", sum);
            print("Разность: ", minus);
            print("Умножение: ", multiplication);
            print2("xx+yy+zz", multiplication);
            Console.ReadKey();
        }
        static void print(string s, Vector3d v)
        {           
            Console.Write(s + "\n");
            Console.WriteLine(" Координатa Х: " + v.x);
            Console.WriteLine(" координатa Y: " + v.y);
            Console.WriteLine(" координатa Z: " + v.z );
            
        }
        static void print2(string s, Vector3d v)
        {
            Console.WriteLine("Умножение A * B = x1*x2 + y1*y2 + z1*z2 = " + (v.x + v.y + v.z));
        }
      
        public static (double x, double y, double z) EnterValuesForVector3D()
        {

            (double x, double y, double z) values;
            Console.Write("Введите значение координаты Х: ");
            double.TryParse(Console.ReadLine(), out values.x);

            Console.Write("Введите значение координаты Y: ");
            double.TryParse(Console.ReadLine(), out values.y);

            Console.Write("Введите значение координаты Z: ");
            double.TryParse(Console.ReadLine(), out values.z);


            return values;

        }

    }

    public class Vector3d
    {
        public double x, y, z;
        public Vector3d(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
      
        public Vector3d((double x, double y, double z) values) : this(values.x, values.y, values.z)
        {
        }
        public static Vector3d Sum(Vector3d a, Vector3d b) // сложение 
        {
            return new Vector3d(a.x + b.x, a.y + b.y, a.z + b.z);
        }
        public static Vector3d operator +(Vector3d a, Vector3d b)
        {
            return Vector3d.Sum(a, b);
        }

        public static Vector3d Minus(Vector3d a, Vector3d b) // вычитание  
        {
            return new Vector3d(a.x - b.x, a.y - b.y, a.z - b.z);
        }
        public static Vector3d operator -(Vector3d a, Vector3d b)
        {
            return Vector3d.Minus(a, b);
        }

        public static Vector3d multiplication(Vector3d a, Vector3d b) // умножение
        {
            return new Vector3d(a.x * b.x, a.y * b.y, a.z * b.z);
            
        }
        public static Vector3d operator *(Vector3d a, Vector3d b)
        {
            return Vector3d.multiplication(a, b);
        }

    }

}

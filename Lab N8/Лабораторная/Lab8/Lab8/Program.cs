using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab8
{
    class Program : Rectangle
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            CollectionType<int> el = new CollectionType<int>();

            Console.WriteLine("Введите данные для коллекции: ");
            el.Add(Convert.ToInt32(Console.ReadLine()));
            el.Add(Convert.ToInt32(Console.ReadLine()));
            el.Add(Convert.ToInt32(Console.ReadLine()));
            el.Delete(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"{el[0]}, {el[1]} ");
            

            MethodRectangle();
            MethodRectangle2();
            Console.WriteLine();
            Console.WriteLine("Collection N3");
            
            var cubes = new List<Cube>();
            for (var i = 0; i < 10; i++)
            {
                var cube = new Cube()
                {
                    Namee = "Площадь куба = ",
                    Area = rnd.Next(10, 100)
                };
                cubes.Add(cube);
            }

            //Обычный Метод
            //var result = from item in cubes
            //             where item.Area > 30 && item.Area < 1
            //             orderby item.Area
            //             select item;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            // Ниже написаны методы Расширения

            Console.WriteLine();
            Console.WriteLine("Метод Расширения Where");
            var result2 = cubes.Where(item => item.Area > 30 || item.Area < 1);
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Метод Расширения Select");
            var selectCollection = cubes.Select(cube => cube.Area);
            foreach (var item in selectCollection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Метод Расширения OrderByDescending");
            var orderbyCollection = cubes.OrderByDescending(cube => cube.Area);
            foreach (var item in orderbyCollection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Метод Расширения Any");
            bool resultAny = cubes.Any(cube => cube.Area < 20); 
            if (resultAny)
                Console.WriteLine("Есть площадь меньше 20");
            else
                Console.WriteLine("Есть площадь больше 20");

            Console.WriteLine();
            Console.WriteLine(cubes.All(item => item.Area == 15));
            Console.WriteLine(cubes.Any(item => item.Area == 15));


            Console.WriteLine();
            Console.WriteLine("Метод Расширения First");
            int[] massivCube = { 113, 94, 65, 92, 97, 415, 3, 54, 83, 22, 39 };
            int first = massivCube.First();
            Console.WriteLine(first);

            Console.WriteLine();
            Console.WriteLine("Метод Расширения MIN и MAX");
            var min = cubes.Min(s => s.Area);
            Console.WriteLine("Минимальная площадь = " + min);
            var max = cubes.Max(s => s.Area);
            Console.WriteLine("Максимальная площадь = " + max);   
        }
    }
    class Rectangle
    {
        public static void MethodRectangle()
        {
            List<MyRectangle> rectangles = ListRectangle();
           
            // LINQ запрос
            var inquiry = from theRectangle in rectangles
                         where theRectangle.Square < 50
                         orderby theRectangle.Square
                         select theRectangle;

            Console.WriteLine("Collection N1");
            foreach (MyRectangle rectangleOptions in inquiry)
            {
                Console.WriteLine(rectangleOptions.Name + " " + rectangleOptions.Square);
            }

            var min = rectangles.Min(p => p.Square);
            Console.WriteLine("Минимальная площадь = " + min);
            var max = rectangles.Max(p => p.Square);
            Console.WriteLine("Максимальная площадь = " + max);
            Console.WriteLine();
        } 
        public static List<MyRectangle> ListRectangle()
        {
            return new List<MyRectangle>
            {
                { new MyRectangle() { Name="Прямоугольник 1: ", Square=25}},
                { new MyRectangle() { Name="Прямоугольник 2: ", Square=30}},
                { new MyRectangle() { Name="Прямоугольник 3: ", Square=35}},
                { new MyRectangle() { Name="Прямоугольник 4: ", Square=40}},
                { new MyRectangle() { Name="Прямоугольник 5: ", Square=45}}
            }; 
            
        }   
        public class MyRectangle 
        {
            
            public string Name { get; set; }
            public int Square { get; set; }
        }

        public static void MethodRectangle2()
        {
            List<MyRectangle2> rectangles2 = ListRectangle2();

            // LINQ запрос

            var inquiry2 = from theRectangle2 in rectangles2
                           where theRectangle2.Square2 < 100
                           orderby theRectangle2.Square2
                           select theRectangle2;


            Console.WriteLine("Collection N2");
            foreach (MyRectangle2 rectangleOptions2 in inquiry2)
            {
                Console.WriteLine(rectangleOptions2.Name2 + " " + rectangleOptions2.Square2);
            }

            var min2 = rectangles2.Min(s => s.Square2);
            Console.WriteLine("Минимальная площадь = " + min2);

            var max2 = rectangles2.Max(s => s.Square2);
            Console.WriteLine("Максимальная площадь = " + max2);
        }
        public static List<MyRectangle2> ListRectangle2()
        {
            return new List<MyRectangle2>
            {
                { new MyRectangle2() { Name2="Прямоугольник 1: ", Square2=55}},
                { new MyRectangle2() { Name2="Прямоугольник 2: ", Square2=70}},
                { new MyRectangle2() { Name2="Прямоугольник 3: ", Square2=90}}
            };
        }
        public class MyRectangle2
        {

            public string Name2 { get; set; }
            public int Square2 { get; set; }
        }
    }
    class CollectionType<T>
    {
        T[] massiv; 
        public CollectionType()
        {
            massiv = new T[0];
        }
        ~CollectionType() // далее делаем деструктор 
        {
            Console.WriteLine("Сработал деструктор ~CollectionType()");
        }

        public void Add(T r) // метод добавления элементов 
        {
            Array.Resize(ref massiv, massiv.Length + 1);
            massiv[massiv.Length - 1] = r; 
        }

        public void Delete(T r) // метод удаления элементов
        {
            int f;
            try
            { 
                for (int i = 0; i <= massiv.Length; i++)
            
                    if (massiv[i].Equals(r)) 
                    {
                        f = i;
                        while (f < massiv.Length - 1)
                        {
                            massiv[f] = massiv[f + 1];
                            f++;
                        }
                        Array.Resize(ref massiv, massiv.Length - 1);
                        break;
                    }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Ошибка: выход за границы массива");
            }
        }
        public T this[int r]
        {
            get { return massiv[r]; } 
        }
    }
}
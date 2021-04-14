using System;

namespace LAB5Matrix
{   
    class Program
    {
        // Задаём размеры матрицы 
        static int[,] MyMatrix(string str)
        {

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            int i, j;
            Random random = new Random();
            int random1;

            Console.Write("Введите колличество столбцов матрицы: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите колличество строк матрицы: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[,] MatrixA = new int[a, b];

            // В этом цикле нашей матрице присваиваются рандомные числа от 1 до 9
            for (i = 0; i < a; i++)
            {
                for (j = 0; j < b; j++)
                {
                    random1 = random.Next(1, 9);
                    MatrixA[i, j] = random1;

                }

            }

            return MatrixA;
        }

        // Мы обращаемся к этому методу в методе MAIN для вывода матриц + - *
        static void outputMatrix(int[,] MatrixA)
        {
            for (var i = 0; i < MatrixA.stroki(); i++)
            {
                for (var j = 0; j < MatrixA.stolbiki(); j++)
                {
                    Console.Write(MatrixA[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        // Сложение
        static int[,] MatrixAplusB(int[,] MatrixA, int[,] MatrixB)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            if
            (MatrixA.stolbiki() != MatrixB.stolbiki())
            {
                throw new System.IndexOutOfRangeException("Матрицы с разным размером сложить не возможно.");
            }

            if
            (MatrixA.stroki() != MatrixB.stroki())
            {
                throw new System.IndexOutOfRangeException("Матрицы с разным размером сложить не возможно.");
            }
            var MatrixC = new int[MatrixA.stroki(), MatrixB.stolbiki()];

            for (var i = 0; i < MatrixA.stroki(); i++)
            {
                for (var j = 0; j < MatrixB.stolbiki(); j++)
                {
                    MatrixC[i, j] = MatrixA[i, j] + MatrixB[i, j];
                }
            }

            return MatrixC;
        }

        // Вычитание
        static int[,] MatrixAminusB(int[,] MatrixA, int[,] MatrixB)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            if
            (MatrixA.stolbiki() != MatrixB.stolbiki())
            {
                throw new System.IndexOutOfRangeException("Матрицы с разным размером вычесть не возможно.");
            }

            if
            (MatrixA.stroki() != MatrixB.stroki())
            {
                throw new System.IndexOutOfRangeException("Матрицы с разным размером вычесть не возможно.");
            }

            var MatrixC = new int[MatrixA.stroki(), MatrixB.stolbiki()];

            for (var i = 0; i < MatrixA.stroki(); i++)
            {
                for (var j = 0; j < MatrixB.stolbiki(); j++)
                {
                    MatrixC[i, j] = MatrixA[i, j] - MatrixB[i, j];
                }
            }

            return MatrixC;
        }

        // Умножение 
        static int[,] MatrixAmultiplicationB(int[,] MatrixA, int[,] MatrixB)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            if
             (MatrixA.stolbiki() != MatrixB.stolbiki())
            {
                throw new System.IndexOutOfRangeException("Матрицы с разным размером умножить не возможно.");
            }

            if
            (MatrixA.stroki() != MatrixB.stroki())
            {
                throw new System.IndexOutOfRangeException("Матрицы с разным размером умножить не возможно.");
            }

            var MatrixC = new int[MatrixA.stroki(), MatrixB.stolbiki()];

            for (var i = 0; i < MatrixA.stroki(); i++)
            {
                for (var j = 0; j < MatrixB.stolbiki(); j++)
                {
                    MatrixC[i, j] = MatrixA[i, j] * MatrixB[i, j];
                }
            }

            return MatrixC;
        }

        static int[,] GetEmpty(int[,] MatrixA, int[,] MatrixB)  // METOD GETEMPTY матрице должны быть все нули 
        {


            Console.ForegroundColor = ConsoleColor.White;

            var MatrixC = new int[MatrixA.stroki(), MatrixB.stolbiki()];

            for (var i = 0; i < MatrixA.stroki(); i++)
            {
                for (var j = 0; j < MatrixB.stolbiki(); j++)
                {
                    MatrixC[i, j] = (0);
                }
            }

            return MatrixC;
        }

        static void Main(string[] args)
        {

            var a = MyMatrix("A");
            var b = MyMatrix("B");
            Console.WriteLine();


            Console.WriteLine("Матрица A:");
            Console.WriteLine();
            outputMatrix(a);
            Console.WriteLine();


            Console.WriteLine("Матрица B:");
            Console.WriteLine();
            outputMatrix(b);
            Console.WriteLine();


            var result = MatrixAplusB(a, b);
            Console.WriteLine("Сумма матриц:");
            Console.WriteLine();
            outputMatrix(result);
            Console.WriteLine();

            Console.WriteLine();
            var result1 = MatrixAminusB(a, b);
            Console.WriteLine("Разность матриц:");
            Console.WriteLine();
            outputMatrix(result1);
            Console.WriteLine();

            Console.WriteLine();
            var result2 = MatrixAmultiplicationB(a, b);
            Console.WriteLine("Произведение матриц:");
            Console.WriteLine();
            outputMatrix(result2);
            Console.WriteLine();

            Console.WriteLine();
            var result3 = GetEmpty(a, b);
            Console.WriteLine("GetEmpty:");
            Console.WriteLine();
            outputMatrix(result3);
            Console.WriteLine();

            Console.ReadLine();
        }

       
    }
    static class MatrixRasshirenie // Без этого конченного метода нифига не работает (время 3:10 ночи....)
    {
        // метод строк матрицы
        public static int stroki(this int[,] MatrixA)
        {
            return MatrixA.GetLength(0);
        }

        // метод столбиков матрицы
        public static int stolbiki(this int[,] MatrixB)
        {
            return MatrixB.GetLength(1);
        }
    }
}
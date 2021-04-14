using System;

namespace MATRIX17VARIANT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            int i, j;
            int summa = 0;           

            Random rand = new Random();
            Console.Write("Введите значения n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значения m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] massiv1 = new int[n, m];

           


            for (i = 0; i < n; i++)
                for (j = 0; j < m; j++)
                {
                    massiv1[i, j] = rand.Next(-9, 0);
                }
            Console.WriteLine();

            Console.WriteLine("Наша матрица:");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                    Console.Write(" " + massiv1[i, j]);
                Console.WriteLine();
            }

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    if (massiv1[j, i] < 0 && Math.Abs(massiv1[j, i]) % 2 == 0)
                        summa -= Math.Abs(massiv1[j, i]);
                    

                }
                massiv1[i, 0] = summa;
                Console.WriteLine("\nХарактеристика " + (i + 1) + "-ой строки " + summa);             
            }

            
        }      
    }
}

/*
           for (i = 0; i < n; i++)
           {
               for (j = 0; j < m; j++) 
                   {
                   if (massiv2[j, i] > massiv2[j, i])
                   {
                       t = massiv1[j, i];
                       massiv1[j, i] = massiv1[j, i];
                       massiv1[j, i] = t;
                   }
               }
           }

           */

/*
 * SwapLines(massiv1, 0, 1);

for (i = 0; i < n; i++)
{
    for (j = 0; j < m; j++)
    {
        if (massiv2[j, i] > massiv2[j, i])
        {
            t = massiv1[j, i];
            massiv1[j, i] = massiv1[j, i];
            massiv1[j, i] = t;
        }
    }
}
*/

/* public static void SwapLines(int[,] matrix, int firstLine, int secondLine)
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int temp = matrix[firstLine, i];
                matrix[firstLine, i] = matrix[secondLine, i];
                matrix[secondLine, i] = temp;
            }

            Console.WriteLine("Наша матрица после переворота:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(" " + matrix[i, j]);
                Console.WriteLine();
            }

        }
        */
using System;

namespace Vector17Variant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько целых чисел желаете ?");
            int N = Convert.ToInt32(Console.ReadLine());         // Convert.ToInt32 преобразует в int значение любого типа + ввод данных

            Console.WriteLine("Введите целые числа:");
            int[] MyMassiv = new int[N];                         // Тут создание массива! почему N а не число или пустой? я числа пишу сам в консоль 
             
            for (int i = 0; i < MyMassiv.Length; i++)            // Цикл такой что колличество повторений = колличеству элементов 
                {
                    MyMassiv[i] = Convert.ToInt32(Console.ReadLine());       // Convert.ToInt32 преобразует в int значение любого типа + ввод данных
            }

            BubbleSort(MyMassiv);                                // Тут мы указываем метод сортировки пузырька ( сам метод написан ниже) 
            Console.WriteLine("Сортировка завершена: " );

            for (int i = 0; i < MyMassiv.Length; i++)           // Цикл такой что колличество повторений = колличеству элементов 
            {    
                    Console.Write(MyMassiv[i] + " ");           // Вывод отсортированных данных в стоку + ставит пробелы
                }
                    Console.ReadLine();
        }
        static int[] BubbleSort(int[] MyMassiv)                 // Вот второй метод: сортировка пузырьком 
        {
            int x;
            for (int i = 0; i < MyMassiv.Length; i++)           // Цикл такой что колличество повторений = колличеству элементов 
            {
                for (int j = i + 1; j < MyMassiv.Length; j++)   // Цикл такой что колличество повторений = колличеству элементов 
                {
                    if (MyMassiv[i] > MyMassiv[j])
                    {
                        x = MyMassiv[i];
                        MyMassiv[i] = MyMassiv[j];
                        MyMassiv[j] = x;
                    }
                }
            }
            return MyMassiv;
        }
    }
}

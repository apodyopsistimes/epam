using System;
using System.Linq;

namespace STROKA17VARIANT
{
    class Program
    {
        /*
         * Полезный метод - String.Join - он создает строку из массива, разделяя каждый элемент массива с заданным символом 
         *
         * Операция Concat соединяет две входные последовательности и выдает одну выходную последовательность
         * 
         * Where выберет все четные элементы. А метод Reverse у нас меняет буквы местами.
         */
        static void Main(string[] args)
            {
                Console.WriteLine("Введите строковую величину: ");
                string vvodimoeslovo = Console.ReadLine();       
                string slovo = string.Join(string.Empty, vvodimoeslovo.Where((c, i) => (i + 1) % 2 == 0).Concat(vvodimoeslovo.Where((c, i) => (i + 1) % 2 == 1).Reverse())); 
                Console.WriteLine("Ваша зашифрованная величина: ");
                Console.WriteLine(slovo);
                Console.ReadKey();
            }
        
    }
    
}

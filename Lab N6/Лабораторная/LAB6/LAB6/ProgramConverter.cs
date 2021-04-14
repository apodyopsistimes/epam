using System;
using System.Collections.Generic;
using System.Text;

namespace LAB6
{
    
    class ProgramConverter : IConvertible

    {
        public string ConvertToCSharp(string CSharp)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            return "Коневертация из формата VB в формат C# выполнена успешна";
        }
        public string ConvertToVB(string VB)
        {
            return "Коневертация из формата C# в формат VB выполнена успешна";
        }
    }
}

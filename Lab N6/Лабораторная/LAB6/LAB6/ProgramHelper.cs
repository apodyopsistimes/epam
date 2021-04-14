using System;
using System.Collections.Generic;
using System.Text;

namespace LAB6
{
    class ProgramHelper : ProgramConverter, IConvertible
    {
       
        public string ConvertToCSharp(string PROVERKA)
        {
            return "При написании метода ConvertToCSharp использовать простые строковые сообщения для имитации";
        }

        public string ConvertToVB(string LANGUAGE)
        {

            return "При написании метода ConvertToVB использовать простые строковые сообщения для имитации";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LAB6
{
    interface IConvertible
    {
        string ConvertToCSharp(string VBCODE);
        string ConvertToVB(string Csharp);
    }
}

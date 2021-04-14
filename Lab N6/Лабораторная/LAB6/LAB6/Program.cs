using System;

namespace LAB6
{
    class Program
    {
        static void Main(string[] args)
        {

            ProgramConverter[] programConverter = new ProgramConverter[2];
            programConverter[0] = new ProgramConverter();   
            programConverter[1] = new ProgramHelper();

            for (int i = 0; i < programConverter.Length; i++)
            {
                if (programConverter[i] is ICodeChecker)
                {
                    ICodeChecker codeChecker = (ICodeChecker)(programConverter[i] as ProgramHelper);
                    if (codeChecker.CheckCodeSyntax("PROVERKA", "LANGUAGE"))
                    Console.WriteLine(programConverter[i].ConvertToCSharp("PROVERKA"));
                    else
                    Console.WriteLine(programConverter[i].ConvertToVB("PROVERKA"));
                }
                else
                {
                    IConvertible convert = programConverter[i] as ProgramConverter;
                    Console.WriteLine(convert.ConvertToCSharp("PROVERKA"));
                    Console.WriteLine(convert.ConvertToVB("PROVERKA"));
                }
            }        
        }
    }  
}
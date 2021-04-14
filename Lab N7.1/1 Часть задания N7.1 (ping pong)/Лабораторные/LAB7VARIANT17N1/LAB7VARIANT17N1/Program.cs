using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Action<Func<int, int>, List<string>> list = L;
        Func<int, int> dvainta = x => x*x;
        List<string> listik = new List<string>();
        list?.Invoke(dvainta, listik);
        foreach (string hi in listik)
        {
            Console.WriteLine(hi);
        }
        Console.ReadKey();


    }

    public static void L(Func<int, int> f, List<string> s)
    {
        Random rnd = new Random();
        int ab = rnd.Next(1, 10);
        for ( int i = 0; i < ab; i++ )
            {
                s.Add(Convert.ToString(f(i)));
            }
    }

}
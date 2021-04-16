using System;
using System.IO;
using System.Xml.Linq;

namespace Lab_N9._1
{
    [Serializable]
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xdoc = new XDocument();
            XElement root = new XElement("root");

            StreamReader fileTxt = new StreamReader("textfile.txt");
            string s;
            int[] number = { 0 , 0};

            
            while ((s = fileTxt.ReadLine()) != null)
            {
                XElement line = new XElement("line");
                XAttribute num1 = new XAttribute("num", number[0].ToString());
                line.Add(num1);

                string[] s1 = s.Split();
                number[1] = 0;

                foreach (string st in s1)
                {
                    XElement word = new XElement("word");
                    XAttribute num2 = new XAttribute("num", number[1].ToString());
                    XText text = new XText(st);
                    word.Add(num2);
                    word.Add(text);
                    line.Add(word);
                    number[1]++;
                }
                root.Add(line);
                number[0]++;
            }
            fileTxt.Close();
            xdoc.Add(root);
            xdoc.Save("xmlLesson1");
            Console.WriteLine(xdoc + "\n");
            Console.ReadLine();
             
        }

    }
}

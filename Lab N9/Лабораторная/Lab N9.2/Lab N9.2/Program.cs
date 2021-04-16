using System;
using System.IO;
using System.Xml.Linq;

namespace Lab_N9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xdoc = new XDocument();
            XElement root = new XElement("root");

            StreamReader fileTxt = new StreamReader("textfile2.txt");
            string s;
            while ((s = fileTxt.ReadLine()) != null)
            {
                XElement line = new XElement("line"); 
                string[] s1 = s.Split();

                foreach (string st in s1)
                {     
                    XElement word = new XElement("word");
                    char[] s2 = st.ToCharArray();

                    foreach (char s3 in s2 )
                    {
                        XElement chars = new XElement("char");
                        XText text = new XText(s3.ToString());
                        chars.Add(text);
                        word.Add(chars);

                    }
                    line.Add(word);                 
                }                             
                root.Add(line);  
            }

            fileTxt.Close();
            xdoc.Add(root);
            xdoc.Save("xmlLesson2");
            Console.WriteLine(xdoc);
            Console.ReadLine();
        }
    }
}

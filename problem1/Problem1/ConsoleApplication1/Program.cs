using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("D:/Наука/4-й курс/c#/problem1/Problem1/Problem1.html");
            StreamWriter writer = new StreamWriter("D:/Наука/4-й курс/c#/problem1/Problem1/Problem1.txt");
            string pattern = "<[^>]*>";

            string text = reader.ReadLine();
            while (text != null) {
                string replaceText = Regex.Replace(text, pattern, "");
                if (!((replaceText == " ") || (replaceText == "")))
                    writer.WriteLine(replaceText);
                text = reader.ReadLine();
            }
            Console.WriteLine("The tags was deleted!");
            Console.ReadLine();
            reader.Close();
            writer.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("D:/Наука/4-й курс/c#/problem1/1.1/mails.txt");
            Regex pattern = new Regex("^(\\b){5,5}.+@([a-z]+)(.)([a-z]{1,4})$");
            StreamWriter result = new StreamWriter("D:/Наука/4-й курс/c#/problem1/1.1/valid-mails.txt");
            while (true) {
                string text = reader.ReadLine();
                if (text == null)
                    break;
                if (pattern.IsMatch(text))
                    result.WriteLine(text);
            }
            Console.WriteLine("The address was validate!");
            Console.ReadLine();
            reader.Close();
            result.Close();   
        }
    }
}

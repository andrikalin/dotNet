using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("D:/Наука/4-й курс/c#/problem1/1.4/text.txt");
            string text = reader.ReadLine();

            StreamReader wordReader = new StreamReader("D:/Наука/4-й курс/c#/problem1/1.4/words.txt");
            string word = wordReader.ReadLine();

            while (word != null) {
                int count = 0;
                if (text.Contains(word)) {
                    Match match = Regex.Match(text, word, RegexOptions.IgnoreCase);
                    while (match.Success) {
                        count++;
                        match = match.NextMatch();
                    }
                }
                Console.WriteLine(word + " are found respectively " + count + " times");
                word = wordReader.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
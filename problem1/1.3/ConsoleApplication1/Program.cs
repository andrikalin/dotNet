using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("D:/Наука/4-й курс/c#/problem1/1.3/text.txt");
            string text = reader.ReadLine();
            while (true) {
                string temp = reader.ReadLine();
                if (temp == null)
                    break;
                text += " " + temp;
            }

            StreamReader word_reader = new StreamReader("D:/Наука/4-й курс/c#/problem1/1.3/words.txt");
            string word = word_reader.ReadLine().Trim();
            

            StreamWriter result = new StreamWriter("D:/Наука/4-й курс/c#/problem1/1.3/result.txt");
            int count = 0;
            text = text.ToLower();
            while(word != null) {
                if (text.Contains(word)) {
                    string temp = "";
                    for (int i = 0; i < text.Length;i++) {
                        if (!Char.IsLetter(text[i])) {
                            if (temp.Equals(word))
                              count++;
                            temp = "";
                        }
                        else
                            temp += text[i];
                    }
                }
                result.WriteLine(word + " --> "  + count);
                Console.WriteLine(word + " --> " + count);
                count = 0;
                word = word_reader.ReadLine().Trim();
                
            }
            Console.WriteLine("The retrives of the numbers of mathes is done!");
            Console.ReadLine();
            word_reader.Close();
            result.Close();
            reader.Close();
        }
    }
}

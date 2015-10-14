using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your text below:\n");
            string text = Console.ReadLine();
            int count = 0;
            int countUpper = 0;
            int countLower = 0;
            bool oznUpper;
            bool oznLower;
            for (int i = 0; i < text.Length;)
            {
                if (!Char.IsLetter(text[i])) {
                    i++;
                    continue;
                }
                else {
                    oznLower = false;
                    oznUpper = false;
                    while (true) {
                        if (Char.IsLower(text[i]))
                            oznLower = true;
                        if (Char.IsUpper(text[i]))
                            oznUpper = true;
                        i++;
                        if (i >= text.Length || !Char.IsLetter(text[i]))
                        {
                            if (!(oznLower && oznUpper))
                            {
                                if (oznLower)
                                    countLower++;
                                if (oznUpper)
                                    countUpper++;
                            }
                            break;
                        }
                    }
                    count++;
                }

            }

            Console.WriteLine("Word count: " + count);
            Console.WriteLine("Word upper case: " + countUpper);
            Console.WriteLine("Word lower case: " + countLower);

            Console.ReadLine();
        }
    }
}

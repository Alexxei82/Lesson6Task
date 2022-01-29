using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение без знаков препинания: ");
            string sentence = Console.ReadLine();
            string[] word = sentence.Split(new Char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
            int maxlength = 0, index = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i].Length > maxlength)
                {
                    maxlength = word[i].Length;
                    index = i;
                }
            }
            Console.Write("Самое длинное слово: {0}", word[index]);
            Console.ReadKey();

        }
    }
}

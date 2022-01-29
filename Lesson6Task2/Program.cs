using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст для проверки является ли он палиндромом: ");
            string text = Console.ReadLine();
            text = text.Replace(" ", string.Empty);
            text = text.ToLower();
            char[] obrtext = text.ToCharArray();
            Array.Reverse(obrtext);
            string finaltext = new string(obrtext);
            if (text == finaltext)
            {
                Console.Write("является");
            }
            if (text != finaltext)
            {
                Console.Write("не является!");
                           }
            Console.ReadKey();
        }
    }
}

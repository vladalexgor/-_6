using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6
{
    class Program
    {
        //Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются. Найти самое длинное слово в строке.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите с клавиатуры предложение, используя пробелы без знаков препинания:");
            string startString = Console.ReadLine();
            string longString = "";
            //n - номер самого длинного слова в предложении, L - длина этого слова
            int L = 0;
            string[] stringArray = startString.Split();
            foreach (string n in stringArray)
            {
                if (L < n.Length)
                {
                    L = n.Length;
                    longString = n;
                }
            }
            Console.WriteLine("Самое длинное слово \"{0}\": {1} символов", longString, L);
            Console.WriteLine("Для завершения программы нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6_App2
{
    class Program
    {
        //Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются.
        //Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»).
        static void Main(string[] args)
        {
            Console.WriteLine("Введите с клавиатуры предложение, используя пробелы без знаков препинания:");
            string startString = Console.ReadLine();
            //A - строка без пробелов в прямом направлении
            //B - строка без пробелов в обратном направлении
            string A = "";
            string B = "";
            string[] stringArray = startString.Split();
            foreach (string n in stringArray)
            {
                A += n;
            }
            //L - длина начальной строки без пробелов
            int L = A.Length;
            Console.WriteLine("Строка в прямом направлении без пробелов: {0}", A);
            for (int i = (L-1); i >= 0; i--)
            {
                string S = A.Substring(i, 1);
                B += S;
            }
            Console.WriteLine("Строка в Обратном направлении без пробелов: {0}", B);
            if (B == A)
            {
                Console.WriteLine("Введенная строка является палиндромом.");
            }
            else
            {
                Console.WriteLine("Введенная строка не является палиндромом.");
            }
            Console.WriteLine("Для завершения программы нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}

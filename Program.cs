using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_PolessUP
{
    internal class Program
    {
        static void printWord(char number)
        {
            switch (number)
            {
                case '1':
                    Console.Write("one ");
                    break;
                case '2':
                    Console.Write("two ");
                    break; 
                case '3':
                    Console.Write("three ");
                    break;
                case '4':
                    Console.Write("four ");
                    break;
                case '5':
                    Console.Write("five ");
                    break;
                case '6':
                    Console.Write("six ");
                    break;
                case '7':
                    Console.Write("seven ");
                    break;
                case '8':
                    Console.Write("eight ");
                    break;
                case '9':
                    Console.Write("nine ");
                    break;
                case '0':
                    Console.Write("zero ");
                    break;
                case '-':
                    Console.Write("minus ");
                    break;
                case '.':
                    Console.Write("point ");
                    break;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число (без пробелов, если число дробное- через точку)");
            string num=Console.ReadLine();
            for(int i=0;i<num.Length;i++)
            {
                printWord(num[i]);
            }
            Console.WriteLine();
        }
    }
}

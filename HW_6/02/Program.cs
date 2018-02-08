using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace _02
{

    class Program
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass();
            int buf, b, c, d;
            Console.WriteLine("Введите начальное значение, конечное значение и шаг.\nЗначения вводятся последовательно через Enter");
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (c < b)
            {
                while (c < b)
                {

                    Console.WriteLine("Конечное значение должно быть больше начального, повторите попытку!");
                    Console.WriteLine("Введите конечное значение");
                    c = int.Parse(Console.ReadLine());
                }
            }
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите функцию для запуска и нажмите Enter.\n1.MyFun(x * x - 50 * x + 10)\n2.MyFun2(x * x - 50)\n3.MyFun3(x * x + 500)\n");
            buf = int.Parse(Console.ReadLine());
            if (buf == 1)
            {
                a.MyMainFunc("data222.txt", a.MyFun, b, c, d);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nMinimum is:{0}\n", MyClass.Load("data222.txt"));
                Console.ForegroundColor = ConsoleColor.Gray;
                a.View("data222.txt");
            }
            if (buf == 2)
            {
                a.MyMainFunc("data222.txt", a.MyFun2, b, c, d);
                Console.WriteLine("\nMinimum is:{0}\n", MyClass.Load("data222.txt"));
                a.View("data222.txt");
            }
            if (buf == 3)
            {
                a.MyMainFunc("data222.txt", a.MyFun3, b, c, d);
                Console.WriteLine("\nMinimum is:{0}\n", MyClass.Load("data222.txt"));
                a.View("data222.txt");
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nGood buy!");
            Console.ReadLine();
        }
    }
}

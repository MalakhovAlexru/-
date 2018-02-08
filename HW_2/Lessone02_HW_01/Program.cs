using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Написать метод возвращающий минимальное из трех чисел;


namespace Lessone02_HW_01
{
    class Program
    {
        static int Min(int a, int b, int c)
        {
            int minv = a;            
            if (b < minv) 
                { minv = b; }
            if (c < minv)
                { minv = c; }
            return minv;
        }
        static int Max(int a, int b, int c)
        {
            int max = a;
            if (b > max)
            { max = b; }
            if (c > max)
            { max = c; }
            return max;
        }
        static void Task1()
        {
            int a, b, c;
            Console.WriteLine("\n Введите три числа:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы ввели a={0} , b={1}, c={2} \n Минимальным является {3}", a ,b,c, Min(a, b, c));

        }
        static void Task2()
        {
            int a, b, c;
            Console.WriteLine("\n Введите три числа:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы ввели a={0} , b={1}, c={2} \n Максимальным является {3}", a, b, c, Max(a, b, c));
            Console.ReadLine();

        }
        static void Task3()
        {
            int a, b, c;
            Console.WriteLine("\n Введите три числа:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы ввели a={0} , b={1}, c={2}", a,b,c);
            Console.ReadLine();

        }
        static void Task4()
        {
            Console.WriteLine("\n bye-bye");
            Console.ReadLine();

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите одно из действий: \n 1.Вывести самое мальенькое число из трех введенных. \n 2.Выполнить сравнение чисел и вывести максимальное из трех введенных. \n 3.Вывести введенные числа. \n 4.Выйти из программы");
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    {
                        Task1();
                        break;     
                    }
                case ConsoleKey.D2:
                    {
                        Task2();
                        break;
                    }
                case ConsoleKey.D3:
                    {
                        Task3();
                        break;
                    }
                case ConsoleKey.D4:
                    {
                        Task4();
                        break;
                    }
                    
            }
            Console.ReadLine();

        }
    }
}

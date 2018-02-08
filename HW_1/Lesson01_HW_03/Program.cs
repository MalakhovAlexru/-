using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01_HW_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, r;
           // int r;
            string buff;
            Console.WriteLine("Введите значения координат для x1 и y1");
            buff = Console.ReadLine();
            x1 = Convert.ToDouble(buff);
            buff = Console.ReadLine();
            y1 = Convert.ToDouble(buff);
            Console.WriteLine("Введите значения координат для x2 и y2");
            buff = Console.ReadLine();
            x2 = Convert.ToDouble(buff);
            buff = Console.ReadLine();
            y2 = Convert.ToDouble(buff);
            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Расстояние между точками координат равняется: {0:F4}", r);
            Console.ReadLine();
            
        }
    }
}

using System;


namespace Lesson01_HW_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //int ;
            double l, m, h;
            string buff;
            Console.WriteLine("Введите вес испытуемого в кг:");
            buff = Console.ReadLine();
            m = Convert.ToDouble(buff);
            Console.WriteLine("Введите рост испытуемого в см:");
            buff = Console.ReadLine();
            h = Convert.ToDouble(buff);
            l = m / (h * h);
            Console.WriteLine("Индекс массы тела испытуемого равен:{0}", l);
            Console.ReadLine();
        }
    }
}

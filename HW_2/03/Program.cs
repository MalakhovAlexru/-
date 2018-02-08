using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных
//положительных чисел;

namespace _03
{
    class Program
    {
        static double Sum()
        {
            double val, summ = 0;
            for (int i = 0; ; i++)
            {
                Console.WriteLine("Enter value:");
                val = Convert.ToDouble(Console.ReadLine());
                if (val == 0) break;
                if (val % 2 != 0 && val > 0) summ = summ + val;
                Console.WriteLine("Your summ now is:{0}", summ);
            }
            return summ;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Total summ is:{0}",Sum());
            Console.ReadLine();

                    
           }
    }
}

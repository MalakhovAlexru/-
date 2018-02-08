using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Написать метод подсчета количества цифр числа;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string s = "Hello foreach!!!";
            foreach (char c in s)
            {
               //Console.WriteLine("{0}", c);
                i++;
            }
            Console.WriteLine("{0}", i);
            Console.ReadLine();
        }
    }
}

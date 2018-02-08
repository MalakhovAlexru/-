using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    public delegate double MyDelegat(double a, double b);
    public class SimpleMath
    {
        public static double summ(double a, double x)
        {
            return a*Math.Pow(x,2);
        }
        public static double decr(double a, double b)
        {
            return a - b;
        }
    }
      
    class Program
    {
        
        static void Main(string[] args)
        {
            MyDelegat c = new MyDelegat(SimpleMath.summ);
            Console.WriteLine("Summ of 2 elemnt is:{0}", c(14.5, 18.2));
            c = new MyDelegat(SimpleMath.decr);
            Console.WriteLine("Summ of 2 elemnt is:{0}", c(14.5, 18.2));
            Console.ReadLine();
        }
    }
}

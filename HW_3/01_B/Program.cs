using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить
//работу класса;

namespace _01_B
{
    class Program
    {
        public class ComplexB
        {
            public double Umnoz(Complex B, Complex A)
            {
                return (A.a * B.a) + (A.a * B.c);
            } 


            public struct Complex
            {
                public double a, c, i;
                public double Summ(Complex B)
                {
                    return (a + B.a) + ((c + B.c) * i);
                }
                public double Encr(Complex B)
                {
                    return (a - B.a) + ((c - B.c) * i);
                }
            }
        }
        static void Main(string[] args)
        {
            ComplexB.Complex A, B;

            A.a = 10;
            A.c = 15;
            A.i = 1; //Convert.ToDouble(Math.Sqrt(-1));
            B.a = 18;
            B.c = 12;
            B.i = 1; //Convert.ToDouble(Math.Sqrt(-1));
            double itog = A.Summ(B);
            Console.WriteLine(itog);
            double vichet = A.Encr(B);
            Console.WriteLine(vichet);
            Console.ReadLine();
        }
    }
}
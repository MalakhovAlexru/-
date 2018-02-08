using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Massiv
    {
        private int[] a;
        private int sum=0;
        Random rnd = new Random();
        public Massiv(int n)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(-10001, 10000);
            }
        }
            public void print()
        {
            foreach (int el in a)
                Console.Write(" {0,4} ", el);
        }
        public void para(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 3 == 0) sum++;
                else try
                    {
                        if (a[i + 1] % 3 == 0) sum++;
                    }
                    catch (Exception)
                    {
                       // Console.WriteLine("Массив кончился");
                    }
            }
            Console.WriteLine("Summ IS {0,5} ", sum);
    

        }

        }
    }
   
    


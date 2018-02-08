using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




    
namespace _02
{
    class MyArray
    {
        private int[] a;
        private int sum = 0;
        //Random rnd = new Random();
        public void Massiv(int n)
        {
            
            Console.WriteLine("Enter START value");
            int start_v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter STEP value");
            int step_v = Convert.ToInt32(Console.ReadLine());
           
            a = new int[n];
            a[0] = start_v;
            for (int i = 1; i < n; i++)
            {
                a[i] = a[i-1] + step_v;
            }
        }
          public void summ()
        {
            int sum=0;
            foreach (int el in a)
                sum = sum + el;

            Console.WriteLine("Summ of all elements in array is : {0,4}", sum);
            //return sum;
        }
        public void Inverse()
        {
           // int negative;
            for (int i=0;i<a.Length;i++)
            {
                a[i] = a[i] * (-1);
            }
            print();

        }
        public void print()
        {
            foreach (int el in a)
                Console.Write(" {0,4} ", el);
        }
        public void Multi()
        {
            // int negative;
            int C = 0;
            Console.WriteLine("enter value of increment all array");
            C = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = a[i] * C;
                //Console.WriteLine("\n{0,4}", a[i]);
            }
            print();

        }
    }

        }

        //public 

    


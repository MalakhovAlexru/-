using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Создать программу, которая будет проверять корректность ввода логина.Корректным логином
//будет строка от 2-х до 10-ти символов, содержащая только буквы и цифры, и при этом цифра не
//может быть первой.
//а) без использования регулярных выражений;
//б) ** с использованием регулярных выражений.


namespace _01_a
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            int count = 0;
            Console.WriteLine("Введите пароль.");
            a = Convert.ToString(Console.ReadLine());
            foreach (int el in a)
            {

                count = count + 1;
                Console.WriteLine("\nElement: {0}\nCount: {1}\n\n", el, count);
                if(count == 1 )
                {
                    if(el == 48 || el == 49 || el == 50 || el == 51 || el == 52 || el == 53 || el == 54 || el == 55 || el == 56 || el == 57)
                    {
                        Console.WriteLine("Error!");
                        break;
                    }
                }
                if(count == 10)
                {
                    Console.WriteLine("Error!Password is too big");
                    break;
                }
              
            }
            if (a.Length <= 2)
            {
                Console.WriteLine("Error!Password is too short!");
                
            }
            Console.ReadLine();

        }
    }
}

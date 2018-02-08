using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//    а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).
//Требуется подсчитать сумму всех нечетных положительных чисел.Сами числа и сумму вывести
//на экран; Используя tryParse;

//    б) Добавить обработку исключительных ситуаций на то, что могут быть введены не корректные
//данные.При возникновении ошибки вывести сообщение.


namespace _03
{
    class Program
    {
        static int Summ(int x, int sum)
        {
            if (x > 0 && x % 2 != 0)
            {
                sum = sum + x;
            }
            return sum;
        }
        static void Input()
        {
            string s;
            int x, sum = 0;
            bool flag = false;
            Console.WriteLine("For Exit enter 0 \n Enter value: ");
            do
            {
                s = Console.ReadLine();
                flag = int.TryParse(s, out x);
                if (flag == false)
                {
                    try
                    {
                        Console.WriteLine("вы ввели строку, попробуйте ввести число");
                        s = Console.ReadLine();
                        flag = int.TryParse(s, out x);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("вы ввели строку, попробуйте ввести число");
                        Console.WriteLine(ex.Message);
                        flag = true;
                    }
                }
                sum = Summ(x, sum);

            }
            while (x != 0);
            Console.WriteLine("Summ of negatives numbers is: {0} ", sum);
            Console.WriteLine("Good buy");
        }
        static void Main(string[] args)
        {

            Input();
            Console.ReadLine();

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//Создать программу, которая будет проверять корректность ввода логина.Корректным логином
//будет строка от 2-х до 10-ти символов, содержащая только буквы и цифры, и при этом цифра не
//может быть первой.
//а) без использования регулярных выражений;
//б) ** с использованием регулярных выражений.

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            Regex myreg = new Regex(@"^\D[a-zA-Z0-9]{2,10}$");
            Console.WriteLine("Введите пароль.\nВ пароле, на первом месте не может находиться цифра, длина пароля должна быть от 2 до 10 символов\n");
            a = Console.ReadLine();
            Console.WriteLine(myreg.IsMatch(a));
            Console.ReadKey();
        }
    }
}

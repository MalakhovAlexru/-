using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Реализовать метод проверки логина и пароля.На вход подается логин и пароль.На выходе
//истина, если прошел авторизацию, и ложь, если не прошел.Используя метод проверки логина и
//пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его
//дальше или не пропускает.С помощью цикла do while ограничить ввод пароля тремя попытками;


namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            string login2, password2;
            string login = "alex";
            string password = "abcd0001";
            int count = 0;
            bool auth = false;

            do
            {
                Console.WriteLine("Enter login:");
                login2 = Console.ReadLine();
                Console.WriteLine("Enter password:");
                password2 = Console.ReadLine();
                if (login == login2 && password == password2)
                {
                    auth = true;
                    break;
                }
                Console.WriteLine("Wrong login or password, try again!\n\n\n");
                count++;
            }
            while (count < 3);
            if (auth == true)
            {
                Console.WriteLine("\n Welcome!\n");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nTry again later\n");
                Console.ReadLine();
            }
        }
    }
}

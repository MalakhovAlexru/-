using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;



//Разработать методы для решения следующих задач.Дано сообщение:
//а) Вывести только те слова сообщения, которые содержат не более чем n букв;
//б) Удалить из сообщения все слова, которые заканчиваются на заданный символ;
//в) Найти самое длинное слово сообщения;
//г) Найти все самые длинные слова сообщения.
//Постарайтесь разработать класс MyString.

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Mystring a = new Mystring();
            Console.WriteLine("Введите длину слова,по которой будет сформирован поиск");
            int n = Convert.ToInt32(Console.ReadLine());
            a.Lenght_el(n);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Окончание слова,по которому будет сформирован поиск");
            string str = Convert.ToString(Console.ReadLine());
            a.Find_el(str);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Окончание слова,которое будет удалено");
            str = Convert.ToString(Console.ReadLine());
            a.Del_el(str);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Максимальная длинна слова. Нажмите Enter");
            Console.ReadLine();
            a.MLenght_el();
            Console.ReadLine();
            Console.Clear();
            Console.ReadLine();
            a.maxLenght_words();
            Console.ReadLine();
            Console.Clear();

            Console.ReadLine();
        }
    }
}



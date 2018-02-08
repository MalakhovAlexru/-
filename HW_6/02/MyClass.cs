using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Модифицировать программу нахождения минимума функции так, чтобы можно было передавать  
//функцию в виде делегата. Сделать меню с различными функциями и представьте пользователю  
//выбор для какой функции и на каком отрезке находить минимум. 


namespace _02
{
    class MyClass
    {
        public delegate int F(int x);
        public int MyFun(int x)
        {
            return x * x - 50 * x + 10;
        }
        public int MyFun2(int x)
        {
            return x * x * (-1);
        }
        public int MyFun3(int x)
        {
            return x * x + 500;
        }
        public void MyMainFunc(string filename, F fi, int a, int b, int h)
        {
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter sr = new StreamWriter(fs, Encoding.GetEncoding(1251));
            int x = a;
            while (x <= b)
            {
                sr.WriteLine(fi(x));
                x += h;
            }
            sr.Close();
            fs.Close();
        }
        public static int Load(string fileName)
        {
            StreamReader str = new StreamReader(fileName, Encoding.GetEncoding(1251));
            int d = 0;
            int min = d;
            int c = 0;
            while (!str.EndOfStream)
            {
                int.TryParse(str.ReadLine(), out c);
                d = c;
                if (d < min) min = d;
            }
            str.Close();
            //Console.ForegroundColor = ConsoleColor.Blue;
            return min;
        }
        public void View(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            string input = null;
            Console.WriteLine("All elements in array is here:");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            while ((input = sr.ReadLine()) != null)
            {
                Console.WriteLine(input);
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\nthat's all...\n");
        }
    }
}

    
    


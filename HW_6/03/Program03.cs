using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Подсчитайте количество студентов:
//а) учащихся на 5 и 6 факультетах;
//б)* подсчитайте сколько студентов на каком курсе учатся;
//в) отсортируйте список по возрасту студента

namespace _03
{
    class Program03
    {
        static void Main(string[] args)
        {
            int[] m = new int[7];
            long summ = 0;
            List<MyClass03> list = new List<MyClass03>();
            DateTime dt = DateTime.Now;
            long magistr = 0, bakalav = 0;
            StreamReader sr = new StreamReader("students_4.csv");
            //while (!sr.EndOfStream)
            while (sr.Peek() != -1)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    // Добавляем в список новый экземпляр класса Student
                    list.Add(new MyClass03(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                    // Одновременно подсчитываем количество бакалавров и магистров
                    if (long.Parse(s[6]) < 5) bakalav++;
                    else magistr++;
                    if (long.Parse(s[6]) == 1) m[1] += 1;
                    if (long.Parse(s[6]) == 2) m[2] += 1;
                    if (long.Parse(s[6]) == 3) m[3] += 1;
                    if (long.Parse(s[6]) == 4) m[4] += 1;
                    if (long.Parse(s[6]) == 5) m[5] += 1;
                    if (long.Parse(s[6]) == 6) m[6] += 1;
                }
                catch (Exception e)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\nВыберите действие для продолжения\n1.Пропустить элемент и продолжить подсчет\n2.Прервать выполнение задания");
                    int sc = int.Parse(Console.ReadLine());
                    switch (sc)
                    {
                        case 1:
                            {
                                list.Skip(1);
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Ошибка!ESC прекратить выполнение программы");
                                // Выход из Main
                                if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                                break;
                            }
                    }
                }
            }
            Console.Clear();
            Console.WriteLine("Бакалавров: {0}\nМагистров: {1}\n\nВремени потрачено на выполнение: {2}", magistr, bakalav, DateTime.Now - dt);

            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine("\nСтудентов {0} курса:{1}", i, m[i]);
                summ = summ + m[i];
            }
            Console.WriteLine("\n\nВсего студентов: {0}", summ);
            Console.ReadLine();

            Console.WriteLine("hello:{0}", list.Take(5));
            Console.ReadLine();

            //list.Sort(1,5,null);

            //Console.WriteLine("hello:{0}",list.Take(5));
            //Console.ReadLine();

        }
        //int Compare(MyClass03 st1,MyClass03 st2)
        //{
        //    returt{ st1}
        //}
        ////int CompareTo(MyClass03 st1, object obj)
        ////{
        //    MyClass03 temp = obj as MyClass03;
        //    if (temp != null)
        //        return this.  .CompareTo(temp.CarlD);
        //    else
        //        // Параметр не является объектом типа Саг! 
        //        throw new ArgumentException("Parameter is not a Car!");
        //}
    }
}


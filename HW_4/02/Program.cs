using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//а)Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий
//массив заданной размерности и заполняющий массив числами от начального значения с заданным
//шагом.Создать свойство Sum, которые возвращают сумму элементов массива, метод Inverse,
//меняющий знаки у всех элементов массива, Метод Multi, умножающий каждый элемент массива на
//определенное число, метод MaxCounter и свойство MaxCount, возвращающее количество
//максимальных элементов.В Main продемонстрировать работу класса.
//б)* Добавить конструктор и методы, которые загружают данные из файла и записывают данные в
//файл.


namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initialize your array:");
            
            Console.WriteLine("enter value of array");
            int n = Convert.ToInt32(Console.ReadLine());
          

            MyArray ca = new MyArray();
            ca.Massiv(n);
            Console.WriteLine("\n\nYour array is:\n");


            ca.print();
            //Console.WriteLine("\n\n1.методо Sum (ввыод суммы всех членов массива)\n2.метод Inverse (инверсия членов массива)\n3.метод Multi (умножение всех членов массива на число)\n4.метод MaxCounter ()");
            string s;
            bool flag;
            int switchcase;
            //flag = int.TryParse(s,out switchcase);
            do
            {
                Console.WriteLine("\n\nДля продолжения нажмите Enter...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("\n\n1.метод Sum (ввыод суммы всех членов массива)\n2.метод Inverse (инверсия членов массива)\n3.метод Multi (умножение всех членов массива на число)\n4.метод MaxCounter ()\n0.Выход");
                s = Console.ReadLine();
                flag = int.TryParse(s, out switchcase);

                switch (switchcase)
                {
                    case 1:
                        {
                            ca.summ();
                            break;
                        }
                    case 2:
                        {
                            ca.Inverse();
                            break;
                        }
                    case 3:
                        {
                            ca.Multi();
                            break;
                        }
                    case 4:
                        {
                            // ca.MaxCount();
                            break;
                        }
                  
                    
                    case 0:
                        {
                            Console.WriteLine("See your later...");
                            break;
                        }
                        
                }
            } while (flag != false || switchcase != 0);

            Console.WriteLine("Good buy Master");
            Console.ReadLine();





        }
    }
}

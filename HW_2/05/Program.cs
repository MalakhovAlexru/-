using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс
//массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
//б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.


namespace _05
{
                
    class Program
    {
        static void mat(double height, double IMT)
        {
            height = height / 100;
            double IMT2 = 0;
            double temp = IMT;

            if (IMT < 18.5)
            {
                //while (temp <= 18.5)
                //   {
                //    temp = temp + 0.01;
                //    IMT2 = IMT2 + 0.01;
                //}
                double calc = (18.5 - IMT) * (height * height);
                Console.WriteLine("Вам необходимо набрать {0:F2} кг для нормы.", calc);
                Console.ReadLine();
            }
            if(IMT > 24.99)
            {
                
                //while (IMT >= 24.99)
                //   {
                //    temp = temp - 0.01;
                //    IMT2 = IMT2+0.01;
                //}
                //while (temp >= 24.99)
                //{
                //    temp = temp - 0.01;
                //    IMT2 = IMT2 + 0.01;
                //}
                double calc = (IMT - 24.99) * (height * height);
                Console.WriteLine("Вам необходимо сбросить {0:F2} кг для нормы.", calc);
                Console.ReadLine();
            }
        }
        static double sum(double height, double veight)
        {
            double calc;
            height = height / 100;
            calc = veight / (height * height);
            return calc;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваш рост в см");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ваш вес в кг");
            double veight = Convert.ToDouble(Console.ReadLine());
            double IMT = sum (height, veight);
            if (IMT <= 16)
            {
                Console.WriteLine("Ваш индекс массы тела равен {0}. \n Выраженный дефицит массы тела", IMT);
                mat(height,IMT);
            }
            if (IMT >= 16 && IMT <= 18.49)
            {
                Console.WriteLine("Ваш индекс массы тела равен {0}. \n Недостаточная (дефицит) масса тела", IMT);
                mat(height, IMT);
            }
                if (IMT >= 18.5 && IMT <= 24.99) Console.WriteLine("Ваш индекс массы тела равен {0}. \n Это норма", IMT);
            if (IMT >= 25 && IMT <= 30)
            {
                Console.WriteLine("Ваш индекс массы тела равен {0}. \n Избыточная масса тела (предожирение). Вам необходимо сбросить вес.", IMT);
                mat(height, IMT);
            }
            if (IMT >= 30 && IMT <= 35)
            {
                Console.WriteLine("Ваш индекс массы тела равен {0}. \n Ожирение первой степени", IMT);
                mat(height, IMT);
            }
            if (IMT >= 35 && IMT <= 40)
            {
                Console.WriteLine("Ваш индекс массы тела равен {0}. \n Ожирение второй степени", IMT);
                mat(height, IMT);
            }
            if (IMT >= 40.01)
            {
                Console.WriteLine("Ваш индекс массы тела равен {0}. \n Ожирение третьей степени (морбидное)", IMT);
                mat(height, IMT);
            }
               Console.ReadLine();
        }
    }
}

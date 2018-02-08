using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace _02
{

    class Mystring
    {
            Regex reg;
            string el;
            string s = File.ReadAllText("shablon.txt");
        
        public void Lenght_el(int n)
        {
            switch (n)
            {
                case 1:
                    {
                        el = @"\b\S{1,1}\b";
                        break;
                    }
                case 2:
                    {
                        el = @"\b\S{2,2}\b";
                        break;
                    }
                case 3:
                    {
                        el = @"\b\S{3,3}\b";
                        break;
                    }
                case 4:
                    {
                        el = @"\b\S{4,4}\b";
                        break;
                    }
                case 5:
                    {
                        el = @"\b\S{5,5}\b";
                        break;
                    }
                case 6:
                    {
                        el = @"\b\S{6,6}\b";
                        break;
                    }
                case 7:
                    {
                        el = @"\b\S{7,7}\b";
                        break;
                    }
                case 8:
                    {
                        el = @"\b\S{8,8}\b";
                        break;
                    }
            }

            
            reg = new Regex(el);
            Console.WriteLine(s);
            foreach (Match match in reg.Matches(s)) Console.WriteLine("Found '{0}' at position {1}", match.Value, match.Index);
                
        }
        public void Find_el(string str)
        {
            el = @"\b\w+"+str+@"\b";
            reg = new Regex(el);
            
            foreach (Match match in reg.Matches(s)) Console.WriteLine("Found '{0}' at position {1}", match.Value, match.Index);
        }
        public void Del_el(string str)
        {
            el = @"\b\w+" + str + @"\b";
            string del = "<<<DELETED>>>";
                  reg = new Regex(el);
            
            foreach (Match match in reg.Matches(s))
            {
                s = reg.Replace(s, del);
            }
            Console.WriteLine(s);
        }
        public void MLenght_el()
        {
            string MAX_old = "0",
                el = @"\b\w+\b";
            reg = new Regex(el);
            foreach (Match match in reg.Matches(s))
            {

                if (match.Length >= MAX_old.Length)
                {
                    MAX_old = match.Value;
                }
            }
            Console.WriteLine("Максимальная длина слова в сообщении: {1} букв, такую длину имеет слово: {0}", MAX_old, MAX_old.Length);
        }
        public void maxLenght_words()
        {
            int ML=0;
            string MAX_old = "0",el = @"\b\w+\b";
            reg = new Regex(el);
            string MSW = null;
            foreach (Match match in reg.Matches(s))
            {
                if (match.Length > MAX_old.Length)
                {
                    MAX_old = match.Value;
                }
            }
            foreach (Match match in reg.Matches(s))
            {
                if (match.Length == MAX_old.Length)
                {
                    MAX_old = match.Value;
                    MSW = MSW + " " + MAX_old + " , ";
                    ML = ML + 1;
                }
            }
            Console.WriteLine("Максимальная длина слова в сообщении: {0} букв, слова которые имеют максимальную длину:{1}\nТаких слов : {2}", MAX_old.Length,MSW, ML);
        }
    }
}
            
    



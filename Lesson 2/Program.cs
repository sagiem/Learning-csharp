using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime t = DateTime.Now; 

            if (t.Hour >= 6 && t.Hour < 11)
            {
                Console.WriteLine("Доброе утро !");
            }
            else if (t.Hour >= 11 && t.Hour < 17)
            {
                Console.WriteLine("Добрый день !");
            }
            else if (t.Hour >= 17 && t.Hour < 23)
            {
                Console.WriteLine("Добрый вечер !");
            }
            else  
            {
                Console.WriteLine("Доброй ночи !");
            }


            Console.ReadKey();
        }
    }
}

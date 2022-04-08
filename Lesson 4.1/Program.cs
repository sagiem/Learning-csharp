using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string s;
            int i;

            do
            {
                Console.Write("Bведите целое положительное число: ");
                s = Console.ReadLine();
            }
            while(!int.TryParse(s, out i) || i < 0);

            foreach (var item in s)
            {   
              
                    Console.Write(item + "-");
            }

            Console.ReadKey();
        }
    }
}

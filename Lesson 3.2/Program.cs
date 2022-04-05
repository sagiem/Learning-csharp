using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 10000000;
            int[] ar = new int[size];
            int[] ar2 = new int[size];
            int[] InAr = new int[size];

            Random random = new Random();

            for (int i = 0; i < size; i++)
                InAr[i] = random.Next();

            DateTime start = DateTime.Now;

            for (int i = 0; i < size; i++)
                ar[i] = InAr[i]/2;
            
            TimeSpan ts = DateTime.Now - start;

            start = DateTime.Now;

            for (int i = 0; i < size; i++)
                ar2[i] = InAr[i] >> 1;
            
            TimeSpan ts2 = DateTime.Now - start;

            Console.WriteLine("Деление {0}  Сдвиг {1}", ts.Milliseconds, ts2.Milliseconds);

            Console.ReadKey();
        }
    }
}

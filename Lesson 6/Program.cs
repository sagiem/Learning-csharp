using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = 10000;
            int max = 50000;
            int step = 5000;
            DateTime start;
            TimeSpan ts1, ts2;

            for (int size = min; size <= max; size += step)
            {
                start = DateTime.Now;
                string s1 = GenerationString(size);
                ts1 = DateTime.Now - start;

                start = DateTime.Now;
                string s2 = GenerationSBuilder(size);
                ts2 = DateTime.Now - start;

                Console.WriteLine("s1.lenght = {0}, s2.lenght = {1}, ts1 = {2}, ts2 = {3}, ts1/ts2 = {4}",
                                     s1.Length,
                                     s2.Length,
                                     ts1.Milliseconds,
                                     ts2.Milliseconds,
                                     ts1.TotalMilliseconds/ts2.TotalMilliseconds);

            }

            Console.ReadKey();

        }

        static string GenerationString(int size)
        {
            string s = "";

            for (int i = 0; i < size; i++)
                s += string.Format("{0}", i);
            return s;
        }

        static string GenerationSBuilder(int size)
        {
            
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < size; i++)
                sb.AppendFormat("{0}", i);
            return sb.ToString();
        }
    }
}

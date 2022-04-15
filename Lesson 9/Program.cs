using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 2, 5, 10, 20, 9, 18, 55, 37 };
            Array.Sort(ar,drop);

            foreach (var item in ar)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }

        static int drop(int x, int y)
        {
            if (x%2 != 0 && y%2 ==0)
                return 1;
            else
                return -1;
        }
    }
}

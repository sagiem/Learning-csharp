using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        static int GetFactorial(int i)
        {
            if (i == 0 || i == 1)
                return 1;
            else
                return GetFactorial(i - 1) * i; // 3! = 3 * 2 *1
        }
    }
}

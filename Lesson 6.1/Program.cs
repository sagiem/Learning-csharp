using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static double min2(double x, double y)
        {
            //return Math.Min(x, y);
            return x < y ? x : y;
        }

        static double min4(double x1, double y1, double x2, double y2)
        {

            return min2(min2(x1, y1), min2(x2, y2));

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(polynom(2,3,4));
        }

        static double polynom(double x, params int[] coef)
        {
            double pol = 0;
            for (int i = 0; i < coef.Length; i++)
                pol=pol*x+coef[i];
            return pol;
        }
    }
}

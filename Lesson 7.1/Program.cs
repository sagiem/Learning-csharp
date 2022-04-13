using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 3;
            double b = 4;
            double c = 5;

            S()
        }

        /// <summary>
        /// Вычисление площади квадрата
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static double S(double x)
        { 
            return x * x;
        }

        /// <summary>
        /// Вычисление площади прямоугольника
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        static double S(double x, double b)
        {
            return x * b;
        }

        /// <summary>
        /// вычисление площади параллелепипеда
        /// </summary>
        /// <param name="x"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static double S(double x, double b, double c)
        {
            return 2 * (x * b + x * c + b * c);
        }
    }
}

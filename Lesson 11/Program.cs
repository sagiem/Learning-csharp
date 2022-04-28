using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle cir = new Circle();
            cir.Rad = 10;
            cir.X = 10;
            cir.Y = 12;
            cir.Display();

            Console.ReadKey();

        }


    }

    class Circle : Point
    {
        private double rad;
        private Point center = new Point();

        public double Rad
        { get { return rad; } 
          set { rad = value; } 
        }

        public double Len
        {
            get { return 2 * Math.PI * rad; }
        }

        public Point Center
        {
            get { return center; }
            set { center = value; }
        }

        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1}, Rad = {2}, Len = {3}", X, Y, rad, Len );
        }

       
    }

    class Point
    {
        private double x;
        private double y;

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }
    }
}

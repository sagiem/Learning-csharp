using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11._1
{
    internal class Cube : Figure
    {
     
        private double z;

        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        public Cube(double xi, double yi, double zi)
        {
            X = xi;
            Y = yi;
            z = zi;
        }
    }
}

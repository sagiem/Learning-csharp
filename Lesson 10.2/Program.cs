using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Real number = new Real(920.5, 2);
            Real number1 = new Real(-20.77);
            Real number2 = new Real(number);
        }
    }

    class Real
    {
        private double m = 8;
        private int p;

        public Real(double mi, int pi)
        {
            m = mi;
            p = pi;
        }

        public Real(double mi)
            :this(mi, 10){ }

        public Real(Real r)
            :this(r.m, r.p) { }
    }
}

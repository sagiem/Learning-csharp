using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Скоро мы пойдем домой";
            File.WriteAllText("default.txt", s);
            File.WriteAllText("windows1251.txt", s, Encoding.GetEncoding(1251));
        }
    }
}

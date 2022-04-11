using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String s1 = "мама мыла раму";
            string[] arr =s1.Split(' ');
            Array.Reverse(arr);
            string s2 = string.Join("+", arr);
            Console.WriteLine(s2);
            
            Console.ReadKey();
        }
    }
}

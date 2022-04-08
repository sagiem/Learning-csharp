using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"file.txt";
            string s = File.ReadAllText(path);
            string[] fam=s.Split(new string[] {"\r\n"}, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(fam);
            foreach (var st in fam)
                Console.WriteLine(st);

            Console.ReadKey();
        }
    }
}

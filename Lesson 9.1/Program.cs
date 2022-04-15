using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict["один"] = 1;
            dict["два"] = 2;
            dict["три"] = 3;
            dict["четыре"] = 4;
            dict["пять"] = 5;
            dict["шесть"] = 6;
            dict["семь"] = 7;
            dict["восемь"] = 8;
            dict["девять"] = 9;

            Console.WriteLine("введите выражение типа, 'и два и три'");
            Console.Write(">");
            string[] patch = Console.ReadLine().Split(new string[] {" и "}, StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;
            int value = 0;
            bool error = false;

            for (int i = 0; i < patch.Length; i++)
            {
                string key = patch[i];
                if(dict.ContainsKey(key))
                {
                    value = dict[key];
                    sum += value;
                }
                else
                {
                    Console.WriteLine("Неизвестное значение ключа {0}", key);
                    error = true;
                    break;
                }
            }



        }
    }
}

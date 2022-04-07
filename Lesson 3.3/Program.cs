using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            int k = 500;
            int l = -10;
            int sum = 0;
            int a, b;

            for (int i = n; i <= k; i++)
            {
                if (i % 2 == 0)
                    sum += i;
            }
            Console.WriteLine("Сумма целых чисел от 100 до 500 равна {0}", sum);
            sum = 0;

            Console.WriteLine("введите число A");
            a =int.Parse(Console.ReadLine());

            if (a < 500)
            {
                for (int i = a; i <= k; i++)
                {
                    if (i % 2 == 0)
                        sum += i;
                }
                Console.WriteLine("Сумма целых чисел от {1} до 500 равна {0}", sum, a);
                sum = 0;
            }
            else
                Console.WriteLine("число A должно быть меньше 500");




            Console.WriteLine("введите число B");
            b = int.Parse(Console.ReadLine());

            if (b > -10)
            {
                for (int i = l; i <= k; i++)
                {
                    if (i % 2 == 0)
                        sum += i;
                }
                Console.WriteLine("Сумма целых чисел от -10 до {1} равна {0}", sum, b);
                sum = 0;
            }
            else
                Console.WriteLine("число B должно быть больше -10");



            Console.WriteLine("введите число A");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("введите число B");
            b = int.Parse(Console.ReadLine());

            if (b > a)
            {
                for (int i = a; i <= b; i++)
                {
                    if (i % 2 == 0)
                        sum += i;
                }
                Console.WriteLine("Сумма целых чисел от {1} до {2} равна {0}", sum, a, b);
                sum = 0;
            }
            else
                Console.WriteLine("число B должно быть больше числа A");





            Console.ReadKey();
        }
    }
}

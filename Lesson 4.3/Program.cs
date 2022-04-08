using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int size;

            do
            {
                Console.Write("Bведите целое положительное число: ");

            }
            while (!int.TryParse(Console.ReadLine(), out size) || size < 0);

            int[,] arr = new int[size, size];

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    if(i==j)
                        arr[i,j] = 1;

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < size; j++)
                    Console.Write(" " + arr[i, j]);
            }

            Console.ReadKey();
        }
    }
}

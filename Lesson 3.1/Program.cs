using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("введите первое число");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите действие");
            char t = char.Parse(Console.ReadLine());

            Console.WriteLine("введите второе число");
            double b = double.Parse(Console.ReadLine());

            switch (t)
            {
                case '+':
                    Console.WriteLine("{0} {1} {2} = {3}", a, t, b, a + b);  
                    break;                            
                                                      
                case '-':                             
                    Console.WriteLine("{0} {1} {2} = {3}", a, t, b, a - b);  
                    break;                            
                                                      
                case '/':                             
                    Console.WriteLine("{0} {1} {2} = {3}", a, t, b, a / b);  
                    break;                            
                                                      
                case '*':                             
                    Console.WriteLine("{0} {1} {2} = {3}", a, t, b, a * b);  
                    break;

                default:

                    Console.WriteLine("Введены неверные значения");
                    break;
            }

            Console.ReadKey();

        }
    }
}
